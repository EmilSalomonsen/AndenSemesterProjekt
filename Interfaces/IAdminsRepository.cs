using AndenSemesterProjekt.Models;
using AndenSemesterProjekt.Pages.Admin;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AndenSemesterProjekt.Interfaces
{
    public interface IAdminsRepository
    {
        Admin GetAdmin(int id);
        void DeleteAdmin(Admin admin);
    }
}
