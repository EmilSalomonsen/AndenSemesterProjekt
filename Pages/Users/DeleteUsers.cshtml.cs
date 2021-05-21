using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AndenSemesterProjekt.Interfaces;
using AndenSemesterProjekt.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Routing;

namespace AndenSemesterProjekt.Pages.Users
{
    public class DeleteUsersModel : PageModel
    {
        IUserRepository repo;

        [BindProperty]
        public User _User { get; set; }

        public DeleteUsersModel(IUserRepository repository)
        {
            repo = repository;
        }

        public IActionResult OnGet(int ID)
        {
            _User = repo.GetUser(ID);
            return Page();
        }
        public IActionResult OnPost()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }
            repo.RemoveUser(_User);
            return RedirectToPage("routes");
        }
    }
}
