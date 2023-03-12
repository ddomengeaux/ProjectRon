using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics;
using System.IO.Compression;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using ProjectRon.Data;
using ZXing;
using ZXing.ImageSharp;

namespace ProjectRon.Pages.QRCodes
{
    public class ReaderModel : PageModel
    {
        private readonly ProjectRon.Data.ApplicationDbContext _context;

        public ReaderModel(ProjectRon.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> OnPostAsync(ICollection<IFormFile> files)
        {
            foreach (var formFile in files)
            {
                if (formFile.Length > 0)
                {
                    using (var stream = formFile.OpenReadStream())
                    {
                        try
                        {
                            using (var image = await SixLabors.ImageSharp.Image.LoadAsync<SixLabors.ImageSharp.PixelFormats.Rgba32>(stream))
                            {
                                var reader = new ZXing.ImageSharp.BarcodeReader<SixLabors.ImageSharp.PixelFormats.Rgba32>();
                                var result = reader.Decode(image);
                                ViewData["TextAreaResult"] = result?.Text;
                            }
                        }
                        catch (Exception exc)
                        {
                            Debug.WriteLine(exc.Message);
                        }
                    }
                }
            }

            return Page();
        }
    }
}
