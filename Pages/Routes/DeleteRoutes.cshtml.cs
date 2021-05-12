using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AndenSemesterProjekt.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;

namespace AndenSemesterProjekt.Pages.Routes
{
    public class DeleteRoutesModel : PageModel
    {

        [BindProperty]
        public Models.Routes Routes { get; set;}

        IRoutesService routesService;

        public DeleteRoutesModel(IRoutesRepository service)
        {
            RouteService = service;
        }

        public IActionResult OnGet(int ID)
        {
            Route = Routes.getRoute(ID);
            return Route();
        }
        public IActionResult OnPost(int ID)
        {
            if (Routes != null)
            {
                routesService.DeleteRoute(ID);
            }
            return RedirectToPage("routes");
        }

    }
}
