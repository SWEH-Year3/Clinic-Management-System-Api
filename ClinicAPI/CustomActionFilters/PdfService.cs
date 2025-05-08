using PdfSharpCore.Drawing;
using PdfSharpCore.Pdf;

namespace ClinicAPI.CustomActionFilters
{
    public class PdfService
    {
        public byte[] GeneratePrescriptionPdf(string description)
        {
            using var document = new PdfDocument();
            var page = document.AddPage();
            var gfx = XGraphics.FromPdfPage(page);
            var font = new XFont("Verdana", 14, XFontStyle.Regular);

            gfx.DrawString("Prescription", font, XBrushes.Black, new XRect(0, 0, page.Width, 50), XStringFormats.Center);
            gfx.DrawString(description, new XFont("Verdana", 12), XBrushes.Black, new XRect(40, 60, page.Width - 80, page.Height - 100), XStringFormats.TopLeft);

            using var stream = new MemoryStream();
            document.Save(stream);
            return stream.ToArray();
        }
    }
}
