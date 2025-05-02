using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Destination.Models.destinationTest
{
    [Table("RamTestResults", Schema = "dbo")]
    public partial class RamTestResult
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("ID")]
        public int Id { get; set; }

        [Column("TableID")]
        public int? TableId { get; set; }

        [Column("UserID")]
        public int? UserId { get; set; }

        public RamTestUser RamTestUser { get; set; }

        public int? RightQuestions { get; set; }

        public int? WrongQuestions { get; set; }

        public int? TotalTime { get; set; }
    }
}