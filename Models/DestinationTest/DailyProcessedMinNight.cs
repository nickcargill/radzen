using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Destination.Models.destinationTest
{
    [Table("DailyProcessedMinNights", Schema = "dbo")]
    public partial class DailyProcessedMinNight
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("ID")]
        public int Id { get; set; }

        [Column("PropID")]
        public int? PropId { get; set; }

        public int? MinNight { get; set; }

        public DateTime? CreatedDate { get; set; }

        public DateTime? EffectiveDate { get; set; }
    }
}