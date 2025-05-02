using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Destination.Models.destinationTest
{
    [Table("Utilities", Schema = "dbo")]
    public partial class Utility
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("id")]
        public int Id { get; set; }

        [Column("propid")]
        public int? Propid { get; set; }

        [Column("electric")]
        public string Electric { get; set; }

        [Column("water")]
        public string Water { get; set; }

        [Column("gas")]
        public string Gas { get; set; }

        [Column("cable")]
        public string Cable { get; set; }

        [Column("directtv")]
        public string Directtv { get; set; }
    }
}