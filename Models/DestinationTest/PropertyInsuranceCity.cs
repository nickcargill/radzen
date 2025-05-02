using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Destination.Models.destinationTest
{
    [Table("PropertyInsuranceCity", Schema = "dbo")]
    public partial class PropertyInsuranceCity
    {
        public string PropName { get; set; }

        public string PropNameNotes { get; set; }

        [Column("ADDRESS")]
        public string Address { get; set; }

        [Column("Permit Renewal Date")]
        public DateTime? PermitRenewalDate { get; set; }

        [Column("PERMIT # ")]
        public string Permit { get; set; }

        [Column("Policy Company name")]
        public string PolicyCompanyName { get; set; }

        public string Broker { get; set; }

        public DateTime? Expiration { get; set; }

        [Column("Coverage ")]
        public decimal? Coverage { get; set; }

        public string AdditionalInsured { get; set; }

        public string Notes { get; set; }
    }
}