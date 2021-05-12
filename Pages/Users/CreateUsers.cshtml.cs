using AndenSemesterProjekt.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using AndenSemesterProjekt.Models;
using Microsoft.Extensions.Logging;

namespace AndenSemesterProjekt.Pages.Users
{
    public class CreateUsersModel : PageModel
    {
        IUserRepository repo;

        [BindProperty] public Models.Users Users { get; set; }

        
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

            repo.AddUser(Users);
            return RedirectToPage("Index");
        }

    }

}