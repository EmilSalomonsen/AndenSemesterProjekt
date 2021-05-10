using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace AndenSemesterProjekt.Pages.Users
{
    public class CreateUsersModel : PageModel
    {
        [BindProperty]
        public AndenSemesterProjekt.Users User { get; set; }

        public IActionResult OnGet()
        {
            return Page();
        }

        public IActionResult OnPost()
        {
            return Page();
        }

    }
}
