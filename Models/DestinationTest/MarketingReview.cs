using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Destination.Models.destinationTest
{
    [Table("MarketingReviews", Schema = "dbo")]
    public partial class MarketingReview
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("ID")]
        public int Id { get; set; }

        [Column("propid")]
        public int? Propid { get; set; }

        public Property Property { get; set; }

        [Column("datereviewed")]
        public DateTime? Datereviewed { get; set; }

        [Column("employee")]
        public int? Employee { get; set; }

        [Column("notes")]
        public string Notes { get; set; }
    }
}