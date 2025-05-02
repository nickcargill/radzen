using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Destination.Models.destinationTest
{
    [Table("PropertyWatchList", Schema = "dbo")]
    public partial class PropertyWatchList
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("id")]
        public int Id { get; set; }

        [Column("propid")]
        public int? Propid { get; set; }

        [Column("why")]
        public string Why { get; set; }

        [Column("notes")]
        public string Notes { get; set; }
    }
}