using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Destination.Models.destinationTest
{
    [Table("DoNotRent", Schema = "dbo")]
    public partial class DoNotRent
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("ID")]
        public int Id { get; set; }

        [Column("TenantID")]
        public int? TenantId { get; set; }

        [Column("BookingID")]
        public int? BookingId { get; set; }

        public DateTime? DateOpened { get; set; }

        public string Reason { get; set; }

        public string Status { get; set; }

        public DateTime? CloseDate { get; set; }

        public string Communication { get; set; }

        public string Type { get; set; }

        public DateTime? LastUpdated { get; set; }
    }
}