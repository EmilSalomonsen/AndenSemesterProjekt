using AndenSemesterProjekt.Models;
using AndenSemesterProjekt.Pages.Drivers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AndenSemesterProjekt.Interfaces
{
    public interface IDriversRepository
    {
        Driver GetDriver(string id);

        Driver DeleteDriver(Driver driver);
    }
}
