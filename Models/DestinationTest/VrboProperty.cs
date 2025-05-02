using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Destination.Models.destinationTest
{
    [Table("VrboProperty", Schema = "dbo")]
    public partial class VrboProperty
    {
        public int? Id { get; set; }

        public int? VrboId { get; set; }

        public int? PropertyId { get; set; }

        [Column("link")]
        public string Link { get; set; }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("pid")]
        public int Pid { get; set; }
    }
}