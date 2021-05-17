using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AndenSemesterProjekt.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Routing;

namespace AndenSemesterProjekt.Pages.Routes
{
    public class DeleteRoutesModel : PageModel
    {
        IRoutesRepository repo;

        [BindProperty]
        public Route Routes { get; set;}

        public DeleteRoutesModel(IRoutesRepository repository)
        {
            repo = repository;
        }

        public IActionResult OnGet(int ID)
        {
            Routes = repo.GetRoutes(ID);
            return Page();
        }
        public IActionResult OnPost(int id)
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }
            repo.DeleteRoute(Routes);
            return RedirectToPage("routes");
        }

    }
}
