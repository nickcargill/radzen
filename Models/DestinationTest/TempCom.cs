using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Destination.Models.destinationTest
{
    [Table("tempCom", Schema = "dbo")]
    public partial class TempCom
    {
        [Column("id")]
        public int? Id { get; set; }

        [Column("bookingdate")]
        public DateTime? Bookingdate { get; set; }

        [Column("datefrom")]
        public DateTime? Datefrom { get; set; }

        [Column("dateto")]
        public DateTime? Dateto { get; set; }

        [Column("tenantid")]
        public int? Tenantid { get; set; }

        [Required]
        public string IsCheckIn { get; set; }

        [Column("inquiry_date")]
        public DateTime? InquiryDate { get; set; }

        [Column("last_updated")]
        public DateTime? LastUpdated { get; set; }

        [Column("rentalamount")]
        public decimal? Rentalamount { get; set; }

        [Column("nights")]
        public int? Nights { get; set; }

        [Column("tax")]
        public double? Tax { get; set; }

        [Column("cleaningfee")]
        public double? Cleaningfee { get; set; }

        [Column("petfee")]
        public double? Petfee { get; set; }

        [Column("processingfee")]
        public decimal? Processingfee { get; set; }

        [Column("grossamount")]
        public double? Grossamount { get; set; }

        [Column("deposit")]
        public double? Deposit { get; set; }

        public double? Petdeposit { get; set; }

        [Column("amountdue")]
        public double? Amountdue { get; set; }

        [Column("outstanding")]
        public double? Outstanding { get; set; }

        [Column("duenow")]
        public double? Duenow { get; set; }

        [Required]
        public double Collected { get; set; }

        [Column("mgtfee")]
        public decimal? Mgtfee { get; set; }

        public decimal? DamageWaiver { get; set; }

        public decimal? CompFee { get; set; }

        [Column("firstname")]
        public string Firstname { get; set; }

        [Column("lastname")]
        public string Lastname { get; set; }

        [Column("tenant_phone")]
        public string TenantPhone { get; set; }

        [Column("cell")]
        public string Cell { get; set; }

        public string Email { get; set; }

        public string AirbnbEmail { get; set; }

        [Column("tenant_tenantid")]
        public int? TenantTenantid { get; set; }

        [Column("propid")]
        [Required]
        public int Propid { get; set; }

        public string Name { get; set; }

        [Column("Property_address")]
        public string PropertyAddress { get; set; }

        [Column("Property_city")]
        public int? PropertyCity { get; set; }

        [Column("Property_zip")]
        public string PropertyZip { get; set; }

        [Column("code")]
        public string Code { get; set; }

        [Column("instructions")]
        public string Instructions { get; set; }

        [Column("Internal_notes")]
        public string InternalNotes { get; set; }

        [Column("Booking_Status_status")]
        public string BookingStatusStatus { get; set; }

        [Column("Booking_Status_id")]
        public int? BookingStatusId { get; set; }

        [Column("Property_cleaner")]
        public string PropertyCleaner { get; set; }

        public string Source { get; set; }

        public string HomeGuide { get; set; }

        [Required]
        public string IsCleaned { get; set; }

        public string Bedrooms { get; set; }

        public double? PropMgtRate { get; set; }

        [Column("DBB")]
        public decimal? Dbb { get; set; }

        [Required]
        public string RateReviewed { get; set; }

        [Column("agentid")]
        public int? Agentid { get; set; }

        public string Msg { get; set; }

        [Required]
        public DateTime MsgDate { get; set; }

        [Column("CommID")]
        [Required]
        public int CommId { get; set; }

        public string AirbnbReplyLink { get; set; }
    }
}