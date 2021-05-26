using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using AndenSemesterProjekt.Interfaces;
using Microsoft.AspNetCore.Routing;

namespace AndenSemesterProjekt.Pages.SelectRoute
{
    public class AttendantBookingsModel : PageModel
    {
        IRoutesRepository repo;
        [BindProperty]
        public Models.Route Route { get; set; }

        public AttendantBookingsModel(IRoutesRepository repository)
        {
            repo = repository;
        }
        public IActionResult OnGet(int id)
        {
            Route = repo.GetRoutes(id);
            //Routes = repo.GetAllRoutes().Where(r => r.RouteId == id).FirstOrDefault();
            return Page();
        }
        public IActionResult OnPost()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }
            repo.AddAttendantToRoute(Route);
            return RedirectToPage("/SelectRoute/SignedUp");
        }
    }
}