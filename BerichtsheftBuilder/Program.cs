using BerichtsheftBuilder.Forms;
using BerichtsheftBuilder.service;
using Microsoft.Extensions.DependencyInjection;
using QuestPDF.Infrastructure;
using System;
using System.Windows.Forms;

namespace BerichtsheftBuilder
{
    internal static class Program
    {
        private static ServiceCollection serviceCollection;
        public static ServiceCollection ServiceCollection
        {
            get => serviceCollection;
            set => serviceCollection = value;
        }

        private static ServiceProvider serviceProvider;
        public static ServiceProvider ServiceProvider
        {
            get => serviceProvider;
            set => serviceProvider = value;
        }

        private static void license()
        {
            QuestPDF.Settings.License = LicenseType.Community;
        }

        private static void cdi()
        {
            serviceCollection = new ServiceCollection();
            serviceCollection.AddSingleton<ProfileService>();
            serviceProvider = serviceCollection.BuildServiceProvider();
        }

        private static void routine()
        {
            System.Windows.Forms.Form startupForm = null;

            ProfileService profileService = ServiceProvider.GetService<ProfileService>();
            if (!profileService.Read())
            {
                startupForm = new Profile();
            }
            else
            {
                startupForm = new MainForm();
            }

            Application.EnableVisualStyles();
            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.Run(startupForm);
        }

        [STAThread]
        static void Main()
        {
            license();
            cdi();
            routine();
        }
    }
}
