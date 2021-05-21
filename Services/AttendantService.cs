using AndenSemesterProjekt.Interfaces;
using AndenSemesterProjekt.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AndenSemesterProjekt.Services
{
    public class AttendantService : IAttendantsRepository
    {
        private readonly UsersdbContext _context;

        public AttendantService(UsersdbContext context)
        {
            _context = context;
        }

        public Attendant GetAttendant(string id)
        {
            return _context.Attendants.Where(a => a.AttendantId == id).FirstOrDefault();
        }
        public void DeleteAttendant(Attendant attendant)
        {
            _context.Attendants.Remove(attendant);
            _context.SaveChanges();
        }
    }
}
