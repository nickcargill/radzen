using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Destination.Models.destinationTest
{
    [Table("AffiliateCollaboration", Schema = "dbo")]
    public partial class AffiliateCollaboration
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("ID")]
        public int Id { get; set; }

        [Column("HostID")]
        public int? HostId { get; set; }

        [Column("StayID")]
        public int? StayId { get; set; }

        [Column("status")]
        public string Status { get; set; }

        [Column("datefrom")]
        public string Datefrom { get; set; }

        [Column("dateto")]
        public string Dateto { get; set; }

        [Column("nights")]
        public int? Nights { get; set; }

        [Column("notes")]
        public string Notes { get; set; }

        public bool? HomeOwnerNotified { get; set; }

        public bool? InfluencerConfirmationEmail { get; set; }

        public bool? LocalPartners { get; set; }

        public string PartnerNotes { get; set; }

        public bool? BookingDepartmentNotified { get; set; }

        public bool? MediaReceived { get; set; }

        public bool? BlogCreated { get; set; }

        public bool? ConstantContactSent { get; set; }

        public bool? BookingChangedBackToOwnerBooking { get; set; }

        public bool? HomeownerReceivedEmail { get; set; }

        public string MediaLink { get; set; }

        public string Assets { get; set; }

        public string BlogPage { get; set; }

        public DateTime? LastTouched { get; set; }

        public string Heat { get; set; }

        public string BookingNum { get; set; }
    }
}