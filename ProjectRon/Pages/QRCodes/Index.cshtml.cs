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
    public class IndexModel : PageModel
    {
        private readonly ProjectRon.Data.ApplicationDbContext _context;

        public IndexModel(ProjectRon.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        public IList<QRCode> QRCode { get;set; } = default!;

        public async Task OnGetAsync()
        {
            if (_context.QRCodes != null)
            {
                QRCode = await _context.QRCodes.ToListAsync();
            }
        }
    }
}
