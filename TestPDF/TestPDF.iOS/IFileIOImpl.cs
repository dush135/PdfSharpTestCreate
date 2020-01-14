using System;
using TestPDF.iOS;

[assembly: Xamarin.Forms.Dependency(typeof(IFileIOImpl))]
namespace TestPDF.iOS
{
    public class IFileIOImpl : IFileIO
    {
        public IFileIOImpl()
        {
        }

        public System.IO.Stream CreateFile(string path)
        {
            return System.IO.File.Create(path);
        }

        public string GetMyDocumentsPath()
        {
            return Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
        }

    }
}