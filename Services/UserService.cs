using AndenSemesterProjekt.Interfaces;
using AndenSemesterProjekt.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AndenSemesterProjekt.Services
{
    public class UserService
    {
        private readonly UsersdbContext _context;

        public UserService(UsersdbContext context)
        {
            _context = context;
        }
        public User GetUser(string id)
        {
            return _context.Users.Where(u => u.UserId == id).FirstOrDefault();
        }
        public void RemoveUser(User user)
        {
            _context.Users.Remove(user);
            _context.SaveChanges();
        }
    }
}
