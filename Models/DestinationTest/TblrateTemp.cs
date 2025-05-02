using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Destination.Models.destinationTest
{
    [Table("tblrateTemp", Schema = "dbo")]
    public partial class TblrateTemp
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("ID")]
        public int Id { get; set; }

        [Column("PD_ID")]
        public int? PdId { get; set; }

        [Column("PropID")]
        public int? PropId { get; set; }

        public DateTime? DateStart { get; set; }

        public decimal? Rate { get; set; }
    }
}