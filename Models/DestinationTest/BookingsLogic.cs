using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Destination.Models.destinationTest
{
    [Table("BookingsLogic", Schema = "dbo")]
    public partial class BookingsLogic
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("intLogicID")]
        public int IntLogicId { get; set; }

        [Column("dtDateFrom1")]
        public DateTime? DtDateFrom1 { get; set; }

        [Column("dtDateFrom2")]
        public DateTime? DtDateFrom2 { get; set; }

        [Column("intPropId")]
        public int? IntPropId { get; set; }

        public Property Property { get; set; }

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

        [Column("type")]
        public string Type { get; set; }

        public string Condition { get; set; }

        [Column("strPage")]
        public string StrPage { get; set; }

        [Column("VRBONights")]
        public int? Vrbonights { get; set; }
    }
}