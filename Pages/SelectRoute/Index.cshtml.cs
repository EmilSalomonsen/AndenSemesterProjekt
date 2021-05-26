using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using AndenSemesterProjekt.Interfaces;
using AndenSemesterProjekt.Models;

namespace AndenSemesterProjekt.Pages.SelectRoute
{
    public class IndexModel : PageModel
    {

        public IRoutesRepository _repo;


        public IEnumerable<Route> Routes { get; set; }

        [BindProperty(SupportsGet = true)]
        public string FilterCriteria { get; set; }

        public IndexModel(IRoutesRepository repository)
        {
            _repo = repository;
        }
        public IActionResult OnGet()
        {
            Routes = _repo.GetAllRoutes();
            if (!string.IsNullOrEmpty(FilterCriteria))
            {
                Routes = _repo.FilterRoute(FilterCriteria);
            }
            return Page();
        }
    }
}
