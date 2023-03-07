using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using ProjectRon.Data;
using SixLabors.ImageSharp;
using SixLabors.ImageSharp.Formats.Png;
using ZXing.QrCode;

namespace ProjectRon.Pages.QRCodes
{
    public class CreateModel : PageModel
    {
        private readonly ProjectRon.Data.ApplicationDbContext _context;

        public CreateModel(ProjectRon.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public QRCode QRCode { get; set; } = default!;


        // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid || _context.QRCodes == null || QRCode == null)
            {
                return Page();
            }

            if (!string.IsNullOrEmpty(QRCode.Description))
            {
                try
                {
                    var writer = new ZXing.ImageSharp.BarcodeWriter<SixLabors.ImageSharp.PixelFormats.La32>()
                    {
                        Format = ZXing.BarcodeFormat.QR_CODE,
                        Options = new QrCodeEncodingOptions()
                        {
                            Height = 250,
                            Width = 250,
                            Margin = 0
                        }
                    };
                    var pixel = writer.Write(QRCode.Description);
                    var str = pixel.ToBase64String(PngFormat.Instance);

                    QRCode.Code = str;
                }
                catch (Exception ex)
                {
                    // TODO: do something useful
                    Console.WriteLine($"ERROR: {ex.Message}");
                }
            }

            _context.QRCodes.Add(QRCode);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
