using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace SusipManagementSystem.DbModels
{
    public partial class Document
    {
        [Key]
        public int DocumentId { get; set; }
        [Required]
        [StringLength(100)]
        public string DocumentName { get; set; }
    }
}
