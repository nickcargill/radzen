using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Destination.Models.destinationTest
{
    [Table("BulkSMSTest1", Schema = "dbo")]
    public partial class BulkSmstest1
    {
        [Column("id")]
        public int? Id { get; set; }

        [Column("last_updated")]
        public string LastUpdated { get; set; }

        [Column("statusId")]
        public int? StatusId { get; set; }

        [Column("email")]
        public string Email { get; set; }

        [Column("firstname")]
        public string Firstname { get; set; }

        [Column("lastname")]
        public string Lastname { get; set; }

        [Column("datefrom")]
        public string Datefrom { get; set; }

        [Column("dateto")]
        public string Dateto { get; set; }

        [Column("propid")]
        public int? Propid { get; set; }

        [Column("homeguide")]
        public string Homeguide { get; set; }

        [Column("lockbox")]
        public string Lockbox { get; set; }

        [Column("checkout")]
        public string Checkout { get; set; }

        [Column("address")]
        public string Address { get; set; }

        [Column("city")]
        public string City { get; set; }

        [Column("zip")]
        public string Zip { get; set; }

        public string Name { get; set; }

        public string Bedrooms { get; set; }

        public string Baths { get; set; }

        [Column("sleep_num")]
        public string SleepNum { get; set; }

        [Column("nights")]
        public int? Nights { get; set; }

        [Column("rentalamount")]
        public double? Rentalamount { get; set; }

        [Column("tax")]
        public double? Tax { get; set; }

        [Column("ccfee")]
        public double? Ccfee { get; set; }

        [Column("processingfee")]
        public double? Processingfee { get; set; }

        [Column("petfee")]
        public double? Petfee { get; set; }

        [Column("cleaningfee")]
        public double? Cleaningfee { get; set; }

        [Column("grossamount")]
        public double? Grossamount { get; set; }

        [Column("deposit")]
        public double? Deposit { get; set; }

        public double? Petdeposit { get; set; }

        [Column("outstanding")]
        public double? Outstanding { get; set; }

        public double? ResortFee { get; set; }

        public string Code { get; set; }

        [Column("content")]
        public string Content { get; set; }

        public string CheckinTime { get; set; }

        [Column("checkoutTime")]
        public string CheckoutTime { get; set; }

        [Column("cell")]
        public string Cell { get; set; }

        public string PropHeadlines { get; set; }

        public string Warning { get; set; }

        public string AlarmCode { get; set; }

        [Column("AffiliateID")]
        public int? AffiliateId { get; set; }

        [Column("CampaignID")]
        public int? CampaignId { get; set; }
    }
}