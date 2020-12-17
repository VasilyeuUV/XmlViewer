using Microsoft.Extensions.DependencyInjection;
using XmlViewer.Services.Dialogs;

namespace XmlViewer.Services
{
    internal static class ServicesRegistrator
    {
        public static IServiceCollection AddServices(this IServiceCollection services) => services
            .AddTransient<IUserDialog, UserDialogService>()
            ;
    }
}
