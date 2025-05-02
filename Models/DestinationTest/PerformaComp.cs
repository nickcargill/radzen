using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Destination.Models.destinationTest
{
    [Table("Performa_Comp", Schema = "dbo")]
    public partial class PerformaComp
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("id")]
        public int Id { get; set; }

        [Column("performa")]
        [Required]
        public int Performa { get; set; }

        [Column("comp")]
        [Required]
        public int Comp { get; set; }
    }
}