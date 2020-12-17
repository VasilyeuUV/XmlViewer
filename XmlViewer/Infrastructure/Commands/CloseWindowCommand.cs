using System.Windows;
using XmlViewer.Infrastructure.Commands.Base;

namespace XmlViewer.Infrastructure.Commands
{
    internal class CloseWindowCommand : CommandBase
    {


        #region CommandBase

        protected override void Execute(object parameter) => (
            parameter as Window
            ?? App.FocusedWindow
            ?? App.ActivedWindow
            )?.Close();


        #endregion
    }
}
