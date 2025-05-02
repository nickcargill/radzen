using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Destination.Models.destinationTest
{
    [Table("vw_GetPropReviewCount", Schema = "dbo")]
    public partial class VwGetPropReviewCount
    {
        [Column("propid")]
        [Required]
        public int Propid { get; set; }

        [Column("name")]
        public string Name { get; set; }

        public int? ReviewCount { get; set; }
    }
}