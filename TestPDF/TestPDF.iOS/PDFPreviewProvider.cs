using TestPDF.iOS;
using QuickLook;
using UIKit;
using Xamarin.Forms;

[assembly: Dependency(typeof(PDFPreviewProvider))]
namespace TestPDF.iOS
{
    public class PDFPreviewProvider : IPDFPreviewProvider
    {
        public PDFPreviewProvider()
        {
        }

        public void TriggerPreview(string path)
        {
            QLPreviewController previewController = new QLPreviewController();
            previewController.DataSource = new MyPreviewDataSource(path);

            UIApplication.SharedApplication.KeyWindow.RootViewController.PresentViewController(previewController, true, null);
        }

    }
}