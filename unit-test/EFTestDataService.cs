using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AndenSemesterProjekt.Services;
using AndenSemesterProjekt.Models;
using AndenSemesterProjekt.Services;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Diagnostics;

namespace AndenSemesterProjectUnitTestProject
{
    public class EFTestDataService
    {
        protected DbContextOptions<AppDBContext>ContextOptions { get; }

        protected EFTestDataService(DbContextOptions<AppDBContext> contextOptions)
        {
            ContextOptions = contextOptions;
            Seed();
        }

        private void Seed()
        {
            using (var context = new AppDBContext(ContextOptions))
            {
                context.Database.EnsureDeleted();
                context.Database.EnsureCreated();
                //context.Routes.Add(new Route()
                //{
                //    RouteId = 1, DriverId = 1, NrOfSeats = "Four", StartAdress = "Roskildevej 5", EndAdress = "Zealand",
                //    Eta = "5 min"
                //});
                //context.Routes.Add(new Route()
                //{
                //    DriverId = 2,
                //    NrOfSeats = "Four",
                //    StartAdress = "Roskildevej 2",
                //    EndAdress = "Zealand",
                //    Eta = "5 min"
                //});

                var routes = new List<Route>
                {
                    new Route()
                    {
                        RouteId = 1, DriverId = 1, NrOfSeats = "Four", StartAdress = "Roskildevej 5",
                        EndAdress = "Zealand", Eta = "5 min"
                    },
                    new Route()
                    {
                        RouteId = 2, DriverId = 2, NrOfSeats = "Four", StartAdress = "Roskildevej 2",
                        EndAdress = "Zealand", Eta = "15 min"
                    }
                };
                context.AddRange(routes);
                context.SaveChanges();
            }
        }


    }
}
