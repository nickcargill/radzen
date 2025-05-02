using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Destination.Models.destinationTest
{
    [Table("Media", Schema = "dbo")]
    public partial class Medium
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("mediaid")]
        public int Mediaid { get; set; }

        public string Name { get; set; }

        [Column("type")]
        public int? Type { get; set; }

        [Column("PropertyID")]
        public int? PropertyId { get; set; }

        [Column("path")]
        public string Path { get; set; }

        [Column("show")]
        public bool? Show { get; set; }

        [Column("sort")]
        public int? Sort { get; set; }
    }
}