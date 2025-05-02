using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Destination.Models.destinationTest
{
    [Table("temp12", Schema = "dbo")]
    public partial class Temp12
    {
        public string MonthName { get; set; }

        public string Year { get; set; }

        public decimal? Service { get; set; }

        public string ServiceName { get; set; }

        public int? YearNum { get; set; }

        public int? MonthNum { get; set; }
    }
}