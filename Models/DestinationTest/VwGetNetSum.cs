using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Destination.Models.destinationTest
{
    [Table("vw_GetNetSum", Schema = "dbo")]
    public partial class VwGetNetSum
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("id")]
        public int Id { get; set; }

        [Column("datefrom")]
        public DateTime? Datefrom { get; set; }

        [Column("dateto")]
        public DateTime? Dateto { get; set; }

        [Column("propertyid")]
        public int? Propertyid { get; set; }

        [Column("bookingdate")]
        public DateTime? Bookingdate { get; set; }

        [Column("nights")]
        public int? Nights { get; set; }

        [Column("rentalamount")]
        public double? Rentalamount { get; set; }

        [Column("processingfee")]
        public double? Processingfee { get; set; }

        [Column("petfee")]
        public double? Petfee { get; set; }

        [Column("cleaningfee")]
        public double? Cleaningfee { get; set; }

        [Column("tax")]
        public double? Tax { get; set; }

        [Column("mgtfee")]
        public double? Mgtfee { get; set; }

        [Column("compfee")]
        public double? Compfee { get; set; }

        [Column("resortfee")]
        public double? Resortfee { get; set; }

        public double? Gross { get; set; }

        public double? SumPayment { get; set; }

        [Column("netsum")]
        public double? Netsum { get; set; }
    }
}