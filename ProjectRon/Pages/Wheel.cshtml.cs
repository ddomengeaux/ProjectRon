﻿using System;
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

public class WheelModel : PageModel
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

    private readonly List<string> _colors = new List<string>()
    {
        "#eae56f",
        "#89f26e",
        "#7de6ef",
        "#e7706f"
    };

    private readonly ProjectRon.Data.ApplicationDbContext _context;

    public WheelModel(ProjectRon.Data.ApplicationDbContext context)
    {
        _context = context;
    }

    public void OnGet()
    {
        Prize = 1; // set this to index of item in Prizes you want it to stop on
    }
}
