using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Destination.Models.destinationTest
{
    [Table("warrranties", Schema = "dbo")]
    public partial class Warrranty
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("warrantyid")]
        public int Warrantyid { get; set; }

        public string Warranty { get; set; }

        [Column("propid")]
        public int? Propid { get; set; }
    }
}