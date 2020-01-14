using PdfSharp.Xamarin.Forms;
using System.Collections.Generic;
using System.IO;
using Xamarin.Forms;

namespace TestPDF
{
    public partial class MainPage : ContentPage
    {

        private List<Customer> Cus = new List<Customer>();

        public MainPage()
        {
            InitializeComponent();

            Customer ss1 = new Customer { Names = "test1", Ages = "10"};
            Customer ss2 = new Customer { Names = "test2", Ages = "30" };
            Cus.Add(ss1);
            Cus.Add(ss2);

            rListView.ItemsSource = Cus;

        }

        private void Button_Clicked(object sender, System.EventArgs e)
        {
            var pdf = PDFManager.GeneratePDFFromView(mainGrid);
            var fileManager = DependencyService.Get<IFileIO>();
            string filePath = Path.Combine(fileManager.GetMyDocumentsPath(), "testpdf.pdf");
            DependencyService.Get<IPdfSave>().Save(pdf, filePath);
            DependencyService.Get<IPDFPreviewProvider>().TriggerPreview(filePath);
        }
    }
}
