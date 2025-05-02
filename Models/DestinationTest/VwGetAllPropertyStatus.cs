using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Destination.Models.destinationTest
{
    [Table("vw_GetAllPropertyStatus", Schema = "dbo")]
    public partial class VwGetAllPropertyStatus
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("propid")]
        public int Propid { get; set; }

        [Required]
        public string AvailabilityStatus { get; set; }
    }
}