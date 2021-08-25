using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace SusipManagementSystem.DbModels
{
    public partial class Teacher
    {
        [Key]
        public int TeachersId { get; set; }
        [Required]
        [StringLength(100)]
        public string TeachersName { get; set; }
        [Required]
        [StringLength(200)]
        public string Qualification { get; set; }
        [Column("experience")]
        public int Experience { get; set; }
    }
}
