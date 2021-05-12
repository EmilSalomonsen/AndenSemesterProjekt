using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AndenSemesterProjekt.Models;
using AndenSemesterProjekt.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;

namespace AndenSemesterProjekt
{
    public class DeleteRoutesModel : PageModel
    {

        [BindProperty]
        public Routes Routes { get; set; }

        IRoutesService routesService;

        public DeleteRoutesModel(IRoutesRepository service)
        {
            routesService = service;
        }

        public IActionResult OnGet(int ID)
        {
            Routes = Routes.GetRoutes(ID);
            return Routes();
        }
        public IActionResult OnPost(int ID)
        {
            if (Routes != null)
            {
                routesService.DeleteRoutes(ID);
            }
            return RedirectToPage("routes");
        }

    }
}