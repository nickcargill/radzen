using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Destination.Models.destinationTest
{
    [Table("CreditRequests", Schema = "dbo")]
    public partial class CreditRequest
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("CreditRequestID")]
        public int CreditRequestId { get; set; }

        [Column("BookingID")]
        public int? BookingId { get; set; }

        public Booking Booking { get; set; }

        public double? Amount { get; set; }

        public double? Ownerscut { get; set; }

        public double? Dbbcut { get; set; }

        public string Notes { get; set; }

        public int? ReviewedBy { get; set; }

        public DateTime? ReviewedDate { get; set; }

        [Column("avoidable")]
        public string Avoidable { get; set; }

        [Column("ResourceID")]
        public int? ResourceId { get; set; }

        public int? Type { get; set; }

        public DateTime? Datefrom { get; set; }

        public DateTime? DateTo { get; set; }

        [Column("PropID")]
        public int? PropId { get; set; }

        [Column("TaskID")]
        public int? TaskId { get; set; }

        public string SolutionStatus { get; set; }

        public bool? SolutionSolved { get; set; }

        public bool? WebsiteContent { get; set; }

        public bool? Accounting { get; set; }

        public bool? Maintenance { get; set; }

        public bool? Cleaning { get; set; }

        public bool? Closed { get; set; }
    }
}