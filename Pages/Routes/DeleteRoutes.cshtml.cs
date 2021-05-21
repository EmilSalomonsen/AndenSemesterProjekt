using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AndenSemesterProjekt.Interfaces;
using AndenSemesterProjekt.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Routing;

namespace AndenSemesterProjekt.Pages.Routes
{
    public class DeleteRoutesModel : PageModel
    {
        IRoutesRepository repo;

        [BindProperty]
        public Models.Route Route { get; set;}

        public DeleteRoutesModel(IRoutesRepository repository)
        {
            repo = repository;
        }

        public IActionResult OnGet(int ID)
        {
            Route = repo.GetRoutes(ID);
            return Page();
        }
        public IActionResult OnPost()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }
            repo.DeleteRoute(Route);
            return RedirectToPage("routes");
        }

    }
}
