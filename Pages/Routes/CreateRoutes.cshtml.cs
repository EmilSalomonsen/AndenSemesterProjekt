using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AndenSemesterProjekt.Interfaces;
using AndenSemesterProjekt.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace AndenSemesterProjekt.Pages.Routes
{
    public class CreateRoutesModel : PageModel
    {
        IRoutesRepository repo;

        [BindProperty]
        public Route Route { get; set; }

        public CreateRoutesModel(IRoutesRepository repository)
        {
            repo = repository;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        public IActionResult OnPost()
        {
            //if (!ModelState.IsValid)
            //{
            //    return Page();
            //}
            repo.AddRoute(Route);
            return RedirectToPage("Index");
        }

     
    }
}
