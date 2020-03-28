using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Covid_19_Tracker
{
    public partial class CountriesInfo : Form
    {
        private const int display_size = 6;

        public CountriesInfo()
        {
            InitializeComponent();
        }

        private void close_btn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CountriesInfo_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (this.ParentForm != null)
                this.ParentForm.Show();
        }

        private void CountriesInfo_Load(object sender, EventArgs e)
        {

        }

        private void bg_container_Paint(object sender, PaintEventArgs e)
        {

        }

        private void ResetCountriesDetails() {

            Label[] countries_label = { country_1, country_2, country_3, country_4, country_5, country_6 };
            Label[] countries_active = { country_1_active, country_2_active, country_3_active, country_4_active, country_5_active, country_6_active };
            Label[] countries_fatal = { country_1_fatal, country_2_fatal, country_3_fatal, country_4_fatal, country_5_fatal, country_6_fatal };
            Label[] countries_recovered = { country_1_recovered, country_2_recovered, country_3_recovered, country_4_recovered, country_5_recovered, country_6_recovered };
            PictureBox[] countries_flags_pb = { country_1_picbox, country_2_picbox, country_3_picbox, country_4_picbox, country_5_picbox, country_6_picbox };

            title.Text = "Countries Information";
            for (int index = 0; index < display_size; ++index)
            {
                countries_label[index].Text = "Country";
                countries_active[index].Text = countries_fatal[index].Text = countries_recovered[index].Text = "NAN";
            }
        }

        private void active_cb_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(active_cb.Text))
                active_cb.Text = "✓";
            else
                active_cb.Text = "";
        }

        private void fatal_cb_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(fatal_cb.Text))
                fatal_cb.Text = "✓";
            else
                fatal_cb.Text = "";
        }

        private void recovered_cb_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(recovered_cb.Text))
                recovered_cb.Text = "✓";
            else
                recovered_cb.Text = "";
        }

        private void show_info_btn_Click(object sender, EventArgs e)
        {
            bool active_cb_checked = active_cb.Text == "✓";
            bool fatal_cb_checked = fatal_cb.Text == "✓";
            bool recovered_cb_checked = recovered_cb.Text == "✓";
            string filter_option = (active_cb_checked) ? CovidForm.ACTIVE_CASE : ( (fatal_cb_checked) ? CovidForm.FATAL_CASE : (recovered_cb_checked) ? CovidForm.RECOVERED_CASE : null );
            if (filter_option == null)
            {
                ResetCountriesDetails();
                CovidForm.ShowError("No option was selected to filter data");
            }
            else
                CovidForm.CovidDisplayData(this, filter_option);
        }
    }
}
