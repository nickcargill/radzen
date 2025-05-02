using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Destination.Models.destinationTest
{
    [Table("Property_Warnings", Schema = "dbo")]
    public partial class PropertyWarning
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("ID")]
        public int Id { get; set; }

        [Column("PropID")]
        [Required]
        public int PropId { get; set; }

        public Property Property { get; set; }

        public string Warning { get; set; }

        public bool? PreTalk { get; set; }
    }
}