using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Destination.Models.destinationTest
{
    [Table("TestTableForDailyRoutine", Schema = "dbo")]
    public partial class TestTableForDailyRoutine
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("ID")]
        public int Id { get; set; }

        [Column("PageURl")]
        public string PageUrl { get; set; }

        public DateTime? ExecutedOn { get; set; }
    }
}