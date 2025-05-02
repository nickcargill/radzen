using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Destination.Models.destinationTest
{
    [Table("vw_GetPropListWithControlLog", Schema = "dbo")]
    public partial class VwGetPropListWithControlLog
    {
        [Column("propid")]
        [Required]
        public int Propid { get; set; }

        [Column("name")]
        public string Name { get; set; }

        [Column("address")]
        public string Address { get; set; }

        [Column("city")]
        public int? City { get; set; }

        [Column("bedrooms")]
        public string Bedrooms { get; set; }

        [Column("baths")]
        public string Baths { get; set; }

        [Column("controlid")]
        public int? Controlid { get; set; }

        [Column("who")]
        public int? Who { get; set; }

        [Column("completed")]
        public bool? Completed { get; set; }

        [Column("completeddate")]
        public DateTime? Completeddate { get; set; }

        [Column("ControlLogID")]
        [Required]
        public int ControlLogId { get; set; }

        public string Notes { get; set; }
    }
}