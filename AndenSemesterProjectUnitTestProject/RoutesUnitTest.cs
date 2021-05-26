using System;
using System.Linq;
using AndenSemesterProjekt.Models;
using AndenSemesterProjekt.Services;
using Microsoft.AspNetCore.Routing.Constraints;
using Microsoft.EntityFrameworkCore;
using Xunit;
using System.Collections.Generic;

namespace AndenSemesterProjectUnitTestProject
{
    public class RoutesUnitTest : EFTestDataService
    {
        public RoutesUnitTest() : base(new DbContextOptionsBuilder<AppDBContext>().UseInMemoryDatabase("Filename=Test.db").Options)
        {

        }

        // Unit test 1 (GetAllRoutes)
        [Fact]
        public void Get_All_Routes_Test()
        {
            using (var context = new AppDBContext(ContextOptions))
            {
                RouteService rService = new RouteService(context);
                var routes = rService.GetAllRoutes().ToList();
                Assert.Equal(2, routes.Count);
                Assert.Equal("Roskildevej 5", routes[0].StartAdress);
                Assert.Equal("Roskildevej 2", routes[1].StartAdress);
            }
            
        }

        //Unit test 2 (AddRoute)
        [Fact]
        public void Add_Route_Test()
        {
            using (var context = new AppDBContext(ContextOptions))
            {
                RouteService rService = new RouteService(context);

                rService.AddRoute(new Route()
                {
                    DriverId = 3,
                    NrOfSeats = "Three",
                    StartAdress = "Roskildevej 12",
                    EndAdress = "Zealand",
                    Eta = "4 min"
                });
                var routes = rService.GetAllRoutes().ToList();
                Assert.True(routes.Count == 3);
                Assert.Equal("Roskildevej 12", routes[2].StartAdress);
            }

        }

        //Unit test 3 (DeleteRoute)
        [Fact]
        public void Delete_Route_Test()
        {
            using (var context = new AppDBContext(ContextOptions))
            {
                RouteService rService = new RouteService(context);

                var route = rService.GetAllRoutes().Where(r => r.RouteId == 2).FirstOrDefault();

                rService.DeleteRoute(route.RouteId);
                var routes = rService.GetAllRoutes().ToList();
                Assert.True(routes.Count == 1);
                Assert.Equal("Roskildevej 5", routes[0].StartAdress);
            }
        }

        //Unit test 4 (Search for specific route)
        [Fact]
        public void Filter_Route_By_ID_Test()
        {
            using (var context = new AppDBContext(ContextOptions))
            {
                RouteService rService = new RouteService(context);

                int Id = 1;
                var routes = rService.GetRoutes(Id);

                Assert.True(routes.NrOfSeats == "Four");
                Assert.True(routes.EndAdress == "Zealand");
                //Assert.Equal(1, routes.RouteId);
            }
        }

        //Unit test 5 (Get a route by routeId)
        //[Fact]
        //public void Get_Route_By_RouteId_Test()
        //{
        //    using (var context = new AppDBContext(ContextOptions))
        //    {
        //        RouteService rService = new RouteService(context);

        //        var routes = rService.GetRoutes().Where(r => r.RouteId == 1);
        //        Assert.True(routes.ToList().Count == 0);

        //    }
        //}


        // Unit test 6 (filterroute by criteria)
        [Fact]
        public void Filter_Route_By_Criteria_Test()
        {
            using (var context = new AppDBContext(ContextOptions))
            {
                RouteService rService = new RouteService(context);

                string criteria = "Four";
                var routes = rService.FilterRoute(criteria);

                Assert.True(routes.ToList().Count == 2);
                //Assert.True(routes.EndAdress == "Zealand");
                //Assert.Equal(1, routes.RouteId);
            }
        }
    }
}
