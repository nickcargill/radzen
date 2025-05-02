using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Destination.Models.destinationTest
{
    [Table("CleanerAuditedMsgs", Schema = "dbo")]
    public partial class CleanerAuditedMsg
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("ID")]
        public int Id { get; set; }

        [Column("SMSID")]
        public int? Smsid { get; set; }

        public DateTime? SavedDate { get; set; }
    }
}