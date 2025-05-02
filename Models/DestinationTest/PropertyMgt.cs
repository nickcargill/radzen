using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Destination.Models.destinationTest
{
    [Table("Property_mgt", Schema = "dbo")]
    public partial class PropertyMgt
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("id")]
        public int Id { get; set; }

        [Column("propid")]
        public int? Propid { get; set; }

        public Property Property { get; set; }

        public int? RevenueGoal { get; set; }

        public int? HomeQuality { get; set; }

        public int? Relationship { get; set; }

        public int? AssignedResource { get; set; }

        public string Notes { get; set; }

        public DateTime? LastReviewed { get; set; }

        [Column("similiarhome")]
        public int? Similiarhome { get; set; }

        public int? PictureQuality { get; set; }

        public bool? DescriptionPerfect { get; set; }

        public bool? Amenitiesuptodate { get; set; }

        public bool? MainImageGood { get; set; }

        public bool? AllimagesGood { get; set; }

        public bool? DecorationsGood { get; set; }

        public bool? FurnitureandtvsGood { get; set; }

        [Column("AirBNBreviews")]
        public int? AirBnbreviews { get; set; }

        [Column("VRBOReviews")]
        public int? Vrboreviews { get; set; }

        [Column("DBBReviews")]
        public int? Dbbreviews { get; set; }

        public bool? FreeofNegReviews { get; set; }

        public bool? IsExtracted { get; set; }

        [Column("LYTotalRental")]
        public decimal? LytotalRental { get; set; }

        [Column("LYTotalRentalPY")]
        public decimal? LytotalRentalPy { get; set; }

        [Column("LY6MonthsRental")]
        public decimal? Ly6monthsRental { get; set; }

        [Column("LY6MonthsRentalPY")]
        public decimal? Ly6monthsRentalPy { get; set; }

        [Column("LY3MonthsRental")]
        public decimal? Ly3monthsRental { get; set; }

        [Column("LY3MonthsRentalPY")]
        public decimal? Ly3monthsRentalPy { get; set; }

        public decimal? SnapshotRental { get; set; }

        [Column("SnapshotRentalPY")]
        public decimal? SnapshotRentalPy { get; set; }

        [Column("LYTotalCollected")]
        public decimal? LytotalCollected { get; set; }

        [Column("LYTotalCollectedPY")]
        public decimal? LytotalCollectedPy { get; set; }

        [Column("LY6MonthsCollected")]
        public decimal? Ly6monthsCollected { get; set; }

        [Column("LY6MonthsCollectedPY")]
        public decimal? Ly6monthsCollectedPy { get; set; }

        [Column("LY3MonthsCollected")]
        public decimal? Ly3monthsCollected { get; set; }

        [Column("LY3MonthsCollectedPY")]
        public decimal? Ly3monthsCollectedPy { get; set; }

        public decimal? SnapshotCollected { get; set; }

        [Column("SnapshotCollectedPY")]
        public decimal? SnapshotCollectedPy { get; set; }

        [Column("LYTotalMgtFee")]
        public decimal? LytotalMgtFee { get; set; }

        [Column("LYTotalMgtFeePY")]
        public decimal? LytotalMgtFeePy { get; set; }

        [Column("LY6MonthsMgtFee")]
        public decimal? Ly6monthsMgtFee { get; set; }

        [Column("LY6MonthsMgtFeePY")]
        public decimal? Ly6monthsMgtFeePy { get; set; }

        [Column("LY3MonthsMgtFee")]
        public decimal? Ly3monthsMgtFee { get; set; }

        [Column("LY3MonthsMgtFeePY")]
        public decimal? Ly3monthsMgtFeePy { get; set; }

        public decimal? SnapshotMgtFee { get; set; }

        [Column("SnapshotMgtFeePY")]
        public decimal? SnapshotMgtFeePy { get; set; }

        public int? SimilarHomes1 { get; set; }

        public int? SimilarHomes2 { get; set; }

        public bool? YieldWatch { get; set; }

        public bool? OpsWatch { get; set; }

        public DateTime? DescUpdated { get; set; }
    }
}