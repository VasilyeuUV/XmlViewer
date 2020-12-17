using XmlViewer.ViewModels.Base;

namespace XmlViewer.ViewModels
{
    internal class MainWindowViewModel : ViewModelBase
    {
        #region TITLE

        /// <summary> Заголовок окна </summary>
        private string _title = "Xml Viewver";

        /// <summary> Заголовок окна </summary>
        public string Title { get => _title; set => Set(ref _title, value); }

        #endregion


    }
}
