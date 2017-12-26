using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinTour
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            DateTime frm = new DateTime(2017, 12, 26);
            DateTime to = new DateTime(2017, 12, 30);
            new BusTour().Thongkedoanhthu(frm, to);
            //Application.Run(new Form1());
            
        }
    }
}
