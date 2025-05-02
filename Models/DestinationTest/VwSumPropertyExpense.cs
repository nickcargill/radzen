using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Destination.Models.destinationTest
{
    [Table("vw_sumPropertyExpense", Schema = "dbo")]
    public partial class VwSumPropertyExpense
    {
        [Column("name")]
        public string Name { get; set; }

        public int? Total { get; set; }
    }
}