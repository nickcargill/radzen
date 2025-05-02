using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Destination.Models.destinationTest
{
    [Table("tblBulkEmailLog", Schema = "dbo")]
    public partial class TblBulkEmailLog
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("ID")]
        public int Id { get; set; }

        [Column("IsSMSOrEmail")]
        public int? IsSmsorEmail { get; set; }

        public int? TotalEmails { get; set; }

        [Column("StatusID")]
        public int? StatusId { get; set; }

        public string Status { get; set; }

        public bool? EverythingButStatus { get; set; }

        [Column("SourceID")]
        public int? SourceId { get; set; }

        public bool? EverythingButSource { get; set; }

        public DateTime? InquiryDateFrom { get; set; }

        public DateTime? InquiryDateTo { get; set; }

        [Column("TemplateID")]
        public int? TemplateId { get; set; }

        public DateTime? SentOn { get; set; }

        public DateTime? DateFrom1 { get; set; }

        public DateTime? DateFrom2 { get; set; }

        public DateTime? DateTo1 { get; set; }

        public DateTime? DateTo2 { get; set; }

        public DateTime? BookedDateFrom { get; set; }

        public DateTime? BookedDateTo { get; set; }

        public string Outstanding1 { get; set; }

        public string Outstanding2 { get; set; }

        public DateTime? LastUpdatedFrom { get; set; }

        public DateTime? LastUpdatedTo { get; set; }

        public string AmountDueFrom { get; set; }

        public string AmountDueTo { get; set; }

        public string RentalAmountFrom { get; set; }

        public string RentalAmountTo { get; set; }

        public int? BackToBack { get; set; }

        public int? CityOrdinance { get; set; }

        [Column("CampaignID")]
        public int? CampaignId { get; set; }

        public int? Guests1 { get; set; }

        public int? Guests2 { get; set; }

        public bool? NoHots { get; set; }

        [Column("PropID")]
        public int? PropId { get; set; }

        public string Beds { get; set; }

        public string Baths { get; set; }

        public int? Occupancy { get; set; }

        public string City { get; set; }

        public bool? EverythingButCity { get; set; }

        public bool? NoAlarm { get; set; }

        public string Neighborhood { get; set; }

        public bool? Spa { get; set; }

        public bool? LakeView { get; set; }

        public bool? GameTable { get; set; }

        public bool? NearLake { get; set; }

        public bool? Pets { get; set; }

        public bool? NearSnowSummit { get; set; }

        public bool? LakeFront { get; set; }

        public bool? NearBearMtn { get; set; }

        public bool? Internet { get; set; }

        public bool? NearVillage { get; set; }

        public bool? Luxury { get; set; }

        public bool? Discounted { get; set; }

        public bool? Cleaned { get; set; }

        public bool? NotCleaned { get; set; }

        public bool? EliminateOfficeCheckins { get; set; }

        [Column("InterestID")]
        public int? InterestId { get; set; }

        public bool? NoEmails { get; set; }

        public int? TemplateCategory { get; set; }

        public string SentTo { get; set; }

        public bool? IsSavedFilters { get; set; }

        public string FilterName { get; set; }

        public string OperatingOn { get; set; }

        public int? PropertyStatus { get; set; }

        public bool? CheckedIn { get; set; }

        public string Operand2 { get; set; }

        public string Operator { get; set; }

        public bool? EveryYear { get; set; }

        public int? RevenueGoal { get; set; }

        public int? PhotosReviewed { get; set; }
    }
}