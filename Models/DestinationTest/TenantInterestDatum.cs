using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Destination.Models.destinationTest
{
    [Table("TenantInterestData", Schema = "dbo")]
    public partial class TenantInterestDatum
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("ID")]
        public int Id { get; set; }

        [Column("InterestID")]
        public int? InterestId { get; set; }

        [Column("TenantID")]
        public int? TenantId { get; set; }

        public string InterestValue { get; set; }

        public DateTime? SubmissionTime { get; set; }
    }
}