using System.IO;

namespace XmlViewer.Models
{
    internal class FileModel
    {
        public FileInfo FilePath { get; set; }

        public string FileText { get; set; }

        public string FileName { get; set; }
        public string DisplayedText { get; set; }
    }
}
