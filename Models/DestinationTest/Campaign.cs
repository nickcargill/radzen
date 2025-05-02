using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Destination.Models.destinationTest
{
    [Table("Campaign", Schema = "dbo")]
    public partial class Campaign
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("CampaignID")]
        public int CampaignId { get; set; }

        public string CampaignName { get; set; }

        public string Description { get; set; }

        public ICollection<FilterDataForBulkSmsMail> FilterDataForBulkSmsMails { get; set; }
    }
}