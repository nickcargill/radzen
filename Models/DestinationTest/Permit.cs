using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Destination.Models.destinationTest
{
    [Table("Permits", Schema = "dbo")]
    public partial class Permit
    {
        [Column("ID")]
        public double? Id { get; set; }

        public string PermitNumber { get; set; }
    }
}