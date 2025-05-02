using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Destination.Models.destinationTest
{
    [Table("ChatBotKeywordMaster", Schema = "dbo")]
    public partial class ChatBotKeywordMaster
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("ID")]
        public int Id { get; set; }

        [Column("keywords")]
        public string Keywords { get; set; }

        [Column("FlowID")]
        public int? FlowId { get; set; }
    }
}