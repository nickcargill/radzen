using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Destination.Models.destinationTest
{
    [Table("BookingsLogic2", Schema = "dbo")]
    public partial class BookingsLogic2
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("intLogicId")]
        public int IntLogicId { get; set; }

        [Column("dtDateFrom")]
        public DateTime? DtDateFrom { get; set; }

        [Column("dtDateTo")]
        public DateTime? DtDateTo { get; set; }

        [Column("intPropId")]
        public int? IntPropId { get; set; }

        [Column("intNights")]
        public int? IntNights { get; set; }

        [Column("isActive")]
        public bool? IsActive { get; set; }

        [Column("dtCreated")]
        public DateTime? DtCreated { get; set; }

        [Column("dtModified")]
        public DateTime? DtModified { get; set; }

        public string Description { get; set; }

        public int? MinRatePercentage { get; set; }

        [Column("dtDateFrom2")]
        public DateTime? DtDateFrom2 { get; set; }

        [Column("type")]
        public string Type { get; set; }
    }
}