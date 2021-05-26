﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace AndenSemesterProjekt.Models
{
    public partial class Route
    {
        [Key]
        [Column("RouteID")]
        public int RouteId { get; set; }

        [Column("DriverID")]
        public int DriverId { get; set; }
    
        [Column("AttendantID")]
        public int? AttendantId { get; set; }

        [Required]
        [StringLength(10)]
        public string NrOfSeats { get; set; }

        [Required]
        [StringLength(50)]
        public string StartAdress { get; set; }

        [Required]
        [StringLength(50)]
        public string EndAdress { get; set; }
       
        [Column("ETA")]
        [StringLength(10)]
        public string Eta { get; set; }
       
        public string PickupPoints { get; set; }

        public string ImageName { get; set; }

        [ForeignKey(nameof(AttendantId))]
        [InverseProperty("Routes")]
        public virtual Attendant Attendant { get; set; }
        [ForeignKey(nameof(DriverId))]
        [InverseProperty("Routes")]
        public virtual Driver Driver { get; set; }
    }
}