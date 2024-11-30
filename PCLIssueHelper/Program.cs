using System.Text.Json;

namespace PCLIssueHelper
{
    public static class Program
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
            Application.Run(new FormMain());
        }
    }
    public class Issues
    {
        public long id { get; set; }
        public long number { get; set; }
        public string title { get; set; } = null!;
        public string body { get; set; } = string.Empty;
    }
}