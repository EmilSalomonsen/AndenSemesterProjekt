using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AndenSemesterProjekt.Pages.Routes;

namespace AndenSemesterProjekt.Interfaces
{
    interface IRoutesRepository
    {
        IEnumerable<Routes> FilterRoutes(string criteria);
        IEnumerable<Routes> GetAllRoutes();
        Routes GetRoutes(int id);
        Routes AddRoutes(Routes r);
        Routes UpdateRoutes(Routes r);
        Routes DeleteRoutes(int id);
        void AddRoutes(CreateRoutesModel Routes);
    }
}
