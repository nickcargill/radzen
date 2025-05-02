using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Destination.Models.destinationTest
{
    [Table("Restrictions", Schema = "dbo")]
    public partial class Restriction
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("ID")]
        public int Id { get; set; }

        public string Description { get; set; }

        public int? RestrictDays { get; set; }

        public bool? IsRestricted { get; set; }
    }
}