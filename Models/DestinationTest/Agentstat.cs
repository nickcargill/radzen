using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Destination.Models.destinationTest
{
    [Table("agentstats", Schema = "dbo")]
    public partial class Agentstat
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("id")]
        public int Id { get; set; }

        [Column("agentid")]
        public int? Agentid { get; set; }

        [Column("date")]
        public DateTime? Date { get; set; }

        [Column("callsin")]
        public string Callsin { get; set; }

        [Column("talktimein")]
        public string Talktimein { get; set; }

        [Column("callsout")]
        public string Callsout { get; set; }

        [Column("talktimeout")]
        public string Talktimeout { get; set; }

        public string Totaltalktime { get; set; }

        [Column("notes")]
        public string Notes { get; set; }
    }
}