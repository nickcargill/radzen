using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Destination.Models.destinationTest
{
    [Table("Property_OwnerInstruction", Schema = "dbo")]
    public partial class PropertyOwnerInstruction
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("id")]
        public int Id { get; set; }

        public int? PropId { get; set; }

        [Column("instructions")]
        public string Instructions { get; set; }
    }
}