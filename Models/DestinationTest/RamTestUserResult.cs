using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Destination.Models.destinationTest
{
    [Table("RamTestUserResults", Schema = "dbo")]
    public partial class RamTestUserResult
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("ID")]
        public int Id { get; set; }

        [Column("RamQuestionID")]
        public int? RamQuestionId { get; set; }

        public RamQuestion RamQuestion { get; set; }

        [Column("UserID")]
        public int? UserId { get; set; }

        public RamTestUser RamTestUser { get; set; }

        public bool? Result { get; set; }
    }
}