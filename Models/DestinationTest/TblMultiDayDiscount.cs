using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Destination.Models.destinationTest
{
    [Table("tblMultiDayDiscount", Schema = "dbo")]
    public partial class TblMultiDayDiscount
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("ID")]
        public int Id { get; set; }

        public DateTime? StartDate { get; set; }

        public DateTime? EndDate { get; set; }

        [Column("PropID")]
        public int? PropId { get; set; }

        public Property Property { get; set; }

        public int? Nights { get; set; }

        [Column("PercentOFF")]
        public double? PercentOff { get; set; }
    }
}