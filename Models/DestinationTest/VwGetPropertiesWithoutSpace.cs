using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Destination.Models.destinationTest
{
    [Table("vw_GetPropertiesWithoutSpaces", Schema = "dbo")]
    public partial class VwGetPropertiesWithoutSpace
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Propid { get; set; }

        public string Name { get; set; }
    }
}