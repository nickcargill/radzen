using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Destination.Models.destinationTest
{
    [Table("PromoCodes", Schema = "dbo")]
    public partial class PromoCode
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("ID")]
        public int Id { get; set; }

        [Column("PromoCode")]
        public string PromoCode1 { get; set; }

        public decimal? PercentOff { get; set; }

        public bool? IsActive { get; set; }

        public DateTime? FromDate { get; set; }

        public DateTime? ToDate { get; set; }

        [Column("PropID")]
        public int? PropId { get; set; }

        public Property Property { get; set; }

        public string DiscountType { get; set; }
    }
}