using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Destination.Models.destinationTest
{
    [Table("InquiryNA", Schema = "dbo")]
    public partial class InquiryNa
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("ID")]
        public int Id { get; set; }

        public DateTime? StartDate { get; set; }

        [Column("PropID")]
        public int? PropId { get; set; }

        public int? GapDays { get; set; }

        public DateTime? EnteredOn { get; set; }
    }
}