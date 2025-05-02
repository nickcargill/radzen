using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Destination.Models.destinationTest
{
    [Table("BookingQuote", Schema = "dbo")]
    public partial class BookingQuote
    {
        [Key]
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

        public double? DamageWaiver { get; set; }

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

        [Column("quote_date")]
        public DateTime? QuoteDate { get; set; }

        [Column("last_updated")]
        public DateTime? LastUpdated { get; set; }

        [Column("firstname")]
        public string Firstname { get; set; }

        [Column("lastname")]
        public string Lastname { get; set; }

        [Column("phone")]
        public string Phone { get; set; }

        [Column("cell")]
        public string Cell { get; set; }

        [Column("email")]
        public string Email { get; set; }

        [Column("address")]
        public string Address { get; set; }

        [Column("city")]
        public string City { get; set; }

        [Column("state")]
        public string State { get; set; }

        [Column("zip")]
        public string Zip { get; set; }

        public int? NumberOfAdults { get; set; }

        public int? NumberOfChildren { get; set; }

        public int? NumberOfPets { get; set; }

        public double? RatePerNight { get; set; }

        public double? OnlinePayment { get; set; }

        public double? ResortFee { get; set; }

        public DateTime? FutureBookings { get; set; }
    }
}