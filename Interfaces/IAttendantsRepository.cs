using AndenSemesterProjekt.Models;
using AndenSemesterProjekt.Pages.Attendants;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AndenSemesterProjekt.Interfaces
{
    public interface IAttendantsRepository
    {
        Attendant GetAttendant(string id);
        void DeleteAttendant(Attendant attendant);
    }

}
