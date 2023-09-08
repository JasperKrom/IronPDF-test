using IronPdf.Editing;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestConsole.PDF
{
    public class IronPDFEngine
    {
        public void StampPDF()
        {
            var htmlStamper = File.ReadAllText("../../../../test74480.html");

            var stamper =
            new HtmlStamper(htmlStamper)
            {
                HorizontalAlignment = HorizontalAlignment.Left,
                VerticalAlignment = VerticalAlignment.Top,
                IsStampBehindContent = false,
                Opacity = 100,
                VerticalOffset = new Length(25),
                HorizontalOffset = new Length(25),
                Scale = 75,
            };

            var pdf = PdfDocument.FromFile("../../../../Hey.pdf");

            pdf.ApplyStamp(stamper);

            pdf.SaveAs("../../../../stampedimageBasic.pdf");
        }
    
        public void LockPDF()
        {
            var pdf = PdfDocument.FromFile("../../../../TestWithForm.pdf");

            pdf.SecuritySettings.OwnerPassword = "password";
            pdf.SecuritySettings.MakePdfDocumentReadOnly("password");

            pdf.SaveAs("../../../../formlocked.pdf");
        }
    }
}
