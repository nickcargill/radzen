using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Destination.Models.destinationTest
{
    [Table("Property_Bed", Schema = "dbo")]
    public partial class PropertyBed
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Column("propId")]
        public int? PropId { get; set; }

        public Property Property { get; set; }

        [Column("bed")]
        public int? Bed { get; set; }

        public int? King { get; set; }

        public int? Queen { get; set; }

        public int? FullBed { get; set; }

        public int? Twin { get; set; }

        [Column("Pullout_Couches")]
        public int? PulloutCouches { get; set; }

        [Column("Twin_Bunk")]
        public int? TwinBunk { get; set; }

        public int? MiniBed { get; set; }

        [Column("type")]
        public string Type { get; set; }

        public string Name { get; set; }
    }
}