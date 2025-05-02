using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Destination.Models.destinationTest
{
    [Table("ChatBotMenuMaster", Schema = "dbo")]
    public partial class ChatBotMenuMaster
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        public string MenuText { get; set; }

        public string MenuUrl { get; set; }

        public int? ParentId { get; set; }

        public int? MenuType { get; set; }

        public bool? IsActive { get; set; }

        public string UrlTarget { get; set; }

        [Column("SortID")]
        public int? SortId { get; set; }

        [Column("SMSTemplateID")]
        public int? SmstemplateId { get; set; }
    }
}