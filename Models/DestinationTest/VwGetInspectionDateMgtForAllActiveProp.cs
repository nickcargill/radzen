using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Destination.Models.destinationTest
{
    [Table("vw_GetInspectionDateMgtForAllActiveProp", Schema = "dbo")]
    public partial class VwGetInspectionDateMgtForAllActiveProp
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int PropId { get; set; }

        [Column("name")]
        public string Name { get; set; }

        [Required]
        public DateTime InsMgtDate { get; set; }
    }
}