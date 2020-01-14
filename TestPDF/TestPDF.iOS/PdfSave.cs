using PdfSharpCore.Pdf;
using TestPDF.iOS;

[assembly: Xamarin.Forms.Dependency(typeof(PdfSave))]
namespace TestPDF.iOS
{
    public class PdfSave : IPdfSave
    {
        public void Save(PdfDocument doc, string fileName)
        {

            doc.Save(fileName);
            doc.Close();

        }
    }
}