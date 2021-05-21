using AndenSemesterProjekt.Interfaces;
using AndenSemesterProjekt.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AndenSemesterProjekt.Services
{
    public class DriverService
    {
        private readonly UsersdbContext _context;

        public DriverService(UsersdbContext context)
        {
            _context = context;
        }
        public Driver GetDriver(string id)
        {
            return _context.Drivers.Where(d => d.DriverId == id).FirstOrDefault();
        }
        public void DeleteDriver(Driver driver)
        {
            _context.Drivers.Remove(driver);
            _context.SaveChanges();
        }
    }
}
