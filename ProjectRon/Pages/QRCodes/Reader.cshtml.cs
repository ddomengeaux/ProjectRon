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
    public class ReaderModel : PageModel
    {
        private readonly ProjectRon.Data.ApplicationDbContext _context;

        public ReaderModel(ProjectRon.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> OnPostAsync()
        {

            return Page();
        }
    }
}
