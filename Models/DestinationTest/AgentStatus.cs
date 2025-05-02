using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Destination.Models.destinationTest
{
    [Table("AgentStatus", Schema = "dbo")]
    public partial class AgentStatus
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("statusid")]
        public int Statusid { get; set; }

        [Column("status")]
        public string Status { get; set; }
    }
}