using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Destination.Models.destinationTest
{
    [Table("TenantWithPlusOneInCell", Schema = "dbo")]
    public partial class TenantWithPlusOneInCell
    {
        [Column("firstname")]
        public string Firstname { get; set; }

        [Column("lastname")]
        public string Lastname { get; set; }

        [Column("phone")]
        public string Phone { get; set; }

        [Column("cell")]
        public string Cell { get; set; }

        [Column("email")]
        public string Email { get; set; }

        [Column("address")]
        public string Address { get; set; }

        [Column("city")]
        public string City { get; set; }

        [Column("state")]
        public string State { get; set; }

        [Column("zip")]
        public string Zip { get; set; }

        [Column("source")]
        public int? Source { get; set; }

        [Column("notes")]
        public string Notes { get; set; }

        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("tenantid")]
        public int Tenantid { get; set; }

        [Column("propertyid")]
        public int? Propertyid { get; set; }

        [Column("datefrom")]
        public DateTime? Datefrom { get; set; }

        [Column("dateto")]
        public DateTime? Dateto { get; set; }

        [Column("begdate")]
        public DateTime? Begdate { get; set; }

        [Column("remarks")]
        public string Remarks { get; set; }

        public string Prebooknotes { get; set; }

        [Column("status")]
        public string Status { get; set; }

        [Column("role")]
        public int? Role { get; set; }

        public bool? IsDeleted { get; set; }

        [Column("password")]
        public string Password { get; set; }

        [Column("initials")]
        public string Initials { get; set; }

        public int? TotalBookings { get; set; }

        public string ColorValue { get; set; }

        public int? TenantRating { get; set; }

        public int? AirbnbVerifications { get; set; }

        public int? AirbnbReviews { get; set; }

        public string AirbnbEmail { get; set; }
    }
}