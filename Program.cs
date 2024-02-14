using RecipeDatabase.Pages;

namespace RecipeDatabase
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
            Prog(); // Start the application
            
        }

        static void Prog()
        {
            LandingPage landingPage = new();
            DialogResult result = landingPage.ShowDialog(); // Show the landing page
            if (result == DialogResult.OK) // If the user logs in
            {
                HomePage home = new(); // Show the main form
                result = home.ShowDialog();
            }
            else
            {
                Application.Exit(); // Close the application
            }
            if (result == DialogResult.Retry) Prog(); // Restart the application
            //Application.Run(new LandingPage());
        }
    }
}