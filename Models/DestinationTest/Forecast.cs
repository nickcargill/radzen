using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Destination.Models.destinationTest
{
    [Table("forecast", Schema = "dbo")]
    public partial class Forecast
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("id")]
        public int Id { get; set; }

        [Column("fpropid")]
        public int? Fpropid { get; set; }

        [Column("revenue")]
        public string Revenue { get; set; }

        [Column("commissions")]
        public string Commissions { get; set; }

        [Column("maintutilities")]
        public string Maintutilities { get; set; }

        [Column("net")]
        public string Net { get; set; }

        [Column("pros")]
        public string Pros { get; set; }

        [Column("cons")]
        public string Cons { get; set; }

        [Column("caveats")]
        public string Caveats { get; set; }

        [Column("summary")]
        public string Summary { get; set; }
    }
}