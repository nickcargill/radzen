using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Destination.Models.destinationTest
{
    [Table("AffiliatesData", Schema = "dbo")]
    public partial class AffiliatesDatum
    {
        public string Type { get; set; }

        [Column("Company Name")]
        public string CompanyName { get; set; }

        [Column("Primary Representative")]
        public string PrimaryRepresentative { get; set; }

        public string Email { get; set; }

        [Column("Primary Phone")]
        public string PrimaryPhone { get; set; }

        [Column("Physical City")]
        public string PhysicalCity { get; set; }

        [Column("Last Touched")]
        public DateTime? LastTouched { get; set; }

        [Column("Website?")]
        public string Website { get; set; }

        public string Notes { get; set; }
    }
}