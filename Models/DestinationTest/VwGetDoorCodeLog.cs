using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Destination.Models.destinationTest
{
    [Table("vw_GetDoorCodeLog", Schema = "dbo")]
    public partial class VwGetDoorCodeLog
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("PropID")]
        public int PropId { get; set; }

        public string Name { get; set; }

        public string Address { get; set; }

        [Required]
        public string DoorCode { get; set; }

        [Required]
        public string LastChangeDate { get; set; }
    }
}