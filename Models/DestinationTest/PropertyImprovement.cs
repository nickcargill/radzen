using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Destination.Models.destinationTest
{
    [Table("Property_improvement", Schema = "dbo")]
    public partial class PropertyImprovement
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("propimproveid")]
        public int Propimproveid { get; set; }

        public string ImprovementDesc { get; set; }

        public int? Resource { get; set; }

        public bool? Completed { get; set; }

        public int? Priority { get; set; }

        [Column("propid")]
        public int? Propid { get; set; }

        public Property Property { get; set; }

        public DateTime? DateOpen2 { get; set; }

        [Column("imptype")]
        public string Imptype { get; set; }

        public int? WhoOpened { get; set; }

        public int? WhoModified { get; set; }

        public string Status { get; set; }

        public DateTime? ModifiedDate { get; set; }

        public string Notes { get; set; }
    }
}