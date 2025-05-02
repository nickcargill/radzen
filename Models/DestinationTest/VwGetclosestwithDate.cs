using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Destination.Models.destinationTest
{
    [Table("vw_getclosestwithDate", Schema = "dbo")]
    public partial class VwGetclosestwithDate
    {
        [Column("propertyid")]
        public int? Propertyid { get; set; }

        [Column("dateto")]
        public DateTime? Dateto { get; set; }
    }
}