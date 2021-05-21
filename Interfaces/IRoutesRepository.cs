using AndenSemesterProjekt.Models;
using AndenSemesterProjekt.Pages.Routes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AndenSemesterProjekt.Interfaces
{
    public interface IRoutesRepository
    {
        IEnumerable<Route> GetAllRoutes();
        Route GetRoutes(int id);
        void EditRoutes(Route routes);

        void DeleteRoutes(Route routes);

        Route AddRoute(Route r);

        void DeleteRoute(int id);
    }
}
