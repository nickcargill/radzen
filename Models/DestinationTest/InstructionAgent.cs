using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Destination.Models.destinationTest
{
    [Table("Instruction_Agent", Schema = "dbo")]
    public partial class InstructionAgent
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int InstAgent { get; set; }

        [Column("AgentID")]
        public int? AgentId { get; set; }

        public int? Reviewed { get; set; }

        public int? Instructionid { get; set; }

        [Column("datereviewed")]
        public DateTime? Datereviewed { get; set; }
    }
}