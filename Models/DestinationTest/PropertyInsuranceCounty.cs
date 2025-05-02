using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Destination.Models.destinationTest
{
    [Table("PropertyInsuranceCounty", Schema = "dbo")]
    public partial class PropertyInsuranceCounty
    {
        public string PropNameWithNotes { get; set; }

        public string Address { get; set; }

        [Column("Permit Expiration")]
        public DateTime? PermitExpiration { get; set; }

        [Column("Permit # ")]
        public string Permit { get; set; }

        [Column("Policy Company name")]
        public string PolicyCompanyName { get; set; }

        public string Broker { get; set; }

        public string Expiration { get; set; }

        [Column("Coverage ")]
        public string Coverage { get; set; }

        public string AdditionalInsured { get; set; }

        public string Notes { get; set; }

        public string F12 { get; set; }

        public string F13 { get; set; }

        public string F14 { get; set; }

        public string F15 { get; set; }

        public string F16 { get; set; }

        public string F17 { get; set; }

        public string F18 { get; set; }

        public string F19 { get; set; }

        public string F20 { get; set; }

        public string F21 { get; set; }

        public string F22 { get; set; }

        public string F23 { get; set; }

        public string F24 { get; set; }

        public string F25 { get; set; }

        public string F26 { get; set; }

        public string F27 { get; set; }

        public string F28 { get; set; }

        public string F29 { get; set; }

        public string PropName { get; set; }
    }
}