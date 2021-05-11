using AndenSemesterProjekt.Pages.Routes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AndenSemesterProjekt.Interfaces
{
    interface IRoutesRepository
    {
        EditRoutesModel GetRoutes(int id);
        void EditRoutes(EditRoutesModel routes);
    }
}
