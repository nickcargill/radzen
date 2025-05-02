using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Destination.Models.destinationTest
{
    [Table("vw_LastRecordedOwnerCommunication", Schema = "dbo")]
    public partial class VwLastRecordedOwnerCommunication
    {
        public int? Agentid { get; set; }

        public DateTime? Cdate { get; set; }

        [Column("ownercomm")]
        public string Ownercomm { get; set; }
    }
}