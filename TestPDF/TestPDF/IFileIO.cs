using System.IO;

namespace TestPDF
{
    public interface IFileIO
    {
        Stream CreateFile(string path);
        string GetMyDocumentsPath();
    }
}
