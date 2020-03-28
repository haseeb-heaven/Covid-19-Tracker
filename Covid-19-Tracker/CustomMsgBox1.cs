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
    public partial class CustomMsgBox1 : Form
    {
        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams cp = base.CreateParams;
                cp.ExStyle = cp.ExStyle | 0x2000000;
                return cp;
            }
        }
        //Add this Before Initilize Components Method
        bool dragging;
        Point offset;
        public CustomMsgBox1()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void MsgBox_Load(object sender, EventArgs e)
        {
            int Wdth = Title.Size.Width;
            panel2.Size = new Size(Wdth, panel2.Size.Height);
        }

        private void OK_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void MsgBox_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (this.ParentForm != null)
                this.ParentForm.Show();
        }

        private void Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form_MouseDown(object sender, MouseEventArgs e)
        {
            //Add this Under Control_MouseDown Event
            dragging = true;
            offset = e.Location;
        }

        private void Form_MouseMove(object sender, MouseEventArgs e)
        {
            if (dragging)
            {
                Point currentScreenPos = PointToScreen(e.Location);
                Location = new
                Point(currentScreenPos.X - offset.X,
                currentScreenPos.Y - offset.Y);
            }
        }

        private void Form_MouseUp(object sender, MouseEventArgs e)
        {
            //Add this Under Control_MouseUp Event
            dragging = false;
        }

        private void message_TextChanged(object sender, EventArgs e)
        {
            /*if (message.Text.Contains("[.n.]"))
            {
                if (message.Text.Length - 5 >= 69)
                {

                }
                else
                {
                    int lngh = message.Text.Length - 5;
                    int req_spaces = 69 - lngh;

                    string num_spaces = " ";
                    for (int a = 0; a < req_spaces; a++)
                    {
                        num_spaces = num_spaces + " ";
                    }
                    message.Text = message.Text.Replace("[.n.]", num_spaces);
                }
            }
            */

        }
    }
}
