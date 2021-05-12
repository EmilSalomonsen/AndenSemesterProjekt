using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AndenSemesterProjekt.Models;

namespace AndenSemesterProjekt.Models
{
    public class Drivers : Users
    {
        public bool IAmDriver { get; set; }
    }
}
