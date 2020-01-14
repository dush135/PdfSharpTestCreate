using Foundation;
using QuickLook;

namespace TestPDF.iOS
{
    public sealed class FilePreviewItem : QLPreviewItem
    {

        string title;
        NSUrl targetUrl;

        public override string ItemTitle
        {
            get
            {
                return title;
            }
        }

        public override NSUrl ItemUrl
        {
            get
            {
                return targetUrl;
            }
        }

        public FilePreviewItem(string title, NSUrl targetUrl)
        {
            this.targetUrl = targetUrl;
            this.title = title;
        }

    }
}