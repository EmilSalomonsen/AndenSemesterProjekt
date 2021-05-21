using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AndenSemesterProjekt.Interfaces;
using AndenSemesterProjekt.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace AndenSemesterProjekt.Pages.Attendants
{
    public class DeleteAttendantsModel : PageModel
    {
        IAttendantsRepository repo;

        [BindProperty]
        public Models.Attendant Attendant { get; set; }

        public DeleteAttendantsModel(IAttendantsRepository repository)
        {
            repo = repository;
        }

        public IActionResult OnGet(string ID)
        {
            Attendant = repo.GetAttendant(ID);
            return Page();
        }
        public IActionResult OnPost()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }
            repo.DeleteAttendant(Attendant);
            return RedirectToPage("Attendant");
        }
    }
}
