using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using ProjectRon.Data;

namespace ProjectRon.Pages.QRCodes
{
    public class DeleteModel : PageModel
    {
        private readonly ProjectRon.Data.ApplicationDbContext _context;

        public DeleteModel(ProjectRon.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        [BindProperty]
      public QRCode QRCode { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null || _context.QRCodes == null)
            {
                return NotFound();
            }

            var qrcode = await _context.QRCodes.FirstOrDefaultAsync(m => m.ID == id);

            if (qrcode == null)
            {
                return NotFound();
            }
            else 
            {
                QRCode = qrcode;
            }
            return Page();
        }

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null || _context.QRCodes == null)
            {
                return NotFound();
            }
            var qrcode = await _context.QRCodes.FindAsync(id);

            if (qrcode != null)
            {
                QRCode = qrcode;
                _context.QRCodes.Remove(QRCode);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
