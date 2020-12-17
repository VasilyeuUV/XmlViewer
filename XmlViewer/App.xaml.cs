using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;
using System.Data;
using System.Linq;
using System.Windows;
using XmlViewer.Services;
using XmlViewer.ViewModels;

namespace XmlViewer
{
    public partial class App
    {
        #region Active Window 

        /// <summary> Окно в фокусе </summary>
        public static Window FocusedWindow => Current.Windows.Cast<Window>().FirstOrDefault(w => w.IsFocused);

        /// <summary> Активное Окно </summary>
        public static Window ActivedWindow => Current.Windows.Cast<Window>().FirstOrDefault(w => w.IsActive);

        #endregion

        #region HOST

        private static IHost __host;

        public static IHost Host => __host ??= Program.CreateHostBuilder(Environment.GetCommandLineArgs()).Build();

        #endregion

        /// <summary>
        /// Для обращения к сервисам
        /// </summary>
        public static IServiceProvider Services => Host.Services;


        /// <summary>
        /// Регистрирация сервисов и ViewModels
        /// </summary>
        /// <param name="host"></param>
        /// <param name="services"></param>
        internal static void ConfigureServices(HostBuilderContext host, IServiceCollection services) => services
            .AddServices()
            .AddViewModels();


        #region START/STOP HOST

        protected override async void OnStartup(StartupEventArgs e)
        {
            var host = Host;
            base.OnStartup(e);

            await host.StartAsync();
        }

        protected override async void OnExit(ExitEventArgs e)
        {
            base.OnExit(e);
            using (Host) await Host.StopAsync();
        } 

        #endregion

    }
}
