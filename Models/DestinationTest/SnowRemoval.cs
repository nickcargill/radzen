using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Destination.Models.destinationTest
{
    [Table("SnowRemoval", Schema = "dbo")]
    public partial class SnowRemoval
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("ID")]
        public int Id { get; set; }

        [Column("PropID")]
        public int? PropId { get; set; }

        public string YearVal { get; set; }

        [Column("VendorID")]
        public int? VendorId { get; set; }
    }
}