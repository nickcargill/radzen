using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Destination.Models.destinationTest
{
    [Table("vw_GetLastDateCompletedFromExpense", Schema = "dbo")]
    public partial class VwGetLastDateCompletedFromExpense
    {
        [Column("PropID")]
        [Required]
        public int PropId { get; set; }

        [Column("name")]
        public string Name { get; set; }

        public DateTime? ClosedDate { get; set; }

        public string ExpDesc { get; set; }
    }
}