using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Destination.Models.destinationTest
{
    [Table("Settings", Schema = "dbo")]
    public partial class Setting
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("ID")]
        public int Id { get; set; }

        public string Label1 { get; set; }

        public string Label2 { get; set; }

        public string Label3 { get; set; }

        public string UrlLink { get; set; }

        public int? DayPriorCancellation { get; set; }
    }
}