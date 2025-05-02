using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Destination.Models.destinationTest
{
    [Table("Sample23", Schema = "dbo")]
    public partial class Sample23
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("propid")]
        public int Propid { get; set; }
    }
}