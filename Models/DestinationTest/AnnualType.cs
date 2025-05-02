using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Destination.Models.destinationTest
{
    [Table("AnnualType", Schema = "dbo")]
    public partial class AnnualType
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("ID")]
        public int Id { get; set; }

        public string TypeName { get; set; }

        public int? Orderby { get; set; }

        public string Dept { get; set; }
    }
}