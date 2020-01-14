using PdfSharpCore.Pdf;

namespace TestPDF
{
    public interface IPdfSave
    {
        void Save(PdfDocument doc, string fileName);
    }
}
