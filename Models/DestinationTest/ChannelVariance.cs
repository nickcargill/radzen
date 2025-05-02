using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Destination.Models.destinationTest
{
    [Table("ChannelVariance", Schema = "dbo")]
    public partial class ChannelVariance
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("ID")]
        public int Id { get; set; }

        public string EventName { get; set; }

        [Column("PropID")]
        public int? PropId { get; set; }

        public decimal? Vrbo { get; set; }

        public decimal? Airbnb { get; set; }
    }
}