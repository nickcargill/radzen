using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Destination.Models.destinationTest
{
    [Table("Discounts", Schema = "dbo")]
    public partial class Discount
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("discountid")]
        public int Discountid { get; set; }

        [Column("Discount")]
        public string Discount1 { get; set; }

        public string Discountdesc { get; set; }
    }
}