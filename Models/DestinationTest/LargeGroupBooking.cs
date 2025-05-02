using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Destination.Models.destinationTest
{
    [Table("LargeGroupBookings", Schema = "dbo")]
    public partial class LargeGroupBooking
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("ID")]
        public int Id { get; set; }

        [Column("TenantID")]
        public int? TenantId { get; set; }

        public string DateFrom { get; set; }

        public string DateTo { get; set; }

        public string Notes { get; set; }

        public DateTime? DateEntered { get; set; }

        public bool? IsContacted { get; set; }
    }
}