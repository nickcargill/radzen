using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Destination.Models.destinationTest
{
    [Table("tblDebug", Schema = "dbo")]
    public partial class TblDebug
    {
        [Column("ID")]
        public int? Id { get; set; }

        [Column("pagename")]
        public string Pagename { get; set; }

        [Column("paymentid")]
        public int? Paymentid { get; set; }

        [Column("bookingid")]
        public int? Bookingid { get; set; }

        [Column("returnAmnt")]
        public decimal? ReturnAmnt { get; set; }

        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("PrimaryID")]
        public int PrimaryId { get; set; }

        public DateTime? DtCreated { get; set; }
    }
}