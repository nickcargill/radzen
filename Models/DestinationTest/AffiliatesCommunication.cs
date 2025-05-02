using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Destination.Models.destinationTest
{
    [Table("AffiliatesCommunication", Schema = "dbo")]
    public partial class AffiliatesCommunication
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("ID")]
        public int Id { get; set; }

        [Column("AffiliateID")]
        public int? AffiliateId { get; set; }

        public string Communication { get; set; }

        public int? LoggedBy { get; set; }

        public DateTime LoggedOn { get; set; }

        public bool? Pin { get; set; }
    }
}