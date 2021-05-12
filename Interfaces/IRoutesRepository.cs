using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AndenSemesterProjekt.Models;
using AndenSemesterProjekt.Pages.Routes;

namespace AndenSemesterProjekt.Interfaces
{
    public interface IRoutesRepository
    {
        IEnumerable<Routes> FilterRoutes(string criteria);
        IEnumerable<Routes> GetAllRoutes();
        Routes AddRoutes(Routes r);
        Routes UpdateRoutes(Routes r);
        Routes DeleteRoutes(int id);
        void AddRoutes(CreateRoutesModel Routes);
        Routes GetRoutes(int id);
        void EditRoutes(Routes routes);
    }

}
