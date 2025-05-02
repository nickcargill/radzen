using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Destination.Models.destinationTest
{
    [Table("tempMissed", Schema = "codecharge")]
    public partial class CodechargeTempmissed
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("ID")]
        public int Id { get; set; }

        public int? PropId { get; set; }

        public DateTime? MissedDate { get; set; }
    }
}