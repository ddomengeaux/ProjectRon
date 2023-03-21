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

public class TaskEntryModel : PageModel
{
    private readonly ProjectRon.Data.ApplicationDbContext _context;

    public TaskEntryModel(ProjectRon.Data.ApplicationDbContext context)
    {
        _context = context;
    }

    public void OnPost(string code)
    {

    }
}
