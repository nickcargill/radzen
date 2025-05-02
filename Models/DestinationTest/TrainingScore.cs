using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Destination.Models.destinationTest
{
    [Table("TrainingScore", Schema = "dbo")]
    public partial class TrainingScore
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("intScoreId")]
        public int IntScoreId { get; set; }

        [Column("intAgentId")]
        public int? IntAgentId { get; set; }

        [Column("intScore")]
        public int? IntScore { get; set; }

        [Column("intMaximumScore")]
        public int? IntMaximumScore { get; set; }

        [Column("strTest")]
        public string StrTest { get; set; }

        [Column("dtCreated")]
        public DateTime? DtCreated { get; set; }
    }
}