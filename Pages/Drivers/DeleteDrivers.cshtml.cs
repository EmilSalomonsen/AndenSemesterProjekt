using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AndenSemesterProjekt.Interfaces;
using AndenSemesterProjekt.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Routing;

namespace AndenSemesterProjekt.Pages.Drivers
{
    public class DeleteDriversModel : PageModel
    {
        IDriversRepository repo;

        [BindProperty]
        public Driver Driver { get; set; }

        public DeleteDriversModel(IDriversRepository repository)
        {
            repo = repository;
        }

        public IActionResult OnGet(string ID)
        {
            Driver = repo.GetDriver(ID);
            return Page();
        }
        public IActionResult OnPost()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }
            repo.DeleteDriver(Driver);
            return RedirectToPage("Attendant");
        }
    }
}
