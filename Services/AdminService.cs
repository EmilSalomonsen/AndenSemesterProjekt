using AndenSemesterProjekt.Interfaces;
using AndenSemesterProjekt.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AndenSemesterProjekt.Services
{
    public class AdminService
    {
        private readonly UsersdbContext _context;

        public AdminService(UsersdbContext context)
        {
            _context = context;
        }
        public Admin GetAdmin(int id)
        {
            return _context.Admins.Where(A => A.adminID == id).FirstOrDefault();
        }

        public void DeleteAdmin(Admin admin)
        {
            _context.Admins.Remove(admin);
            _context.SaveChanges();
        }
    }
}
