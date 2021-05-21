using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace AndenSemesterProjekt.Models
{
    public partial class Admin
    {
        [Key]
        [Column("adminID")]
        [StringLength(5)]
        public int adminID { get; set; }

        [Required]
        [StringLength(50)]
        public string adminFirstName { get; set; }

        [Required]
        [StringLength(50)]
        public string adminLastName { get; set; }

        [Required]
        [StringLength(50)]
        public string adminUsername { get; set; }

        [Required]
        [StringLength(50)]
        public string adminPassword { get; set; }



    }
}
