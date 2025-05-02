using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Destination.Models.destinationTest
{
    [Table("OwnerUpdate", Schema = "dbo")]
    public partial class OwnerUpdate
    {
        public DateTime? DateCreated { get; set; }

        public int? Agent { get; set; }
    }
}