using BerichtsheftBuilder.Forms;
using BerichtsheftBuilder.service;
using BerichtsheftBuilder.Service;
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
            serviceCollection.AddSingleton<SFTPService>();
            serviceCollection.AddSingleton<PDFService>();
            serviceCollection.AddSingleton<DialogCenteringService>();
            serviceCollection.AddSingleton<CultureInfoService>();
            serviceProvider = serviceCollection.BuildServiceProvider();
        }

        private static void run()
        {
            Form form;

            ProfileService profileService = ServiceProvider.GetService<ProfileService>();
            if (!profileService.read())
            {
                form = new Profile();
            }
            else
            {
                form = new MainForm();
            }

            Application.EnableVisualStyles();
            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.Run(form);
        }

        [STAThread]
        static void Main()
        {
            license();
            cdi();
            run();
        }
    }
}