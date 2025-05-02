using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Destination.Models.destinationTest
{
    [Table("AutoSMSPagesHitPerDay", Schema = "dbo")]
    public partial class AutoSmspagesHitPerDay
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("ID")]
        public int Id { get; set; }

        public string PageName { get; set; }

        public DateTime? HitDateTime { get; set; }
    }
}