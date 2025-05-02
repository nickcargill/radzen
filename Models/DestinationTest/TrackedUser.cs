using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Destination.Models.destinationTest
{
    [Table("TrackedUsers", Schema = "dbo")]
    public partial class TrackedUser
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("ID")]
        public int Id { get; set; }

        [Column("BookingID")]
        public int? BookingId { get; set; }

        [Column("TenantID")]
        public int? TenantId { get; set; }

        public DateTime? VisitedOn { get; set; }

        [Column("PropID")]
        public int? PropId { get; set; }

        public DateTime? FromDate { get; set; }

        public DateTime? ToDate { get; set; }

        public string PageUrl { get; set; }

        [Column("IPAddress")]
        public string Ipaddress { get; set; }

        [Column("TemplateID")]
        public int? TemplateId { get; set; }

        public bool? FromBulk { get; set; }

        [Column("BulkEmailID")]
        public int? BulkEmailId { get; set; }

        [Column("CampaignID")]
        public int? CampaignId { get; set; }

        [Column("AffID")]
        public int? AffId { get; set; }

        [Column("InterestID")]
        public int? InterestId { get; set; }

        public int? Sleeps { get; set; }

        public string Bedrooms { get; set; }

        [Column("clog")]
        public string Clog { get; set; }
    }
}