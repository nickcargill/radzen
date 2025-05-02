using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Destination.Models.destinationTest
{
    [Table("Vrboaudit", Schema = "dbo")]
    public partial class Vrboaudit
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("ID")]
        public int Id { get; set; }

        [Column("ReservationID")]
        public string ReservationId { get; set; }

        [Column("ReservationExternalID")]
        public int? ReservationExternalId { get; set; }

        [Column("UOM")]
        public string Uom { get; set; }

        public DateTime? CheckInDate { get; set; }

        public DateTime? CheckOutDate { get; set; }

        public string Property { get; set; }

        public string ListingNumber { get; set; }

        public string ListingProductType { get; set; }

        [Column("PMSCPropID")]
        public int? PmscpropId { get; set; }

        public string TravelerEmail { get; set; }

        public decimal? GrossSaleAmount { get; set; }

        public decimal? CommissionRate { get; set; }

        public decimal? Commission { get; set; }

        public DateTime? BookingDate { get; set; }

        public string BookingType { get; set; }

        public string TravelerSite { get; set; }

        public DateTime? InquirySubmissionDate { get; set; }

        public string InquirySite { get; set; }

        public DateTime? InquiryCheckInDate { get; set; }

        public DateTime? InquiryCheckOutDate { get; set; }

        public string InquiryEmail { get; set; }

        public string DistributionChannel { get; set; }

        public bool? HomeAwayServiceFee { get; set; }

        public decimal? RentAmount { get; set; }

        public decimal? FeeAmount { get; set; }
    }
}