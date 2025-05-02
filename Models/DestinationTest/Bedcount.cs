using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Destination.Models.destinationTest
{
    [Table("Bedcount", Schema = "dbo")]
    public partial class Bedcount
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("bedcountid")]
        public int Bedcountid { get; set; }

        public int? King { get; set; }

        public int? Queen { get; set; }

        public int? FulBed { get; set; }

        public int? Twin { get; set; }

        [Column("propid")]
        public int? Propid { get; set; }
    }
}