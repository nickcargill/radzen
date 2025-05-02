using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Destination.Models.destinationTest
{
    [Table("vw_PropertyOccupiedStatus", Schema = "dbo")]
    public partial class VwPropertyOccupiedStatus
    {
        [Column("name")]
        public string Name { get; set; }

        [Column("propid")]
        [Required]
        public int Propid { get; set; }

        [Column("Occuped Status")]
        [Required]
        public string OccupedStatus { get; set; }
    }
}