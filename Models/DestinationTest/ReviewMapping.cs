using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Destination.Models.destinationTest
{
    [Table("ReviewMapping", Schema = "dbo")]
    public partial class ReviewMapping
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("ID")]
        public int Id { get; set; }

        [Column("CurrentPropID")]
        public int? CurrentPropId { get; set; }

        [Column("OldPropID")]
        public int? OldPropId { get; set; }
    }
}