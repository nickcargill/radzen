using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Destination.Models.destinationTest
{
    [Table("DailyStats", Schema = "dbo")]
    public partial class DailyStat
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("intStatsId")]
        public int IntStatsId { get; set; }

        [Column("intActiveHome")]
        public int? IntActiveHome { get; set; }

        [Column("intPendingHome")]
        public int? IntPendingHome { get; set; }

        [Column("intPendingBooking")]
        public int? IntPendingBooking { get; set; }

        [Column("intCurrentInquiry")]
        public int? IntCurrentInquiry { get; set; }

        [Column("intWorkingBooking")]
        public int? IntWorkingBooking { get; set; }

        [Column("intEmailSent")]
        public int? IntEmailSent { get; set; }

        [Column("intOpenTask")]
        public int? IntOpenTask { get; set; }

        [Column("intHotTask")]
        public int? IntHotTask { get; set; }

        [Column("intMediumTask")]
        public int? IntMediumTask { get; set; }

        [Column("intLowTask")]
        public int? IntLowTask { get; set; }

        [Column("intActionReq")]
        public int? IntActionReq { get; set; }

        [Column("intInboundCalls")]
        public int? IntInboundCalls { get; set; }

        [Column("intOutBoundCalls")]
        public int? IntOutBoundCalls { get; set; }

        [Column("intUniqueVisitors")]
        public int? IntUniqueVisitors { get; set; }

        [Column("intVisitors")]
        public int? IntVisitors { get; set; }

        [Column("intPageViews")]
        public int? IntPageViews { get; set; }

        [Column("dtCreated")]
        public DateTime? DtCreated { get; set; }

        public int? Booked { get; set; }

        public double? BookedDollar { get; set; }

        public int? ClosedBooking { get; set; }

        [Column("ownerDollar")]
        public double? OwnerDollar { get; set; }

        [Column("managementdollar")]
        public double? Managementdollar { get; set; }

        [Column("bouncerate")]
        public int? Bouncerate { get; set; }
    }
}