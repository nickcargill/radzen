using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Destination.Models.destinationTest
{
    [Table("AirbnbIcalsUpdateTracking", Schema = "dbo")]
    public partial class AirbnbIcalsUpdateTracking
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("ID")]
        public int Id { get; set; }

        [Column("PropID")]
        public int? PropId { get; set; }

        public DateTime? ExecutedAt { get; set; }
    }
}