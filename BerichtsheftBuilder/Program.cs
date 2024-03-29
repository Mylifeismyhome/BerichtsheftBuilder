using BerichtsheftBuilder.Forms;
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
            serviceCollection.AddSingleton<ProfileStorage>();
            serviceProvider = serviceCollection.BuildServiceProvider();
        }

        private static void routine()
        {
            System.Windows.Forms.Form startupForm = null;

            ProfileStorage profileStorage = ServiceProvider.GetService<ProfileStorage>();
            if (!profileStorage.Read())
            {
                startupForm = new Profile();
            }
            else
            {
                startupForm = profileStorage.Created ? new MainForm() : new Profile();
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
