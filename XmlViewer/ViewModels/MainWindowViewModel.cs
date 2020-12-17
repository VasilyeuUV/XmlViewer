using System.IO;
using System.Windows;
using System.Windows.Input;
using XmlViewer.Infrastructure.Commands.Base;
using XmlViewer.Services.Dialogs;
using XmlViewer.ViewModels.Base;

namespace XmlViewer.ViewModels
{
    internal class MainWindowViewModel : ViewModelBase
    {
        private readonly IUserDialog _userDialog;

        #region TITLE

        ///// <summary> Заголовок окна </summary>
        //private string _title = "Xml Viewer";

        ///// <summary> Заголовок окна </summary>
        //public string Title { get => _title; set => Set(ref _title, value); }

        #endregion

        //#region MAIN MENU

        //private MainMenuViewModel _mainMenuViewModel = null;
        //public MainMenuViewModel MainMenuViewModel => _mainMenuViewModel ??= new MainMenuViewModel();

        //#endregion

        /// <summary>
        /// CTOR
        /// </summary>
        public MainWindowViewModel(IUserDialog userDialog)
        {
            this._userDialog = userDialog;
        }

        #region SELECTED FILE

        private FileInfo _selectedFile = null;
        /// <summary>
        /// Выбранный файл
        /// </summary>
        public FileInfo SelectedFile { get => _selectedFile; set => Set(ref _selectedFile, value); }

        #endregion



        #region COMMANDS

        #region OpenFileCommand

        private ICommand _openFileCommand;      

        public ICommand OpenFileCommand => _openFileCommand ??= new LambdaCommand(OnOpenFileCommandExecuted);

        private void OnOpenFileCommandExecuted()
        {
            if (!_userDialog.OpenFile((string)Application.Current.Resources["Dialog_OpenFile_Title"], out var filePath))
            {
                SelectedFile = new FileInfo(filePath);
            }
        } 
        #endregion


        #endregion



    }
}
