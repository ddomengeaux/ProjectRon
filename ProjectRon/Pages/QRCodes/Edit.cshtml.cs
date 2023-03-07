using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using ProjectRon.Data;

namespace ProjectRon.Pages.QRCodes
{
    public class EditModel : PageModel
    {
        private readonly ProjectRon.Data.ApplicationDbContext _context;

        public EditModel(ProjectRon.Data.ApplicationDbContext context)
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

            var qrcode =  await _context.QRCodes.FirstOrDefaultAsync(m => m.ID == id);
            if (qrcode == null)
            {
                return NotFound();
            }
            QRCode = qrcode;
            return Page();
        }

        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Attach(QRCode).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!QRCodeExists(QRCode.ID))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return RedirectToPage("./Index");
        }

        private bool QRCodeExists(int id)
        {
          return (_context.QRCodes?.Any(e => e.ID == id)).GetValueOrDefault();
        }
    }
}
