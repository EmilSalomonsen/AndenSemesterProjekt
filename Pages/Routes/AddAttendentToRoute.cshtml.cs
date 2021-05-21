using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using AndenSemesterProjekt.Models;
using AndenSemesterProjekt.Interfaces;

namespace AndenSemesterProjekt.Pages.Routes
{
    public class AddAttendentToRouteModel : PageModel
    {
        IRoutesRepository repo;
        IAttendantsRepository repoA;
        [BindProperty]
        public Attendant Attendant { get; set; }
        public Route Route { get; set; }

        public AddAttendentToRouteModel(IRoutesRepository repository, IAttendantsRepository repository1)
        {
            repo = repository;
            repoA = repository1;
        }
        public IActionResult OnGet(string AId, int RId)
        {
            Attendant = repoA.GetAttendant(AId);
            Route = repo.GetRoutes(RId);
            return Page();
        }
        public IActionResult OnPost()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }
            repo.AddAttendantToRoute(Attendant, Route);
            return RedirectToPage("Routes");
        }
    }
}
