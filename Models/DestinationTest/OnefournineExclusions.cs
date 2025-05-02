using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Destination.Models.destinationTest
{
    [Table("exclusions", Schema = "onefournine")]
    public partial class OnefournineExclusions
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("id")]
        public int Id { get; set; }

        [Column("propid")]
        public int? Propid { get; set; }

        [Column("type")]
        public int? Type { get; set; }
    }
}