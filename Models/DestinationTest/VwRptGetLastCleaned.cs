using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Destination.Models.destinationTest
{
    [Table("vw_rptGetLastCleaned", Schema = "dbo")]
    public partial class VwRptGetLastCleaned
    {
        public DateTime? CleanDate { get; set; }

        public string Name { get; set; }
    }
}