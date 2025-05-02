using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Destination.Models.destinationTest
{
    [Table("CleanerInvoiceMatchedData", Schema = "dbo")]
    public partial class CleanerInvoiceMatchedDatum
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("ID")]
        public int Id { get; set; }

        [Column("CleanerID")]
        public int? CleanerId { get; set; }

        public DateTime? DateFrom { get; set; }

        public DateTime? DateTo { get; set; }

        public decimal? InvoiceTotal { get; set; }

        public DateTime? PayDate { get; set; }

        public DateTime? EnteredDate { get; set; }

        public string Notes { get; set; }

        public decimal? ExtraAmnt { get; set; }

        public decimal? Total { get; set; }

        public bool? IsMatched { get; set; }

        public DateTime? PartialPaid { get; set; }

        public bool? IsPartialMatch { get; set; }

        public DateTime? PartialMatchedOn { get; set; }
    }
}