using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Destination.Models.destinationTest
{
    [Table("OpinionStage_survey_leads_repor$", Schema = "dbo")]
    public partial class OpinionStageSurveyLeadsRepor
    {
        [Column("Submission Time")]
        public DateTime? SubmissionTime { get; set; }

        public string Email { get; set; }

        [Column(TypeName="xml")]
        public string SpringCleaning { get; set; }

        public string Carpets { get; set; }

        public string Outside { get; set; }

        public string Windows { get; set; }

        public string Decks { get; set; }

        public string Open { get; set; }

        public string PropertyName { get; set; }

        public string Questions { get; set; }

        public string Cleaned { get; set; }
    }
}