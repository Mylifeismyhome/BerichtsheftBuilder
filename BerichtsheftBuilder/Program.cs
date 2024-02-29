using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
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

        [STAThread]
        static void Main()
        {
            serviceCollection = new ServiceCollection();

            serviceCollection.AddSingleton<ProfileStorage>();

            serviceProvider = serviceCollection.BuildServiceProvider();

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainForm());
        }
    }
}
