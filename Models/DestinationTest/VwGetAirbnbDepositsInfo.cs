using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Destination.Models.destinationTest
{
    [Table("VW_GetAirbnbDepositsInfo", Schema = "dbo")]
    public partial class VwGetAirbnbDepositsInfo
    {
        [Column("ID")]
        [Required]
        public int Id { get; set; }
    }
}