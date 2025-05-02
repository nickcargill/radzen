using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Destination.Models.destinationTest
{
    [Table("CoronaAnnualData", Schema = "dbo")]
    public partial class CoronaAnnualDatum
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("ID")]
        public int Id { get; set; }

        public DateTime? SubmissionTime { get; set; }

        public string Email { get; set; }

        public string SpringCleaning { get; set; }

        public string Carpets { get; set; }

        public string Outside { get; set; }

        public string Windows { get; set; }

        public string Decks { get; set; }

        public string Open { get; set; }

        public string PropertyName { get; set; }

        public string Questions { get; set; }

        public string Cleaned { get; set; }

        [Column("PropID")]
        public int? PropId { get; set; }

        [Column("AgentID")]
        public int? AgentId { get; set; }
    }
}