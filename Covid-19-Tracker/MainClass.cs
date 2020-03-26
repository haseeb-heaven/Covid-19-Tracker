using System;
using System.Windows.Forms;

namespace Covid_19_Tracker
{
    static class MainClass
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new CovidForm());
        }
    }
}
