using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Destination.Models.destinationTest
{
    [Table("property_type", Schema = "dbo")]
    public partial class PropertyType
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("typeid")]
        public int Typeid { get; set; }

        [Column("type")]
        public string Type { get; set; }
    }
}