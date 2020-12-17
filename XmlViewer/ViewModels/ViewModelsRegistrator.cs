using Microsoft.Extensions.DependencyInjection;

namespace XmlViewer.ViewModels
{
    internal static class ViewModelsRegistrator
    {
        public static IServiceCollection AddViewModels(this IServiceCollection viewModels) => viewModels
            .AddSingleton<MainWindowViewModel>()
            ;
    }
}
