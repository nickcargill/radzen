using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Destination.Models.destinationTest
{
    [Table("Reviews", Schema = "dbo")]
    public partial class Review
    {
        [Column("bookingid")]
        [Required]
        public int Bookingid { get; set; }

        [Column("reviews")]
        public string Reviews { get; set; }

        public DateTime? LastUpdatedDate { get; set; }

        [Column("PropID")]
        public int? PropId { get; set; }

        public DateTime? DateFrom { get; set; }

        [Column("TenantID")]
        public int? TenantId { get; set; }

        public bool? IsFeatured { get; set; }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("ID")]
        public int Id { get; set; }
    }
}