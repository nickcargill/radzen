using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Destination.Models.destinationTest
{
    [Table("TenantSheet", Schema = "dbo")]
    public partial class TenantSheet
    {
        [Column("full_name")]
        public string FullName { get; set; }

        [Column("email")]
        public string Email { get; set; }

        [Column("phone_number")]
        public double? PhoneNumber { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        [Column("TenantID")]
        public int? TenantId { get; set; }
    }
}