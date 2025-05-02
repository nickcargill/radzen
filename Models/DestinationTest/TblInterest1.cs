using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Destination.Models.destinationTest
{
    [Table("tblInterests", Schema = "dbo")]
    public partial class TblInterest1
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("InterestID")]
        public int InterestId { get; set; }

        public string InterestDesc { get; set; }
    }
}