using System;
using System.Collections.Generic;
using System.Text;

namespace TestPDF
{
    public interface IPDFPreviewProvider
    {
        void TriggerPreview(string path);
    }
}
