using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using CovidSharp;

namespace Covid_19_Tracker
{

    public partial class CovidForm : Form
    {
        enum CovidEnum
        {
            COUNTRY,
            ACTIVE,
            FATAL,
            RECOVERED,
        }

        const string covid_file = "Covid-19_data.csv";
        CoronavirusData covid_data;
        private const string ACTIVE_CASE = "active", FATAL_CASE = "fatal", RECOVERED_CASE = "recovered", ALL_CASE = "all";

        public CovidForm()
        {
            InitializeComponent();
            covid_data = new CoronavirusData();
        }

        //Private method for showing error.
        internal void ShowError(string err_msg, string arg = "")
        {
            MessageBox.Show(err_msg, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        //Private method for showing warning.
        internal void ShowWarning(string warning_msg, string arg = "")
        {
            MessageBox.Show(warning_msg, "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        //Private method for showing information.
        internal void ShowInfo(string info_msg, string arg = "")
        {
            MessageBox.Show(info_msg, "INFORMATION", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        void CovidGetGlobalData()
        {
            confirm_txt_box.Text = covid_data.LatestConfirmed();
            deaths_txt_box.Text = covid_data.LatestDeaths();
            recovered_txt_box.Text = covid_data.LatestRecovered();
        }

        void CovidGetCountryData(string country_name)
        {
            confirm_txt_box.Text = covid_data.FromCountryNameConfirmed(country_name);
            deaths_txt_box.Text = covid_data.FromCountryNameDeaths(country_name);
            recovered_txt_box.Text = covid_data.FromCountryNameRecovered(country_name);
        }

        void CovidGenerateData()
        {
            string delimiter = ",", covid_header = "Country,Active,Fatal,Recovered\n";
            File.WriteAllText(covid_file, covid_header);
            var country_list = GetCountryList();

            foreach (var country in country_list)
            {
                try
                {
                    string active_case = covid_data.FromCountryNameConfirmed(country);
                    string fatal_case = covid_data.FromCountryNameDeaths(country);
                    string recovered_case = covid_data.FromCountryNameRecovered(country);

                    string file_data = country + delimiter + active_case + delimiter + fatal_case + delimiter + recovered_case + "\n";
                    File.AppendAllText(covid_file, file_data);
                }
                catch (Exception ex) { }
            }
            ShowInfo("Covid data has been generated to file '" + covid_file + "'");
        }

        void CovidSortData(List<CovidDataList> covid_data_list, string filter_option, int display_size = 10)
        {
            string active_case = null, fatal_case = null, recovered_case = null;
            if (filter_option == ACTIVE_CASE)
            {
                covid_data_list = covid_data_list.OrderByDescending(n => Convert.ToInt32(n.active_cases)).ToList();
                for (int index = 0; index < display_size; ++index)
                    active_case += "\nCountry : " + covid_data_list[index].country + "\nActive case : " + covid_data_list[index].active_cases + "\n";
                ShowInfo(active_case);
            }

            else if (filter_option == FATAL_CASE)
            {
                covid_data_list = covid_data_list.OrderByDescending(n => Convert.ToInt32(n.fatal_cases)).ToList();
                for (int index = 0; index < display_size; ++index)
                    fatal_case += "\nCountry : " + covid_data_list[index].country + "\nFatal case : " + covid_data_list[index].fatal_cases + "\n";
                ShowInfo(fatal_case);
            }

            else if (filter_option == RECOVERED_CASE)
            {
                covid_data_list = covid_data_list.OrderByDescending(n => Convert.ToInt32(n.recovered_cases)).ToList();
                for (int index = 0; index < display_size; ++index)
                    recovered_case += "\nCountry : " + covid_data_list[index].country + "\nRecovered case : " + covid_data_list[index].recovered_cases + "\n";
                ShowInfo(recovered_case);
            }
        }

        List<CovidDataList> CovidGetDataList()
        {
            var covid_data_list = new List<CovidDataList>();
            const string header_str = "Recovered";
            if (!File.Exists(covid_file))
                throw new Exception("Please generate Covid data first.");

            //Read all the data from file.
            string data = File.ReadAllText(covid_file);//Remove the header
            data = data.Remove(0, data.IndexOf(header_str) + header_str.Length);
            data = data.Replace("\n", ",");

            string[] tokens = data.Split(new[] { "," }, StringSplitOptions.RemoveEmptyEntries);
            string country = null, active_case = null, fatal_case = null, recovered_case = null;
            int index = 0;

            foreach (var token in tokens)
            {
                country = (index == (int)CovidEnum.COUNTRY) ? token : country;
                active_case = (index == (int)CovidEnum.ACTIVE) ? token : active_case;
                fatal_case = (index == (int)CovidEnum.FATAL) ? token : fatal_case;
                recovered_case = (index == (int)CovidEnum.RECOVERED) ? token : recovered_case;

                index++;//Add whole line to covid_list.
                if (index > (int)CovidEnum.RECOVERED)
                {
                    var covid_list = new CovidDataList(country, active_case, fatal_case, recovered_case);
                    covid_data_list.Add(covid_list);
                    index = 0;
                }
            }
            return covid_data_list;
        }

        void CovidDisplayData(string filter_option)
        {
            try
            {
                //Sort the data as per filter option.
                var covid_data_list = CovidGetDataList();
                CovidSortData(covid_data_list, filter_option);
            }
            catch (Exception ex)
            {
                ShowError(ex.Message);
            }
        }


        public static List<string> GetCountryList()
        {
            List<string> CountryList = new List<string>();

            CultureInfo[] cultures = CultureInfo.GetCultures(CultureTypes.SpecificCultures);
            foreach (CultureInfo culture in cultures)
            {
                RegionInfo region = new RegionInfo(culture.LCID);

                if (!(CountryList.Contains(region.EnglishName)))
                {
                    CountryList.Add(region.EnglishName);
                }
            }
            CountryList.Sort();
            return CountryList;

        }

        private void country_dd_SelectedIndexChanged(object sender, EventArgs e)
        {
            confirm_txt_box.Text = deaths_txt_box.Text = recovered_txt_box.Text = "";
        }

        private void display_data_btn_Click(object sender, EventArgs e)
        {
            string filter_option = null;
            if (active_cb.Checked) filter_option = ACTIVE_CASE;
            else if (fatal_cb.Checked) filter_option = FATAL_CASE;
            else if (recovered_cb.Checked) filter_option = RECOVERED_CASE;

            if (filter_option == null)
                ShowError("No option was selected to filter data.");
            else
                CovidDisplayData(filter_option);
        }

        private void corona_data_btn_Click(object sender, EventArgs e)
        {
            string country_name = country_dd.SelectedItem.ToString();

            if (active_cb.Checked)
            {
                if (global_cb.Checked)
                    confirm_txt_box.Text = covid_data.LatestConfirmed();
                else
                    confirm_txt_box.Text = covid_data.FromCountryNameConfirmed(country_name);
            }
            if (fatal_cb.Checked)
            {
                if (global_cb.Checked)
                    deaths_txt_box.Text = covid_data.LatestDeaths();
                else
                    deaths_txt_box.Text = covid_data.FromCountryNameDeaths(country_name);
            }
            if (recovered_cb.Checked)
            {
                if (global_cb.Checked)
                    recovered_txt_box.Text = covid_data.LatestRecovered();
                else
                    recovered_txt_box.Text = covid_data.FromCountryNameRecovered(country_name);
            }
            if (active_cb.Checked && fatal_cb.Checked)
            {
                if (global_cb.Checked)
                {
                    confirm_txt_box.Text = covid_data.LatestConfirmed();
                    deaths_txt_box.Text = covid_data.LatestDeaths();
                }
                else
                {
                    confirm_txt_box.Text = covid_data.FromCountryNameConfirmed(country_name);
                    deaths_txt_box.Text = covid_data.FromCountryNameDeaths(country_name);
                }
            }
            if (active_cb.Checked && recovered_cb.Checked)
            {
                if (global_cb.Checked)
                {
                    confirm_txt_box.Text = covid_data.LatestConfirmed();
                    recovered_txt_box.Text = covid_data.LatestRecovered();
                }
                else
                {
                    confirm_txt_box.Text = covid_data.FromCountryNameConfirmed(country_name);
                    recovered_txt_box.Text = covid_data.FromCountryNameRecovered(country_name);
                }
            }
            if (active_cb.Checked && fatal_cb.Checked && recovered_cb.Checked)
                CovidGetCountryData(country_name);
            if (active_cb.Checked && fatal_cb.Checked && recovered_cb.Checked && global_cb.Checked)
                CovidGetGlobalData();

            if (!(active_cb.Checked || fatal_cb.Checked || recovered_cb.Checked))
                ShowError("No option was selected to filter data.");
        }

        private void CovidForm_Load(object sender, EventArgs e)
        {
            var country_list = GetCountryList();
            country_dd.DataSource = country_list;
        }

        private void generate_data_btn_Click(object sender, EventArgs e)
        {
            if (File.Exists(covid_file))
                ShowWarning("Covid data file already exist in current directory.");
            else
                CovidGenerateData();
        }
    }

    //Class for covid data list containing all the data sets.
    internal class CovidDataList
    {

        public string country { get; set; }
        public string active_cases { get; set; }
        public string fatal_cases { get; set; }
        public string recovered_cases { get; set; }

        public CovidDataList(string country, string active_cases, string fatal_cases, string recovered_cases)
        {
            this.country = country;
            this.active_cases = active_cases;
            this.fatal_cases = fatal_cases;
            this.recovered_cases = recovered_cases;
        }
    }
}
