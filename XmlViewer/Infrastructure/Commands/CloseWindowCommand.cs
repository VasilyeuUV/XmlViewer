using System.Windows;
using XmlViewer.Infrastructure.Commands.Base;

namespace XmlViewer.Infrastructure.Commands
{
    internal class CloseWindowCommand : CommandBase
    {
        protected override bool CanExecute(object parameter) =>
            (parameter as Window ?? App.FocusedWindow ?? App.ActivedWindow) != null;

        protected override void Execute(object parameter) => (
            parameter as Window
            ?? App.FocusedWindow
            ?? App.ActivedWindow
            )?.Close();
    }
}
