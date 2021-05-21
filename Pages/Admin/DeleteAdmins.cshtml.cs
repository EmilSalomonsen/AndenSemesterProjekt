using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AndenSemesterProjekt.Interfaces;
using AndenSemesterProjekt.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Routing;

namespace AndenSemesterProjekt.Pages.Admin
{
    public class DeleteAdminsModel : PageModel
    {
        IAdminsRepository repo;

        [BindProperty]
        public Models.Admin Admin { get; set; }

        public DeleteAdminsModel(IAdminsRepository repository)
        {
            repo = repository;
        }

        public IActionResult OnGet(int ID)
        {
            Admin = repo.GetAdmin(ID);
            return Page();
        }
        public IActionResult OnPost()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }
            repo.DeleteAdmin(Admin);
            return RedirectToPage("routes");
        }
    }
}
