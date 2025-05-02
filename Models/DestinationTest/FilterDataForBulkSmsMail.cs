using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Destination.Models.destinationTest
{
    [Table("FilterDataForBulkSmsMail", Schema = "dbo")]
    public partial class FilterDataForBulkSmsMail
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("ID")]
        public int Id { get; set; }

        [Column("IsSMSOrEmail")]
        public int? IsSmsorEmail { get; set; }

        [Column("StatusID")]
        public int? StatusId { get; set; }

        public BookingStatus BookingStatus { get; set; }

        [Column("SourceID")]
        public int? SourceId { get; set; }

        public PropertySource PropertySource { get; set; }

        public DateTime? InquiryDateFrom { get; set; }

        public DateTime? InquiryDateTo { get; set; }

        public DateTime? BookedDateFrom { get; set; }

        public DateTime? BookedDateTo { get; set; }

        public decimal? Outstanding { get; set; }

        public DateTime? LastUpdatedFrom { get; set; }

        public DateTime? LastUpdatedTo { get; set; }

        public DateTime? DateFrom1 { get; set; }

        public DateTime? DateFrom2 { get; set; }

        public DateTime? DateTo1 { get; set; }

        public DateTime? Dateto2 { get; set; }

        public decimal? AmountDueFrom { get; set; }

        public decimal? AmountDueTo { get; set; }

        public decimal? RentalAmountFrom { get; set; }

        public decimal? RentalAmountTo { get; set; }

        public int? BackToBack { get; set; }

        [Column("CampaignID")]
        public int? CampaignId { get; set; }

        public Campaign Campaign { get; set; }

        [Column("PropID")]
        public int? PropId { get; set; }

        public Property Property { get; set; }

        public string Beds { get; set; }

        public string Baths { get; set; }

        public int? Occupancy { get; set; }

        public int? Spa { get; set; }

        public int? LakeView { get; set; }

        public int? GameTable { get; set; }

        public int? NearLake { get; set; }

        public int? Pets { get; set; }

        public int? NearSnowSummit { get; set; }

        public int? Lakefront { get; set; }

        public int? NearBearMtn { get; set; }

        public int? Internet { get; set; }

        public int? NearVillage { get; set; }

        public int? Luxury { get; set; }

        public int? Discounted { get; set; }

        public int? CleaningStatus { get; set; }

        public int? EliminateOfficeCheckins { get; set; }

        public int? TemplateCategory { get; set; }

        [Column("TemplateID")]
        public int? TemplateId { get; set; }

        public Template Template { get; set; }

        public string SentTo { get; set; }

        public DateTime? SentOn { get; set; }
    }
}