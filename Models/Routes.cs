using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AndenSemesterProjekt.Models
{
    public class Routes
    {
        public int ID { get; set; }
        public int NrOfSeats { get; set; }
        public string StartAdress { get; set; }
        public string EndAdress { get; set; }
        public DateTime ETA { get; set; }
        public int DriverID { get; set; }
        public DateTime StartTime { get; set; }
        public DateTime ArivalTime { get; set; }
        public int PickupPointID { get; set; }
    }
}
