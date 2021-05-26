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
            r.AttendantId = 1;
            r.DriverId = 1;
            _context.Routes.Add(r);
            _context.SaveChanges();
            return r;
        }

        public Route EditRoutes(Route r)
        {
            r.AttendantId = 1;
            r.DriverId = 1;
            var routes = _context.Routes.Attach(r);
            routes.State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            _context.SaveChanges();
            return r;
        }

        public IEnumerable<Route> GetAllRoutes()
        {
            return _context.Routes;
        }

        public IEnumerable<Route> FilterRoute(string criteria)
        {
            if (string.IsNullOrEmpty(criteria))
            {
                return _context.Routes;
            }

            return _context.Routes.Where(e => e.NrOfSeats == criteria);
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
        public Route AddAttendantToRoute(Route route)
        {
            var Foundroute = _context.Routes.First(r => r.RouteId == route.RouteId);
            Foundroute.AttendantId = route.AttendantId;
            //routes.State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            _context.SaveChanges();
            return route;
        }

        public void RemoveAttendantFromRoute(Route route, int? id)
        {
            var Foundroute = _context.Routes.First(r => r.RouteId == route.RouteId && r.AttendantId == id);
            Foundroute.AttendantId = null;
            //routes.State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            _context.SaveChanges();
            
        }
        //{
        //    Attendant attendant = _context.Attendants.ToList().Where(a => a.AttendantId == id).FirstOrDefault();
        //    if (attendant != null)
        //    {
        //        _context.Attendants.Remove(attendant);
        //        _context.SaveChanges();
        //    }
        //}



    }
}

     


