using System;
using System.IO;
using Foundation;
using QuickLook;

namespace TestPDF.iOS
{
    class MyPreviewDataSource : QLPreviewControllerDataSource
    {
        FilePreviewItem targetItem;

        public MyPreviewDataSource(string filePath)
        {
            if (string.IsNullOrEmpty(filePath))
            {
                throw new ArgumentException("Target path can't be null or empty");
            }

            targetItem = new FilePreviewItem(Path.GetFileName(filePath), NSUrl.FromFilename(filePath));
        }

        public override nint PreviewItemCount(QLPreviewController controller)
        {
            return 1;
        }

        public override IQLPreviewItem GetPreviewItem(QLPreviewController controller, nint index)
        {
            return targetItem;
        }
    }
}