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
    public class EditRoutesModel : PageModel
    {
        IRoutesRepository repo;

        [BindProperty]
        public Models.Route Routes { get; set; }

        public EditRoutesModel(IRoutesRepository repository)
        {
            repo = repository;
        }


        public IActionResult OnGet(int id)
        {
            Routes = repo.GetRoutes(id);
            return Page();

        }

        public IActionResult OnPost(int id)
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }
            repo.EditRoutes(Routes);
            return RedirectToPage("Index");
        }
    }
}
