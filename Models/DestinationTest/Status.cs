using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Destination.Models.destinationTest
{
    [Table("Status", Schema = "dbo")]
    public partial class Status
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("statusid")]
        public int Statusid { get; set; }

        [Column("Status")]
        public string Status1 { get; set; }

        public ICollection<Property> Properties { get; set; }
    }
}