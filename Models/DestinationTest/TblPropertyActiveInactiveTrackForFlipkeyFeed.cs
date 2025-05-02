using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Destination.Models.destinationTest
{
    [Table("tblPropertyActiveInactiveTrack_ForFlipkeyFeed", Schema = "dbo")]
    public partial class TblPropertyActiveInactiveTrackForFlipkeyFeed
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("ID")]
        public int Id { get; set; }

        [Column("PropID")]
        public int? PropId { get; set; }

        public DateTime? UpdatedDate { get; set; }

        public bool? IsPicked { get; set; }
    }
}