using KL.CatAPI;
using Microsoft.Extensions.Configuration;

namespace CatAppUI
{
    internal class Program
    {
        private const string NO_KEY_MESSAGE = 
            "You don't have an API key set up. " + 
            "Right click on CatAppUI project in VS, " +
            "then > [Manage User Secrets] > and add " +
            "a key value pair to \"catapikey\" for your api key.";

        [STAThread]
        static void Main()
        {
            var config = new ConfigurationBuilder().AddUserSecrets<Program>().Build();
            var apiKey = config["catapikey"];

            if (apiKey == null)
            {
                MessageBox.Show(NO_KEY_MESSAGE);
                return;
            }

            ApplicationConfiguration.Initialize();
            Application.Run(new MainForm(new CatAPIService(apiKey)));
        }
    }
}