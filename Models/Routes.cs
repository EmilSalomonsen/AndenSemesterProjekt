using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AndenSemesterProjekt
{
    public class Routes
    {
        public int ID { get; set; }
        public int NrOfSeats { get; set; }
        public string StartAdress { get; set; }
        public string EndAdress { get; set; }
        public DateTime ETA { get; set; }
    }
}
