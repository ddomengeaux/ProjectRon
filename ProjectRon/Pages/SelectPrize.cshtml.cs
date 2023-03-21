using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using ProjectRon.Data;


namespace ProjectRon.Pages;

public class SelectPrizeModel : PageModel
{
    public string Prizes
    {
        get
        {
            var a = _context.Prizes.Select(x => $"{{ 'fillStyle': '{_colors[new Random().Next(0, _colors.Count - 1)]}', 'text': '{x.Description}' }}");
            return string.Join(",", a);
        }
    }
    public int PrizeCount => _context.Prizes.Count();
    public int Prize { get; set; }
    public SelectListItem SelectedPrize { get; set; }

    public List<SelectListItem> Options
    {
        get
        {
            return _context.Prizes.Select(x => new SelectListItem()
            {
                Text = x.Description,
                Value = x.ID.ToString()
            }).ToList();
        }
    }

    private readonly List<string> _colors = new List<string>()
    {
        "#eae56f",
        "#89f26e",
        "#7de6ef",
        "#e7706f"
    };

    private readonly ProjectRon.Data.ApplicationDbContext _context;

    public SelectPrizeModel(ProjectRon.Data.ApplicationDbContext context)
    {
        _context = context;
    }

    public void OnGet()
    {
        Prize = 1; // set this to index of item in Prizes you want it to stop on
    }

    public void OnPost(string SelectedPrize)
    {
        _context.SelectedPrizes.Add(new Data.SelectedPrize()
        {
            Name = _context.Prizes.FirstOrDefault(x => x.ID == int.Parse(SelectedPrize)).Description,
            User = User.FindFirstValue(ClaimTypes.Email)
        });
        // if you don't call savechanges nothing will be commited to the db 
        _context.SaveChanges();
    }
}
