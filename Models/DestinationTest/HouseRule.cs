using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Destination.Models.destinationTest
{
    [Table("HouseRule", Schema = "dbo")]
    public partial class HouseRule
    {
        public string RuleText { get; set; }

        public string RuleTextSample { get; set; }
    }
}