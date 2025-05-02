using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Destination.Models.destinationTest
{
    [Table("vw_GetLastCleanedDateForAllActiveProp", Schema = "dbo")]
    public partial class VwGetLastCleanedDateForAllActiveProp
    {
        [Column("PropID")]
        [Required]
        public int PropId { get; set; }

        [Column("name")]
        public string Name { get; set; }

        public DateTime? CleanedDate { get; set; }

        [Column("statusid")]
        public int? Statusid { get; set; }
    }
}