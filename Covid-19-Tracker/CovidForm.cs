using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using CovidSharp;
using System.Drawing;
using System.Net;
using System.Text;

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

        bool dragging;
        Point offset;
        static bool connection_status = false;

        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams cp = base.CreateParams;
                cp.ExStyle = cp.ExStyle | 0x2000000;
                return cp;
            }
        }

        const string covid_file = "Covid-19_data.csv";
        static CoronavirusData covid_data;
        private static string global_countries = "Global (All Countries)", data_not_available = "Data not available", country_not_available = "Country not available";
        internal const string ACTIVE_CASE = "active", FATAL_CASE = "fatal", RECOVERED_CASE = "recovered", ALL_CASE = "all";

        public CovidForm()
        {
            InitializeComponent();
            covid_data = new CoronavirusData();
        }

        //Private method for showing error.
        internal static void ShowError(string err_msg, string arg = "")
        {
            DialogBox db = new DialogBox();
            db.Title.Text = "ERROR";
            db.message.Text = err_msg;
            db.ShowDialog();
        }

        //Private method for showing warning.
        internal static void ShowWarning(string warning_msg, string arg = "")
        {
            DialogBox db = new DialogBox();
            db.Title.Text = "WARNING";
            db.message.Text = warning_msg;
            db.ShowDialog();
        }

        //Private method for showing information.
        internal static void ShowInfo(string info_msg, string arg = "")
        {
            DialogBox db = new DialogBox();
            db.Title.Text = "INFORMATION";
            db.message.Text = info_msg;
            db.ShowDialog();
        }

        void SetConnectionStatus(bool status)
        {
            if (status)
            {
                connection_lbl.Text = "Online";
                connection_lbl.ForeColor = Color.Green;
                connection_status = true;
                export_data_btn.Enabled = display_data_btn.Enabled = true;
            }
            else
            {
                connection_lbl.Text = "Offline";
                connection_lbl.ForeColor = Color.Red;
                connection_status = false;
                export_data_btn.Enabled = display_data_btn.Enabled = false;
            }
        }

        void CovidGetGlobalData()
        {
            confirm_txt_box.Text = covid_data.LatestConfirmed();
            fatal_txt_box.Text = covid_data.LatestDeaths();
            recovered_txt_box.Text = covid_data.LatestRecovered();
        }

        void CovidGetCountryData(string country_name)
        {
            confirm_txt_box.Text = covid_data.FromCountryNameConfirmed(country_name);
            fatal_txt_box.Text = covid_data.FromCountryNameDeaths(country_name);
            recovered_txt_box.Text = covid_data.FromCountryNameRecovered(country_name);
        }

        void CovidGetProvinceData(string province_name)
        {
            confirm_txt_box.Text = CovidHelper.FromCountryProvinceConfirmed(province_name);
            fatal_txt_box.Text = CovidHelper.FromCountryProvinceDeaths(province_name);
            recovered_txt_box.Text = CovidHelper.FromCountryProvinceRecovered(province_name);
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

        static void CovidLoadData(CountriesInfo country_info, List<CovidDataList> covid_data_list, string filter_option, int display_size = 6)
        {
            try
            {
                Label[] countries_label = { country_info.country_1, country_info.country_2, country_info.country_3, country_info.country_4, country_info.country_5, country_info.country_6 };
                Label[] countries_active = { country_info.country_1_active, country_info.country_2_active, country_info.country_3_active, country_info.country_4_active, country_info.country_5_active, country_info.country_6_active };
                Label[] countries_fatal = { country_info.country_1_fatal, country_info.country_2_fatal, country_info.country_3_fatal, country_info.country_4_fatal, country_info.country_5_fatal, country_info.country_6_fatal };
                Label[] countries_recovered = { country_info.country_1_recovered, country_info.country_2_recovered, country_info.country_3_recovered, country_info.country_4_recovered, country_info.country_5_recovered, country_info.country_6_recovered };
                PictureBox[] countries_flags_pb = { country_info.country_1_picbox, country_info.country_2_picbox, country_info.country_3_picbox, country_info.country_4_picbox, country_info.country_5_picbox, country_info.country_6_picbox };

                if (filter_option == ACTIVE_CASE)
                {
                    covid_data_list = covid_data_list.OrderByDescending(cd_list => ulong.Parse(cd_list.active_cases)).ToList();
                    country_info.title.Text = "Countries Info by Active cases";
                }
                else if (filter_option == FATAL_CASE)
                {
                    covid_data_list = covid_data_list.OrderByDescending(cd_list => ulong.Parse(cd_list.fatal_cases)).ToList();
                    country_info.title.Text = "Countries Info by Fatal cases";
                }
                else if (filter_option == RECOVERED_CASE)
                {
                    //covid_data_list = covid_data_list.OrderByDescending(cd_list => ulong.Parse(cd_list.recovered_cases)).ToList();
                    country_info.title.Text = "Countries Info by Recovered cases";
                    ShowWarning("Recovered cases has problem right now correct information is not displayed");
                }

                //Reset previous data.
                for (int index = 0; index < display_size; ++index)
                {
                    countries_active[index].Text = "NAN";
                    countries_fatal[index].Text = "NAN";
                    countries_recovered[index].Text = "NAN";
                }

                //Load the data on information page.
                string active_cases = null, fatal_cases = null, recovered_cases = null;
                for (int index = 0; index < display_size; ++index)
                {
                    string country = covid_data_list[index].country;
                    active_cases = covid_data_list[index].active_cases;
                    fatal_cases = covid_data_list[index].fatal_cases;
                    recovered_cases = covid_data_list[index].recovered_cases;

                    countries_label[index].Text = country;

                    if (filter_option == ACTIVE_CASE)
                        countries_active[index].Text = active_cases;
                    else if (filter_option == FATAL_CASE)
                        countries_fatal[index].Text = fatal_cases;
                    else if (filter_option == RECOVERED_CASE)
                        countries_recovered[index].Text = recovered_cases;

                    //Load the flag.
                    if (connection_status)
                    {
                        string country_code = CovidHelper.GetCountryCode4mName(country);
                        string flags_url = CovidHelper.GetFlagsURL(country_code);
                        countries_flags_pb[index].Load(flags_url);
                    }
                }
            }
            catch (Exception ex)
            {
                ShowError(ex.Message);
            }
        }

        static List<CovidDataList> CovidGetDataList()
        {
            var covid_data_list = new List<CovidDataList>();
            const string header_str = "Recovered";
            if (!File.Exists(covid_file))
                throw new Exception("Please Export Covid data first.");

            //Read all the data from file.
            string data = File.ReadAllText(covid_file);//Remove the header
            data = data.Remove(0, data.IndexOf(header_str) + header_str.Length);
            data = data.Replace("\n", ",");

            string[] tokens = data.Split(new[] { "," }, StringSplitOptions.RemoveEmptyEntries);
            string country = null, active_case = null, fatal_case = null, recovered_case = null;
            int index = 0;

            foreach (var token in tokens)
            {
                //ShowWarning("Token : " + token + " Index : " + index);
                if (index == (int)CovidEnum.COUNTRY)
                {
                    if (!token.Any(char.IsDigit))
                        country = token;
                    else
                        recovered_case = token;
                    ;// ShowError("Error parsing country : " + token);
                }

                if (index == (int)CovidEnum.ACTIVE || index == (int)CovidEnum.FATAL || index == (int)CovidEnum.RECOVERED)
                {
                    if (token.All(char.IsDigit))
                    {
                        if (index == (int)CovidEnum.ACTIVE) active_case = token;
                        if (index == (int)CovidEnum.FATAL) fatal_case = token;
                        if (index == (int)CovidEnum.RECOVERED) recovered_case = token;
                    }
                    else
                        country = token;
                    //ShowError("Error parsing Properties : " + token);
                }


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

        internal static void CovidDisplayData(CountriesInfo country_info, string filter_option)
        {
            try
            {
                //Sort the data as per filter option.
                var covid_data_list = CovidGetDataList();
                CovidLoadData(country_info, covid_data_list, filter_option);
            }
            catch (Exception ex)
            {
                ShowError(ex.Message);
            }
        }


        public static List<string> GetCountryList()
        {
            var country_list = new List<string>();
            string country_data = covid_data.GetCountryList();
            if (country_data.Contains(data_not_available))
            {
                country_data = country_not_available;
                country_list.Add(country_data);
            }
            else
            {
                country_list = country_data.Split(new char[] { '\n' }).ToList();
                country_list.Add(global_countries);
            }
            return country_list;
        }

        private object GetProvinceList(string country)
        {
            string province_data = CovidHelper.GetProvinceList4mCountry(country);
            List<string> province_list = province_data.Split(new char[] { '\n' }).ToList();
            return province_list;
        }

        private void country_dd_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                string country_name = country_dd.SelectedItem.ToString();

                if (country_name != country_not_available)
                    SetConnectionStatus(true);

                if (country_dd.SelectedItem == global_countries)
                {
                    CovidGetGlobalData();
                }
                else
                {
                    var province_list = GetProvinceList(country_name);
                    string country_code = CovidHelper.GetCountryCode4mName(country_name);

                    //Get province data.
                    province_dd.DataSource = province_list;
                    CovidGetCountryData(country_name);

                    //Load the flag.
                    string flags_url = CovidHelper.GetFlagsURL(country_code);
                    country_flag_picbox.Load(flags_url);
                }
            }
            catch (NullReferenceException ex)
            {
                ShowError("Internet connection lost");
                confirm_txt_box.Text = fatal_txt_box.Text = recovered_txt_box.Text = "NAN";
                SetConnectionStatus(false);
            }

            catch (Exception ex)
            {
                if (ex.Message.Contains("(404) Not Found"))
                    country_flag_picbox.Load(CovidHelper.country_error_url);
                else
                    ShowError(ex.Message);
            }
        }

        private void display_data_btn_Click(object sender, EventArgs e)
        {
            CountriesInfo country_info = new CountriesInfo();
            country_info.ShowDialog();
        }

        private void bg_container_MouseDown(object sender, MouseEventArgs e)
        {
            dragging = true;
            offset = e.Location;
        }

        private void bg_container_MouseMove(object sender, MouseEventArgs e)
        {
            if (dragging)
            {
                Point currentScreenPos = PointToScreen(e.Location);
                Location = new
                Point(currentScreenPos.X - offset.X,
                currentScreenPos.Y - offset.Y);
            }
        }

        private void bg_container_MouseUp(object sender, MouseEventArgs e)
        {
            dragging = false;

        }

        private void confirm_txt_box_TextChanged(object sender, EventArgs e)
        {
            Label TargetControl = confirm_txt_box;
            if (TargetControl.Text.Length >= 5 && TargetControl.Text.Length <= 9)
            {
                TargetControl.Font = new Font("Courier New", 21, FontStyle.Bold);
            }

            if (TargetControl.Text.Length >= 8)
            {
                TargetControl.Font = new Font("Courier New", 9, FontStyle.Bold);
            }

            if (TargetControl.Text.Length <= 6)
            {
                TargetControl.Font = new Font("Courier New", 34, FontStyle.Bold);
            }


            Label TargetControl1 = fatal_txt_box;
            if (TargetControl1.Text.Length >= 5 && TargetControl1.Text.Length <= 9)
            {
                TargetControl1.Font = new Font("Courier New", 21, FontStyle.Bold);
            }

            if (TargetControl1.Text.Length >= 8)
            {
                TargetControl1.Font = new Font("Courier New", 9, FontStyle.Bold);
            }

            if (TargetControl1.Text.Length <= 6)
            {
                TargetControl1.Font = new Font("Courier New", 34, FontStyle.Bold);
            }


            Label TargetControl2 = recovered_txt_box;
            if (TargetControl2.Text.Length >= 5 && TargetControl2.Text.Length <= 9)
            {
                TargetControl2.Font = new Font("Courier New", 21, FontStyle.Bold);
            }

            if (TargetControl2.Text.Length >= 8)
            {
                TargetControl2.Font = new Font("Courier New", 9, FontStyle.Bold);
            }

            if (TargetControl2.Text.Length <= 6)
            {
                TargetControl2.Font = new Font("Courier New", 34, FontStyle.Bold);
            }

        }

        private void close_button_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bg_container_Paint(object sender, PaintEventArgs e)
        {

        }

        private void province_dd_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                string province_name = province_dd.SelectedItem.ToString();
                CovidGetProvinceData(province_name);
            }
            catch (NullReferenceException ex)
            {
                confirm_txt_box.Text = fatal_txt_box.Text = recovered_txt_box.Text = "NAN";
            }

            catch (Exception ex)
            {
                ShowError(ex.Message);
            }
        }

        private void help_btn_Click(object sender, EventArgs e)
        {
            StringBuilder help_str = new StringBuilder();
            help_str.Append("Application Name : Covid-19 Tracker\n");
            help_str.Append("Application Version : 1.1\n");
            help_str.Append("UI Design : CRONOQUILL\n");
            help_str.Append("Core Application : Haseeb Mir\n");
            help_str.Append("Data Source API/SDK : (JHU & CSBS) With CovidSharp SDK With .NET 4.7\n");
            ShowInfo(help_str.ToString());
        }

        private void bg_container_MouseClick(object sender, MouseEventArgs e)
        {
            if (connection_lbl.Text == "Offline")
            {
                var country_list = GetCountryList();
                if (!country_list.Contains(data_not_available))
                {
                    SetConnectionStatus(true);
                    country_dd.DataSource = country_list;
                }
            }
        }

        private void minimize_button_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void CovidForm_Load(object sender, EventArgs e)
        {
            var country_list = GetCountryList();
            var province_list = GetProvinceList(country_list[0].ToString());
            country_dd.DataSource = country_list;
            province_dd.DataSource = province_list;

        }


        private void export_data_btn_Click(object sender, EventArgs e)
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
