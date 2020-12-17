using Microsoft.Extensions.DependencyInjection;

namespace XmlViewer.ViewModels
{
    internal class ViewModelLocator
    {
        public MainWindowViewModel MainWindowVM => App.Services.GetRequiredService<MainWindowViewModel>();

        //public MainMenuViewModel MainMenuVM => App.Services.GetRequiredService<MainMenuViewModel>();
    }
}
