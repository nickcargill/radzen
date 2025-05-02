using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Destination.Models.destinationTest
{
    [Table("DoorCodeLog", Schema = "dbo")]
    public partial class DoorCodeLog
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("ID")]
        public int Id { get; set; }

        [Column("propid")]
        public int? Propid { get; set; }

        public string NewDoorCode { get; set; }

        public string OldDoorCode { get; set; }

        public DateTime ChangeDate { get; set; }
    }
}