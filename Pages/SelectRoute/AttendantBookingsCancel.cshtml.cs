using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AndenSemesterProjekt.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace AndenSemesterProjekt.Pages.SelectRoute
{
    public class AttendantsBookingsCancelModel : PageModel
    {
        IRoutesRepository repo;
        [BindProperty]
        public Models.Route Route { get; set; }

        public AttendantsBookingsCancelModel(IRoutesRepository repository)
        {
            repo = repository;
        }
        public IActionResult OnGet(int id)
        {
            Route = repo.GetRoutes(id);
            //Routes = repo.GetAllRoutes().Where(r => r.RouteId == id).FirstOrDefault();
            return Page();
        }

        public IActionResult OnPost(int id)
        {
            if (id!=null)
            {
               repo.RemoveAttendantFromRoute(Route, Route.AttendantId);
            }
            
            return RedirectToPage("/SelectRoute/CancelSignUp");
        }

    }
}
