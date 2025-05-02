using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Destination.Models.destinationTest
{
    [Table("CleanerGroup", Schema = "dbo")]
    public partial class CleanerGroup
    {
        public int? GroupId { get; set; }

        public int? CleanerId { get; set; }
    }
}