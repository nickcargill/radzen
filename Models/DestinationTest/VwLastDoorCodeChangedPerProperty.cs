using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Destination.Models.destinationTest
{
    [Table("vw_LastDoorCodeChangedPerProperty", Schema = "dbo")]
    public partial class VwLastDoorCodeChangedPerProperty
    {
        [Column("propid")]
        public int? Propid { get; set; }

        [Column("name")]
        public string Name { get; set; }

        public string CurrentDoorCode { get; set; }

        public DateTime? LastDateChanged { get; set; }
    }
}