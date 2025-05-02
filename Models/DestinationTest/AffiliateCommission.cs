using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Destination.Models.destinationTest
{
    [Table("AffiliateCommission", Schema = "dbo")]
    public partial class AffiliateCommission
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("AffiliateCommissionID")]
        public int AffiliateCommissionId { get; set; }

        [Column("AffiliatorID")]
        [Required]
        public int AffiliatorId { get; set; }

        public DateTime? DateRangeStart { get; set; }

        public DateTime? DateRangeEnd { get; set; }

        public int? Commission { get; set; }
    }
}