using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Destination.Models.destinationTest
{
    [Table("Bookings", Schema = "dbo")]
    public partial class Booking
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("id")]
        public int Id { get; set; }

        [Column("propertyid")]
        public int? Propertyid { get; set; }

        public Property Property { get; set; }

        [Column("datefrom")]
        public DateTime? Datefrom { get; set; }

        [Column("dateto")]
        public DateTime? Dateto { get; set; }

        [Column("statusid")]
        public int? Statusid { get; set; }

        public BookingStatus BookingStatus { get; set; }

        [Column("notes")]
        public string Notes { get; set; }

        [Column("rentalamount")]
        public double? Rentalamount { get; set; }

        [Column("nights")]
        public int? Nights { get; set; }

        [Column("processingfee")]
        public double? Processingfee { get; set; }

        [Column("petfee")]
        public double? Petfee { get; set; }

        [Column("cleaningfee")]
        public double? Cleaningfee { get; set; }

        [Column("amountdue")]
        public double? Amountdue { get; set; }

        [Column("tax")]
        public double? Tax { get; set; }

        [Column("deposit")]
        public double? Deposit { get; set; }

        [Column("mgtfee")]
        public double? Mgtfee { get; set; }

        [Column("tenantid")]
        public int? Tenantid { get; set; }

        public Tenant Tenant { get; set; }

        [Column("cleaner")]
        public int? Cleaner { get; set; }

        [Column("cleaneramount")]
        public double? Cleaneramount { get; set; }

        [Column("depositreturned")]
        public bool? Depositreturned { get; set; }

        public double? Collected { get; set; }

        [Column("receiptinfo")]
        public string Receiptinfo { get; set; }

        [Column("ccfee")]
        public double? Ccfee { get; set; }

        [Column("method")]
        public string Method { get; set; }

        public double? OwnerPaid { get; set; }

        [Column("guests")]
        public int? Guests { get; set; }

        [Column("bookingdate")]
        public DateTime? Bookingdate { get; set; }

        [Column("grossamount")]
        public double? Grossamount { get; set; }

        [Column("checkin")]
        public string Checkin { get; set; }

        [Column("checkout")]
        public string Checkout { get; set; }

        public double? Petdeposit { get; set; }

        [Column("taxableamount")]
        public double? Taxableamount { get; set; }

        [Column("outstanding")]
        public double? Outstanding { get; set; }

        [Column("duenow")]
        public double? Duenow { get; set; }

        [Column("ownerbooking")]
        public bool? Ownerbooking { get; set; }

        [Column("sourceid")]
        public int? Sourceid { get; set; }

        public PropertySource PropertySource { get; set; }

        [Column("contractrec")]
        public bool? Contractrec { get; set; }

        [Column("samedaycleaning")]
        public string Samedaycleaning { get; set; }

        [Column("inquiry_date")]
        public DateTime? InquiryDate { get; set; }

        [Column("sales_agent")]
        public string SalesAgent { get; set; }

        public string PrebookingNotes { get; set; }

        public string PostbookingNotes { get; set; }

        [Column("remarks")]
        public string Remarks { get; set; }

        [Column("last_updated")]
        public DateTime? LastUpdated { get; set; }

        [Column("cleaningNotes")]
        public string CleaningNotes { get; set; }

        public string SecurityNotes { get; set; }

        [Column("backtoback")]
        public bool? Backtoback { get; set; }

        [Column("cleaningcomp")]
        public bool? Cleaningcomp { get; set; }

        [Column("inspected")]
        public bool? Inspected { get; set; }

        [Column("cleandate")]
        public DateTime? Cleandate { get; set; }

        [Column("inspectedby")]
        public int? Inspectedby { get; set; }

        [Column("inspectdate")]
        public DateTime? Inspectdate { get; set; }

        [Column("returnedamount")]
        public double? Returnedamount { get; set; }

        [Column("depositdate")]
        public DateTime? Depositdate { get; set; }

        [Column("clean_date")]
        public DateTime? CleanDate1 { get; set; }

        [Column("inspect_date")]
        public DateTime? InspectDate1 { get; set; }

        [Column("deposit_date")]
        public DateTime? DepositDate1 { get; set; }

        [Column("cleanercontacted")]
        public bool? Cleanercontacted { get; set; }

        [Column("inspectionnotes")]
        public string Inspectionnotes { get; set; }

        [Column("testoutstanding")]
        public double? Testoutstanding { get; set; }

        [Column("testduenow")]
        public double? Testduenow { get; set; }

        public bool? IsOnlineBooking { get; set; }

        public double? DamageWaiver { get; set; }

        public int? NumberofAdults { get; set; }

        public int? NumberofChildren { get; set; }

        public int? NumberofPets { get; set; }

        public double? OnlinePayment { get; set; }

        [Column("booking_update")]
        public DateTime? BookingUpdate { get; set; }

        public double? OutstandingActual { get; set; }

        public double? OutstandingDiff { get; set; }

        public double? CompFee { get; set; }

        public double? ResortFee { get; set; }

        public DateTime? ClosingDate { get; set; }

        [Column("AffiliateID")]
        public int? AffiliateId { get; set; }

        public string SignatureContent { get; set; }

        public bool? IsCheckIn { get; set; }

        public bool? HoldDeposit { get; set; }

        public decimal? ActualDamageWaiver { get; set; }

        public decimal? ActualDeposit { get; set; }

        public DateTime? CleaningPaidDate { get; set; }

        public bool? Pretalk { get; set; }

        [Column("VRBO")]
        public decimal? Vrbo { get; set; }

        public bool? IsSendForFacebookLeads { get; set; }

        public bool? RateReviewed { get; set; }

        [Column("TempSourceID")]
        public int? TempSourceId { get; set; }

        [Column("ServiceID")]
        public int? ServiceId { get; set; }

        public TblService TblService { get; set; }

        public DateTime? IsRespondComm { get; set; }

        [Column("InspectorTenantID")]
        public int? InspectorTenantId { get; set; }

        public bool? IsCodefinesLink { get; set; }

        public bool? IsMatched { get; set; }

        public DateTime? MatchedOn { get; set; }

        public string MatchedHistory { get; set; }

        public string PaidHistory { get; set; }

        public bool? IsEssentialWorker { get; set; }

        public bool? CityOrdinance { get; set; }

        [Column("CampaignID")]
        public int? CampaignId { get; set; }

        public int? Adults { get; set; }

        public string CheckInPage { get; set; }

        public bool? PhotosReviewed { get; set; }

        public string ConfirmationCode { get; set; }

        [Column("AirbnbThreadID")]
        public string AirbnbThreadId { get; set; }

        public bool? IsSpaCleaned { get; set; }

        public DateTime? SpaCleanedDate { get; set; }

        public string SpaNotes { get; set; }

        public int? SpaLastUpdatedBy { get; set; }

        public string TenantBudget { get; set; }

        [Column("Owner_Type")]
        public string OwnerType { get; set; }

        public int? CheckFlag { get; set; }

        [Column("rentalamountLog")]
        public string RentalamountLog { get; set; }

        public int? UpdatedFlag { get; set; }

        public bool? LateCheckoutApproved { get; set; }

        public bool? PayoutMatched { get; set; }

        public DateTime? CityOrdinanceSignedOn { get; set; }

        public ICollection<AffiliateBooking> AffiliateBookings { get; set; }

        public ICollection<AgreementHistory> AgreementHistories { get; set; }

        public ICollection<AirbnbSendMessage> AirbnbSendMessages { get; set; }

        public ICollection<AppliedPromoCode> AppliedPromoCodes { get; set; }

        public ICollection<BookingHistory> BookingHistories { get; set; }

        public ICollection<CreditRequest> CreditRequests { get; set; }

        public ICollection<GoogleUsersKeyword> GoogleUsersKeywords { get; set; }

        public ICollection<Payment> Payments { get; set; }
    }
}