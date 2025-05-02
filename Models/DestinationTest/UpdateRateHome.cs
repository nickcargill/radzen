using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Destination.Models.destinationTest
{
    [Table("UpdateRateHomes", Schema = "dbo")]
    public partial class UpdateRateHome
    {
        [Column("PropID")]
        [Required]
        public int PropId { get; set; }

        public string Name { get; set; }

        [Column("#Bkngs")]
        public int? Bkngs { get; set; }
    }
}