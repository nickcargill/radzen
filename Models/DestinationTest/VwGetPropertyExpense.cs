using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Destination.Models.destinationTest
{
    [Table("vw_getPropertyExpense", Schema = "dbo")]
    public partial class VwGetPropertyExpense
    {
        [Column("propid")]
        public int? Propid { get; set; }

        public string Type { get; set; }

        public string Description { get; set; }

        [Column("expense")]
        public double? Expense { get; set; }

        [Column("status")]
        public string Status { get; set; }

        [Column("datecompleted")]
        public DateTime? Datecompleted { get; set; }
    }
}