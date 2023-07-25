
using KL.CatAPI;
using Microsoft.Extensions.Configuration;

namespace CatAppUI
{
    internal class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            var config = new ConfigurationBuilder().AddUserSecrets<Program>().Build();
            var apiKey = config["catapikey"];

            if (apiKey == null)
            {
                MessageBox.Show("You don't have an API key set up. Right click on CatAppUI project in VS, then > [Manage User Secrets] > and add a key value pair to \"catapikey\" for your api key.");
                return;
            }

            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Application.Run(new MainForm(new CatAPIService(apiKey)));
        }
    }
}