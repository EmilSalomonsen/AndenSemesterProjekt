﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace AndenSemesterProjekt
{
    public class Users
    {
        [Key]
        public int userID { get; set; }

        public string username { get; set; }

        public string password { get; set; }

        public string firstName { get; set; }

        public string lastName { get; set; }

        public int phoneNumber { get; set; }

        public string address { get; set; }

        public int zipcode { get; set; }




    }
}
