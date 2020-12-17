using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;

namespace XmlViewer
{
    public partial class App
    {
        #region HOST

        private static IHost __host;

        public static IHost Host => __host ??= Program.CreateHostBuilder(Environment.GetCommandLineArgs()).Build();

        #endregion



        internal static void ConfigureServices(HostBuilderContext host, IServiceCollection services)
        {
        }
    }
}
