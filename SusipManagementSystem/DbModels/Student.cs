using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace SusipManagementSystem.DbModels
{
    [Keyless]
    public partial class Student
    {
        public int StudentId { get; set; }
        [Required]
        [StringLength(200)]
        public string StudentName { get; set; }
        [StringLength(200)]
        public string Address { get; set; }
        public int? TelephoneNumber { get; set; }
        public int? Age { get; set; }
        public int Grade { get; set; }
    }
}
