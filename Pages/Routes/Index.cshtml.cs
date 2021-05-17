using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AndenSemesterProjekt.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace AndenSemesterProjekt.Pages.Routes
{
    public class IndexModel : PageModel
    {
        private readonly IRoutesRepository _repo;
        public IEnumerable<Models.Route> Routes { get; set; }
        public IndexModel (IRoutesRepository repo)
        {
            _repo = repo;
        }
        public void OnGet()
        {
            Routes = _repo.GetAllRoutes();
        }
    }
}
