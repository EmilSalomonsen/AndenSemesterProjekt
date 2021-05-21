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
        private readonly AppDBContext _context;

        public RouteService(AppDBContext context)
        {
            _context = context;
        }

        public Route AddRoute(Route r)
        {
            //GetAllRoutes().ToList();
            //List<int> routeIds = new List<int>();
            //foreach (var rc in GetAllRoutes())
            //{
            //    routeIds.Add(rc.RouteId);
            //}
            //if (routeIds.Count !=0)
            //{
            //    int start = routeIds.Max();
            //    r.RouteId = start + 1;
            //}
            //else
            //{
            //    r.RouteId = 1;
            //}
            _context.Routes.Add(r);
            _context.SaveChanges();
            return r;
        }

        public Route EditRoutes(Route r)
        {
            var routes = _context.Routes.Attach(r);
            routes.State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            _context.SaveChanges();
            return r;
        }

        public IEnumerable<Route> GetAllRoutes()
        {
            return _context.Routes;
        }

        public Route GetRoutes(int id)
        {
            return _context.Routes.Where(r => r.RouteId == id).FirstOrDefault();
        }


        //public Route DeleteRoute(Route Route)
        //{
        //    Route route = _context.Routes.Find(Route);
        //    if (route != null)
        //    {
        //        _context.Routes.Remove(route);
        //        _context.SaveChanges();
        //    }

        //    return route;

        //}

        public void DeleteRoute(int id)
        {
            Route route = _context.Routes.Find(id);
            if (route != null)
            {
                _context.Routes.Remove(route);
                _context.SaveChanges();
            }
        }
        public void AddAttendantToRoute(Route route)
        {
            _context.Attach(route);
            _context.Entry(route).Property("AttendantId)").IsModified = true;
            _context.SaveChanges();
        }

    }
}

