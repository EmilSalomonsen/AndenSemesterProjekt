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
        Routes GetRoutes(int id);

        void EditRoutes(Routes routes);

        void DeleteRoute(Routes routes);
    }
}
