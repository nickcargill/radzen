using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Destination.Models.destinationTest
{
    [Table("PropertyInsurance", Schema = "dbo")]
    public partial class PropertyInsurance
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("ID")]
        public int Id { get; set; }

        public string PropName { get; set; }

        [Column("PropID")]
        public int? PropId { get; set; }

        public string Address { get; set; }

        public DateTime? PermitRenewalDate { get; set; }

        public string PermitNumber { get; set; }

        public string PolicyCompanyName { get; set; }

        public string Broker { get; set; }

        public DateTime? Expiration { get; set; }

        public string Coverage { get; set; }

        public string AdditionalInsured { get; set; }

        public string Notes { get; set; }
    }
}