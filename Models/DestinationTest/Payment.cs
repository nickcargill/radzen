using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Destination.Models.destinationTest
{
    [Table("Payment", Schema = "dbo")]
    public partial class Payment
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("intPaymentId")]
        public int IntPaymentId { get; set; }

        [Column("intBookingId")]
        public int? IntBookingId { get; set; }

        public Booking Booking { get; set; }

        [Column("decAmount")]
        public double? DecAmount { get; set; }

        [Column("strPaymentReceipt")]
        public string StrPaymentReceipt { get; set; }

        [Column("dtPaymentDate")]
        public string DtPaymentDate { get; set; }

        [Column("dtCreated")]
        public DateTime? DtCreated { get; set; }

        [Column("strTransactionId")]
        public string StrTransactionId { get; set; }

        [Column("strStatus")]
        public string StrStatus { get; set; }

        [Column("dtModified")]
        public DateTime? DtModified { get; set; }

        public string PaypalResponseCode { get; set; }

        public string PaypalResponseMsg { get; set; }
    }
}