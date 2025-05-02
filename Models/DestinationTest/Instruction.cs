using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Destination.Models.destinationTest
{
    [Table("Instruction", Schema = "dbo")]
    public partial class Instruction
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("instructionid")]
        public int Instructionid { get; set; }

        [Column("instruction")]
        public string Instruction1 { get; set; }

        public bool? Training { get; set; }

        public string Answer { get; set; }

        public string Name { get; set; }

        [Column("cat")]
        public string Cat { get; set; }

        [Column("video")]
        public string Video { get; set; }

        [Column("item")]
        public string Item { get; set; }

        [Column("IsTOP")]
        public bool? IsTop { get; set; }
    }
}