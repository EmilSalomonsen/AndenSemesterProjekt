using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using AndenSemesterProjekt.Models.Users;

namespace AndenSemesterProjekt.Pages.Users
{
    public class CreateUsersModel : PageModel
    {
        [BindProperty]

        public AndenSemesterProjekt.Users User;
        
        public IActionResult OnGet()
        {
            return Page();
        }

        public IActionResult OnPost()
        {

        }

    }
}
