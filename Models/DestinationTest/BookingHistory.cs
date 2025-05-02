using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Destination.Models.destinationTest
{
    [Table("BookingHistory", Schema = "dbo")]
    public partial class BookingHistory
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("intHistoryId")]
        public int IntHistoryId { get; set; }

        [Column("intBookingId")]
        public int? IntBookingId { get; set; }

        public Booking Booking { get; set; }

        [Column("strTemplateName")]
        public string StrTemplateName { get; set; }

        [Column("strCustomMsg")]
        public string StrCustomMsg { get; set; }

        [Column("intPropertyId")]
        public int? IntPropertyId { get; set; }

        [Column("intTenantId")]
        public int? IntTenantId { get; set; }

        [Column("datefrom")]
        public DateTime? Datefrom { get; set; }

        [Column("dateto")]
        public DateTime? Dateto { get; set; }

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

        [Column("dtCreated")]
        public DateTime? DtCreated { get; set; }

        [Column("due")]
        public double? Due { get; set; }

        [Column("agentid")]
        public int? Agentid { get; set; }

        [Column("agent")]
        public int? Agent { get; set; }

        [Column("amountdue")]
        public double? Amountdue { get; set; }

        public double? DamageWaiver { get; set; }

        public double? ResortFee { get; set; }
    }
}