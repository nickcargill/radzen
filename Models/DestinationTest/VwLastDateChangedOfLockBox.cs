using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Destination.Models.destinationTest
{
    [Table("vw_LastDateChangedOfLockBox", Schema = "dbo")]
    public partial class VwLastDateChangedOfLockBox
    {
        [Column("PropID")]
        public int? PropId { get; set; }

        public DateTime? DateChange { get; set; }

        public string NewDoorCode { get; set; }
    }
}