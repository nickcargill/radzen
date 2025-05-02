using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Destination.Models.destinationTest
{
    [Table("ChannelPartnerHits", Schema = "dbo")]
    public partial class ChannelPartnerHit
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("ID")]
        public int Id { get; set; }

        [Column("PageURL")]
        public string PageUrl { get; set; }

        public string ChannelPartener { get; set; }

        public DateTime? HitDate { get; set; }

        [Column("PropID")]
        public int? PropId { get; set; }

        public string PageName { get; set; }
    }
}