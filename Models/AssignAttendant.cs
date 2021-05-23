using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace AndenSemesterProjekt.Models
{
    public class AssignAttendant
    {
        [Key]
        [Column("AssignAttendantID")]
        public int AssignAttendantId { get; set; }

        [ForeignKey("RouteID")]
        [InverseProperty("AssignAttendant")]
        public virtual Route Route { get; set; }

        [ForeignKey("AttendantID")]
        [InverseProperty("AssignAttendant")]
        public virtual Attendant Attendant { get; set; }
    }
}
