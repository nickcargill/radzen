using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Destination.Models.destinationTest
{
    [Table("BookingsOriginalPubRate", Schema = "dbo")]
    public partial class BookingsOriginalPubRate
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("ID")]
        public int Id { get; set; }

        [Column("BookingID")]
        public int? BookingId { get; set; }

        public decimal? OrgRentalAmount { get; set; }

        public decimal? OrgPubRate { get; set; }

        public decimal? OrdPerc { get; set; }

        public DateTime? OrgDateFrom { get; set; }

        public DateTime? OrgDateTo { get; set; }

        public DateTime CreatedDate { get; set; }

        public bool? IsProcessed { get; set; }
    }
}