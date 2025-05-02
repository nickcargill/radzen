using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Destination.Models.destinationTest
{
    [Table("UV_GetBookings", Schema = "dbo")]
    public partial class UvGetBooking
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("id")]
        public int Id { get; set; }

        [Column("propertyid")]
        public int? Propertyid { get; set; }

        [Column("datefrom")]
        public DateTime? Datefrom { get; set; }

        [Column("dateto")]
        public DateTime? Dateto { get; set; }

        [Column("statusid")]
        public int? Statusid { get; set; }

        [Column("notes")]
        public string Notes { get; set; }

        [Column("rentalamount")]
        public double? Rentalamount { get; set; }

        [Column("nights")]
        public int? Nights { get; set; }

        [Column("processingfee")]
        public double? Processingfee { get; set; }

        [Column("petfee")]
        public double? Petfee { get; set; }

        [Column("cleaningfee")]
        public double? Cleaningfee { get; set; }

        [Column("amountdue")]
        public double? Amountdue { get; set; }

        [Column("tax")]
        public double? Tax { get; set; }

        [Column("deposit")]
        public double? Deposit { get; set; }

        [Column("mgtfee")]
        public double? Mgtfee { get; set; }

        [Column("tenantid")]
        public int? Tenantid { get; set; }

        [Column("cleaner")]
        public int? Cleaner { get; set; }

        [Column("cleaneramount")]
        public double? Cleaneramount { get; set; }

        [Column("depositreturned")]
        public bool? Depositreturned { get; set; }

        public double? Collected { get; set; }

        [Column("receiptinfo")]
        public string Receiptinfo { get; set; }

        [Column("ccfee")]
        public double? Ccfee { get; set; }

        [Column("method")]
        public string Method { get; set; }

        public double? OwnerPaid { get; set; }

        [Column("guests")]
        public int? Guests { get; set; }

        [Column("bookingdate")]
        public DateTime? Bookingdate { get; set; }

        [Column("grossamount")]
        public double? Grossamount { get; set; }

        [Column("checkin")]
        public string Checkin { get; set; }

        [Column("checkout")]
        public string Checkout { get; set; }

        public double? Petdeposit { get; set; }

        [Column("taxableamount")]
        public double? Taxableamount { get; set; }

        [Column("outstanding")]
        public double? Outstanding { get; set; }

        [Column("duenow")]
        public double? Duenow { get; set; }

        [Column("ownerbooking")]
        public bool? Ownerbooking { get; set; }

        [Column("sourceid")]
        public int? Sourceid { get; set; }

        [Column("contractrec")]
        public bool? Contractrec { get; set; }

        [Column("samedaycleaning")]
        public string Samedaycleaning { get; set; }

        [Column("inquiry_date")]
        public DateTime? InquiryDate { get; set; }

        [Column("sales_agent")]
        public string SalesAgent { get; set; }

        public string PrebookingNotes { get; set; }

        public string PostbookingNotes { get; set; }

        [Column("remarks")]
        public string Remarks { get; set; }

        [Column("last_updated")]
        public DateTime? LastUpdated { get; set; }

        [Column("cleaningNotes")]
        public string CleaningNotes { get; set; }

        public string SecurityNotes { get; set; }

        [Column("backtoback")]
        public bool? Backtoback { get; set; }

        [Column("cleaningcomp")]
        public bool? Cleaningcomp { get; set; }

        [Column("inspected")]
        public bool? Inspected { get; set; }

        [Column("cleandate")]
        public DateTime? Cleandate { get; set; }

        [Column("inspectedby")]
        public int? Inspectedby { get; set; }

        [Column("inspectdate")]
        public DateTime? Inspectdate { get; set; }

        [Column("returnedamount")]
        public double? Returnedamount { get; set; }

        [Column("depositdate")]
        public DateTime? Depositdate { get; set; }

        [Column("clean_date")]
        public DateTime? CleanDate1 { get; set; }

        [Column("inspect_date")]
        public DateTime? InspectDate1 { get; set; }

        [Column("deposit_date")]
        public DateTime? DepositDate1 { get; set; }

        [Column("cleanercontacted")]
        public bool? Cleanercontacted { get; set; }

        [Column("inspectionnotes")]
        public string Inspectionnotes { get; set; }

        [Column("testoutstanding")]
        public double? Testoutstanding { get; set; }

        [Column("testduenow")]
        public double? Testduenow { get; set; }

        public bool? IsOnlineBooking { get; set; }

        public double? DamageWaiver { get; set; }

        public int? NumberofAdults { get; set; }

        public int? NumberofChildren { get; set; }

        public int? NumberofPets { get; set; }

        public double? OnlinePayment { get; set; }

        [Column("booking_update")]
        public DateTime? BookingUpdate { get; set; }

        public double? OutstandingActual { get; set; }

        public double? OutstandingDiff { get; set; }

        public double? CompFee { get; set; }

        public double? ResortFee { get; set; }

        public DateTime? ClosingDate { get; set; }

        [Column("AffiliateID")]
        public int? AffiliateId { get; set; }
    }
}