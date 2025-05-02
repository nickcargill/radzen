using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Destination.Models.destinationTest
{
    [Table("Annual", Schema = "dbo")]
    public partial class Annual
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("ID")]
        public int Id { get; set; }

        public DateTime? SubmissionTime { get; set; }

        [Column("AgentID")]
        public int? AgentId { get; set; }

        [Column("PropID")]
        public int? PropId { get; set; }

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

        public DateTime? DeepCleanDate { get; set; }

        public DateTime? WindowCleanDate { get; set; }

        public DateTime? AbatementDate { get; set; }

        public DateTime? CarpetDate { get; set; }

        public string Notes { get; set; }

        [Column("CarpetTaskID")]
        public int? CarpetTaskId { get; set; }

        [Column("WindowTaskID")]
        public int? WindowTaskId { get; set; }

        [Column("DeepTaskID")]
        public int? DeepTaskId { get; set; }

        [Column("AbatementTaskID")]
        public int? AbatementTaskId { get; set; }

        public DateTime? HeaterFilterDate { get; set; }
    }
}