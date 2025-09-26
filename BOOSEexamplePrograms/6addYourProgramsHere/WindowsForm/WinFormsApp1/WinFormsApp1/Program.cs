namespace WinFormsApp1;
using System.Diagnostics;
using BOOSE;

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
            Application.Run(new Form1());
            string about = AboutBOOSE.about();
            Debug.WriteLine(about);
        }
    }
