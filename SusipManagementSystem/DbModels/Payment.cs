using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace SusipManagementSystem.DbModels
{
    [Keyless]
    public partial class Payment
    {
        public int PaymentId { get; set; }
        public int SubjectId { get; set; }
        public int TeacherId { get; set; }
        public bool IsPaymentDone { get; set; }
        public int Amount { get; set; }
    }
}
