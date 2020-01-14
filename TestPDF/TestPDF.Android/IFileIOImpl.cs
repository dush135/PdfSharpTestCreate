using TestPDF.Droid;

[assembly: Xamarin.Forms.Dependency(typeof(IFileIOImpl))]
namespace TestPDF.Droid
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
            return Android.OS.Environment.GetExternalStoragePublicDirectory(Android.OS.Environment.DirectoryDocuments).AbsolutePath;
        }

    }
}