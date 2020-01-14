using TestPDF.Droid;
using PdfSharpCore.Pdf;

[assembly: Xamarin.Forms.Dependency(typeof(PdfSave))]
namespace TestPDF.Droid
{
    public class PdfSave : IPdfSave
    {
        public void Save(PdfDocument doc, string filePath)
        {

            doc.Save(filePath);
            doc.Close();

        }
    }
}