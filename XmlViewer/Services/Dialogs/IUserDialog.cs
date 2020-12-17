using System;
using System.Collections.Generic;
using System.Text;

namespace XmlViewer.Services.Dialogs
{
    internal interface IUserDialog
    {

        #region OPEN FILE
        private const string FILTER = "Файлы XML (*.xml)|*.xml";

        bool OpenFile(string title, out string selectedFile, string filter = FILTER);

        bool OpenFiles(string title, out IEnumerable<string> selectedFiles, string filter = FILTER); 

        #endregion
    }
}
