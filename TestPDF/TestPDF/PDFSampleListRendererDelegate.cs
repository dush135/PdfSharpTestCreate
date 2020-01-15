using PdfSharp.Xamarin.Forms.Delegates;
using PdfSharpCore.Drawing;
using PdfSharpCore.Fonts;
using System.Collections.Generic;
using System.Linq;
using Xamarin.Forms;

namespace TestPDF
{
    public class PDFSampleListRendererDelegate : PdfListViewRendererDelegate
    {
        public override void DrawCell(ListView listView, int section, int row, XGraphics page, XRect bounds, double scaleFactor)
        {
            XFont font = new XFont("times" ?? GlobalFontSettings.FontResolver.DefaultFontName, 15);
            var yourObject = (listView.ItemsSource as List<Customer>).ElementAt(row);

            page.DrawString(yourObject.Names, font, XBrushes.Black, bounds,
            new XStringFormat
            {
                LineAlignment = XLineAlignment.Center,
                Alignment = XStringAlignment.Center,
            });
        }

        public override void DrawFooter(ListView listView, int section, XGraphics page, XRect bounds, double scaleFactor)
        {
            base.DrawFooter(listView, section, page, bounds, scaleFactor);
        }

        public override double GetFooterHeight(ListView listView, int section)
        {
            return base.GetFooterHeight(listView, section);
        }
    }
}
