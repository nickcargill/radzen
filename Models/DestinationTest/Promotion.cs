using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Destination.Models.destinationTest
{
    [Table("Promotions", Schema = "dbo")]
    public partial class Promotion
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("ID")]
        public int Id { get; set; }

        public string Name { get; set; }

        public DateTime? DateFrom { get; set; }

        public DateTime? DateTo { get; set; }

        public decimal? MinSpent { get; set; }

        public string Description { get; set; }

        public string LinkToField { get; set; }

        public string Status { get; set; }

        public DateTime? CreatedOn { get; set; }
    }
}