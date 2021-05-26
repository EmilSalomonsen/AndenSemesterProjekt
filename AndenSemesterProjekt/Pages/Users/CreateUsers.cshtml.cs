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
        public Models.User User { get; set; }

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
            repo.AddUser(User);
            return RedirectToPage("Index");
        }

    }
}
