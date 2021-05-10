using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AndenSemesterProjekt
{
    public class Attendants : Users
    {
        public bool IAmAttendant { get; set; }


        /*this method takes an attendant and grabs all the data from said attendant and creates a new driver using the data from the attendant,
        then deletes the attendant from the attendant database, so the user only shows up in one of the two database tables*/
        public void changeToDriver(Attendants Attendant)
        {
            addDriver(Attendant.getNavn(), Attendant.getPassword(), Attendant.getAdresse());
            Attendants.sletAttendant(Attendant.getID());
        }
    }
}
