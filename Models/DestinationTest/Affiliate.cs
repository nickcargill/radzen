using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Destination.Models.destinationTest
{
    [Table("Affiliates", Schema = "dbo")]
    public partial class Affiliate
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("AffiliateID")]
        public int AffiliateId { get; set; }

        public string Name { get; set; }

        public string Phone { get; set; }

        public string Address { get; set; }

        public string Website { get; set; }

        public string Email { get; set; }

        public string Password { get; set; }

        public bool IsVerified { get; set; }

        public string Status { get; set; }

        public DateTime CreatedOn { get; set; }

        public string AffiliateCode { get; set; }

        public string FindCabinContent { get; set; }

        [Column("AgentID")]
        public int? AgentId { get; set; }

        public string Type { get; set; }

        public string City { get; set; }

        public string State { get; set; }

        public string Zip { get; set; }

        public DateTime? LastTouched { get; set; }

        public string Notes { get; set; }

        public string PrimaryRepresentative { get; set; }

        public string Priority { get; set; }

        public bool? Local { get; set; }

        public string InstagramHandle { get; set; }

        public string InstagramFollowers { get; set; }

        [Column("FacebookURL")]
        public string FacebookUrl { get; set; }

        public string FacebookFollowers { get; set; }

        public string TiktokHandle { get; set; }

        public string YoutubeChannel { get; set; }

        public string YoutubeSubscribers { get; set; }

        public string LinkingPage { get; set; }

        [Column("PropID")]
        public int? PropId { get; set; }

        public bool? Collaboration { get; set; }

        public bool? GiveAway { get; set; }

        public string WebsiteAuthority { get; set; }

        public string HomepageMsg1 { get; set; }

        public string HomepageMsg2 { get; set; }

        public string MsgLink { get; set; }

        public string Market { get; set; }

        public string Title { get; set; }

        public string ShortDescription { get; set; }

        public int? TiktokFollowers { get; set; }

        public int? CustomSort { get; set; }

        public bool? NotInterested { get; set; }

        public bool? PaidOnly { get; set; }

        public bool? DoNotWorkWith { get; set; }

        public ICollection<AffiliateBooking> AffiliateBookings { get; set; }
    }
}