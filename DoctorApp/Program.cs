using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DoctorApp
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            try
            {
                Application.Run(new DoctorMainForm());
            }
            catch (ObjectDisposedException exception)
            {
            }
            catch (InvalidOperationException exception)
            {
            }
            catch (System.Data.NoNullAllowedException exception)
            {
                MessageBox.Show(exception.Message);
            }
        }
    }
}
