using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Destination.Models.destinationTest
{
    [Table("Inntopia_PushTimeLog", Schema = "dbo")]
    public partial class InntopiaPushTimeLog
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("ID")]
        public int Id { get; set; }

        public string PushType { get; set; }

        public DateTime? PushTime { get; set; }

        [Column("PropID")]
        public string PropId { get; set; }
    }
}