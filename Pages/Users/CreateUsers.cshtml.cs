using AndenSemesterProjekt.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using AndenSemesterProjekt.Models;

namespace AndenSemesterProjekt.Pages.Users
{
    public class CreateUsersModel : PageModel
    {
        IUserRepository repo;

        [BindProperty]
        public User _User { get; set; }

        public CreateUsersModel(IUserRepository repository)
        {
            repo = repository;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        public IActionResult OnPost()
        {
            if (!ModelState.IsValid)
            {
                return Page();

            }
            repo.AddUser(_User);
            return RedirectToPage("Index");
        }

    }
}
