using Microsoft.Extensions.DependencyInjection;

namespace XmlViewer.ViewModels
{
    internal class ViewModelLocator
    {
        public MainWindowViewModel MainWindowVM => App.Services.GetRequiredService<MainWindowViewModel>();
    }
}
