using AndenSemesterProjekt.Interfaces;
using AndenSemesterProjekt.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AndenSemesterProjekt.Services
{
    public class RouteService : IRoutesRepository
    {
        private readonly UsersdbContext _context;

        public RouteService(UsersdbContext context)
        {
            _context = context;
        }
        public void EditRoutes(Route routes)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Route> GetAllRoutes()
        {
            return _context.Routes.ToList();
        }

        public Route GetRoutes(int id)
        {
            return _context.Routes.Where(r => r.RouteId == id).FirstOrDefault();
        }

        public void DeleteRoutes(Route route)
        {
            _context.Routes.Remove(route);
            _context.SaveChanges();
        }
    }
}
