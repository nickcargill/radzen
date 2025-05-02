using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Destination.Models.destinationTest
{
    [Table("vw_GetLastInspectedDateForAllActiveProp", Schema = "dbo")]
    public partial class VwGetLastInspectedDateForAllActiveProp
    {
        [Column("PropID")]
        [Required]
        public int PropId { get; set; }

        [Column("name")]
        public string Name { get; set; }

        public DateTime? InspectedDate { get; set; }

        [Column("statusid")]
        public int? Statusid { get; set; }
    }
}