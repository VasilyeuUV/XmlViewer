using Microsoft.Win32;
using System.Collections.Generic;
using System.Linq;

namespace XmlViewer.Services.Dialogs
{
    internal class UserDialogService : IUserDialog
    {

        /// <summary>
        /// Открыть файл
        /// </summary>
        /// <param name="title"></param>
        /// <param name="selectedFile"></param>
        /// <param name="filter"></param>
        /// <returns></returns>
        public bool OpenFile(string title, out string selectedFile, string filter = "Файлы XML (*.xml)|*.xml")
        {
            var fileDialog = new OpenFileDialog()
            {
                Title = title,
                Filter = filter
            };

            if (fileDialog.ShowDialog() == true)
            {
                selectedFile = fileDialog.FileName;
                return true;
            }
            selectedFile = null;
            return false;
        }

        /// <summary>
        /// Открыть несколько файлов
        /// </summary>
        /// <param name="title"></param>
        /// <param name="selectedFiles"></param>
        /// <param name="filter"></param>
        /// <returns></returns>
        public bool OpenFiles(string title, out IEnumerable<string> selectedFiles, string filter = "Файлы XML (*.xml)|*.xml")
        {
            var fileDialog = new OpenFileDialog()
            {
                Title = title,
                Filter = filter
            };

            if (fileDialog.ShowDialog() == true)
            {
                selectedFiles = fileDialog.FileNames;
                return true;
            }
            selectedFiles = Enumerable.Empty<string>();
            return false;
        }
    }
}
