// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace AndenSemesterProjekt.Models
{
    public partial class Attendant
    {
        public Attendant()
        {
            Routes = new HashSet<Route>();
        }

        [Key]
        [Column("AttendantID")]
        [StringLength(5)]
        public int AttendantId { get; set; }
        [StringLength(20)]
        public string Phone { get; set; }

        [InverseProperty(nameof(Route.Attendant))]
        public virtual ICollection<Route> Routes { get; set; }
    }
}