using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Destination.Models.destinationTest
{
    [Table("PropertyDeposit", Schema = "dbo")]
    public partial class PropertyDeposit
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        public int? PropId { get; set; }

        public bool? IsDamageWaiver { get; set; }

        public int? CollectedAmount { get; set; }
    }
}