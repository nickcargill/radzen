using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Destination.Models.destinationTest
{
    [Table("CommCodes", Schema = "dbo")]
    public partial class CommCode
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("commcodeid")]
        public int Commcodeid { get; set; }

        public string Code { get; set; }

        public string Description { get; set; }

        [Column("color")]
        public string Color { get; set; }
    }
}