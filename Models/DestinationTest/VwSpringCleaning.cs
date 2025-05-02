using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Destination.Models.destinationTest
{
    [Table("vw_SpringCleaning", Schema = "dbo")]
    public partial class VwSpringCleaning
    {
        [Column("PropID")]
        public int? PropId { get; set; }

        public string Name { get; set; }

        [Column("expense")]
        public double? Expense { get; set; }

        public string LastUpdated { get; set; }

        public string Description { get; set; }
    }
}