using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Destination.Models.destinationTest
{
    [Table("vw_GetUniqueTenant", Schema = "dbo")]
    public partial class VwGetUniqueTenant
    {
        [Column("TenantID")]
        public int? TenantId { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        [Column("ID")]
        public int? Id { get; set; }

        public DateTime? VisitedOn { get; set; }

        public string PageUrl { get; set; }

        [Column("BookingID")]
        public int? BookingId { get; set; }

        [Column("BulkEmailID")]
        public int? BulkEmailId { get; set; }
    }
}