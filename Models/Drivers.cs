using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AndenSemesterProjekt
{
    public class Drivers : Users
    {
        public bool IAmDriver { get; set; }


        /*this method takes an Driver and grabs all the data from said driver and creates a new attendant using the data from the driver,
        then deletes the driver from the attendant database, so the user only shows up in one of the two database tables*/
        public void changeToAttendants(Drivers Driver)
        {
            addAttendant(Driver.getNavn(), Driver.getPassword(), Driver.getAdresse());
            Driver.sletDriver(Driver.getID());
        }
    }
}
