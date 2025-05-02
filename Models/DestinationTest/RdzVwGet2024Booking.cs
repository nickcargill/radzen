using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Destination.Models.destinationTest
{
    [Table("RDZ_vw_Get2024Bookings", Schema = "dbo")]
    public partial class RdzVwGet2024Booking
    {
        [Column("id")]
        [Required]
        public int Id { get; set; }

        [Column("PropID")]
        [Required]
        public int PropId { get; set; }

        [Column("name")]
        public string Name { get; set; }

        [Column("TenantID")]
        public int? TenantId { get; set; }

        public string LastName { get; set; }

        public DateTime? DateFrom { get; set; }

        public DateTime? DateTo { get; set; }

        public int? Nights { get; set; }

        public int? Guests { get; set; }

        [Column("StatusID")]
        public int? StatusId { get; set; }

        public string Status { get; set; }

        public double? RentalAmount { get; set; }

        public double? ProcessingFee { get; set; }

        public double? CleaningFee { get; set; }

        public double? AmountDue { get; set; }

        public double? Tax { get; set; }

        public double? MgtFee { get; set; }

        public double? CleanerAmount { get; set; }

        public double? Collected { get; set; }

        public double? Deposit { get; set; }

        public double? GrossAmount { get; set; }

        [Column("SourceID")]
        public int? SourceId { get; set; }

        public string Source { get; set; }

        public double? CompFee { get; set; }

        public double? ResortFee { get; set; }
    }
}