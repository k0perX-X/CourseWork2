using System.Diagnostics;
using Microsoft.EntityFrameworkCore.Infrastructure;

namespace NewPatientApp
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            try
            {
                Application.Run(new MainForm());
            }
            catch (ObjectDisposedException exception)
            {
            }
            catch (InvalidOperationException exception)
            {
            }
        }
    }
}