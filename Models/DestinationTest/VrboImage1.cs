using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Destination.Models.destinationTest
{
    [Table("VrboImage1", Schema = "dbo")]
    public partial class VrboImage1
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("ID")]
        public int Id { get; set; }

        [Column("PropertyID")]
        [Required]
        public int PropertyId { get; set; }

        [Required]
        public DateTime DateOfChange { get; set; }

        public bool IsPickedup { get; set; }

        [Required]
        public DateTime CreatedDate { get; set; }

        public DateTime? ModifyDate { get; set; }

        [Column("ExternalID")]
        public int? ExternalId { get; set; }
    }
}