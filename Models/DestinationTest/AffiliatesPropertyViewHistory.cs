using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Destination.Models.destinationTest
{
    [Table("AffiliatesPropertyView_History", Schema = "dbo")]
    public partial class AffiliatesPropertyViewHistory
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("ID")]
        public int Id { get; set; }

        [Column("AffiliateID")]
        public int? AffiliateId { get; set; }

        [Column("PropID")]
        public int? PropId { get; set; }

        public DateTime? ViewedOn { get; set; }

        public DateTime? FromDate { get; set; }

        public DateTime? ToDate { get; set; }
    }
}