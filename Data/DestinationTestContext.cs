using System;
using System.Linq;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Destination.Models.destinationTest;
using Destination.Shared.DTO;
using System.Reflection.Emit;

namespace Destination.Data
{
    public partial class destinationTestContext : DbContext
    {
        public destinationTestContext()
        {
        }

        public destinationTestContext(DbContextOptions<destinationTestContext> options) : base(options)
        {
        }

        partial void OnModelBuilding(ModelBuilder builder);

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder.Entity<Destination.Models.destinationTest.AffiliatesDatum>().HasNoKey();

            builder.Entity<Destination.Models.destinationTest.AirbnbApiAutoSyncContent>().HasNoKey();

            builder.Entity<Destination.Models.destinationTest.AirbnbApicredential>().HasNoKey();

            builder.Entity<Destination.Models.destinationTest.AirbnbApireservationsJson>().HasNoKey();

            builder.Entity<Destination.Models.destinationTest.AirbnbIcalsUpdateTracking>().HasNoKey();

            builder.Entity<Destination.Models.destinationTest.AirbnbMessage>().HasNoKey();

            builder.Entity<PropertyImprovementDto>().HasNoKey().ToView(null);

            builder.Entity<PropertyAnnualLogDto>().HasNoKey().ToView(null);

            builder.Entity<Destination.Models.destinationTest.AirbnbUploadedPhoto>().HasNoKey();

            builder.Entity<Destination.Models.destinationTest.Annual>().HasNoKey();

            builder.Entity<Destination.Models.destinationTest.BookingStatus1>().HasNoKey();

            builder.Entity<Destination.Models.destinationTest.BookingEmailSetting>().HasNoKey();

            builder.Entity<Destination.Models.destinationTest.BookingsVisited>().HasNoKey();

            builder.Entity<Destination.Models.destinationTest.BookingsLargeGroup>().HasNoKey();

            builder.Entity<Destination.Models.destinationTest.BulkSmstest>().HasNoKey();

            builder.Entity<Destination.Models.destinationTest.BulkSmstest1>().HasNoKey();

            builder.Entity<Destination.Models.destinationTest.ChannelBu>().HasNoKey();

            builder.Entity<Destination.Models.destinationTest.ChannelPartnerHit>().HasNoKey();

            builder.Entity<Destination.Models.destinationTest.ChatBotKeywordMaster>().HasNoKey();

            builder.Entity<Destination.Models.destinationTest.ChatBotMenuMaster>().HasNoKey();

            builder.Entity<Destination.Models.destinationTest.CheckInLog>().HasNoKey();

            builder.Entity<Destination.Models.destinationTest.CleanerAuditedMsg>().HasNoKey();

            builder.Entity<Destination.Models.destinationTest.CleanerGroup>().HasNoKey();

            builder.Entity<Destination.Models.destinationTest.CleanerInvoiceMatchedDatum>().HasNoKey();

            builder.Entity<Destination.Models.destinationTest.CleanerNo>().HasNoKey();

            builder.Entity<Destination.Models.destinationTest.CleaningPayrolExtraTaskDetail>().HasNoKey();

            builder.Entity<Destination.Models.destinationTest.CoronaAnnualDatum>().HasNoKey();

            builder.Entity<Destination.Models.destinationTest.CriticalTaskWarning>().HasNoKey();

            builder.Entity<Destination.Models.destinationTest.CurrentDiscountsHistory>().HasNoKey();

            builder.Entity<Destination.Models.destinationTest.DeletedGapHolderBooking>().HasNoKey();

            builder.Entity<Destination.Models.destinationTest.DepositHoldLog>().HasNoKey();

            builder.Entity<Destination.Models.destinationTest.DoNotRent>().HasNoKey();

            builder.Entity<Destination.Models.destinationTest.FinalDatum>().HasNoKey();

            builder.Entity<Destination.Models.destinationTest.GuestCodeCall>().HasNoKey();

            builder.Entity<Destination.Models.destinationTest.HotHome>().HasNoKey();

            builder.Entity<Destination.Models.destinationTest.HouseRule>().HasNoKey();

            builder.Entity<Destination.Models.destinationTest.LandingPage>().HasNoKey();

            builder.Entity<Destination.Models.destinationTest.LargeGroupBooking>().HasNoKey();

            builder.Entity<Destination.Models.destinationTest.LogDoorCodes2020>().HasNoKey();

            builder.Entity<Destination.Models.destinationTest.OffhoursListForSmsroutine>().HasNoKey();

            builder.Entity<Destination.Models.destinationTest.OpinionStageSurveyLeadsRepor>().HasNoKey();

            builder.Entity<Destination.Models.destinationTest.OwnerUpdate>().HasNoKey();

            builder.Entity<Destination.Models.destinationTest.PaymentLogDoubleRefunded>().HasNoKey();

            builder.Entity<Destination.Models.destinationTest.Permit>().HasNoKey();

            builder.Entity<Destination.Models.destinationTest.PhoneCallLog>().HasNoKey();

            builder.Entity<Destination.Models.destinationTest.ProcGetLastBookingDetail>().HasNoKey();

            builder.Entity<Destination.Models.destinationTest.Promotion>().HasNoKey();

            builder.Entity<Destination.Models.destinationTest.PropertyExpenseBlankRecord>().HasNoKey();

            builder.Entity<Destination.Models.destinationTest.PropertyExpensesDeleted>().HasNoKey();

            builder.Entity<Destination.Models.destinationTest.PropertyLastNextBookingDetail>().HasNoKey();

            builder.Entity<Destination.Models.destinationTest.PropertyAnnualLog>().HasNoKey();

            builder.Entity<Destination.Models.destinationTest.PropertyFulltime>().HasNoKey();

            builder.Entity<Destination.Models.destinationTest.PropertyInsurance>().HasNoKey();

            builder.Entity<Destination.Models.destinationTest.PropertyInsuranceCity>().HasNoKey();

            builder.Entity<Destination.Models.destinationTest.PropertyInsuranceCounty>().HasNoKey();

            builder.Entity<Destination.Models.destinationTest.PropertyRatesDailySingleProp>().HasNoKey();

            builder.Entity<Destination.Models.destinationTest.Restriction>().HasNoKey();

            builder.Entity<Destination.Models.destinationTest.Sample23>().HasNoKey();

            builder.Entity<Destination.Models.destinationTest.SendAirbnbCheckOutReply>().HasNoKey();

            builder.Entity<Destination.Models.destinationTest.SendTwilioSmsQueue>().HasNoKey();

            builder.Entity<Destination.Models.destinationTest.Sheet1>().HasNoKey();

            builder.Entity<Destination.Models.destinationTest.Sheet2>().HasNoKey();

            builder.Entity<Destination.Models.destinationTest.SmsRemoveList>().HasNoKey();

            builder.Entity<Destination.Models.destinationTest.SmstemplateArea>().HasNoKey();

            builder.Entity<Destination.Models.destinationTest.SnowRemoval>().HasNoKey();

            builder.Entity<Destination.Models.destinationTest.TblBookingIdsForMail>().HasNoKey();

            builder.Entity<Destination.Models.destinationTest.TblChkSm>().HasNoKey();

            builder.Entity<Destination.Models.destinationTest.TblDebug>().HasNoKey();

            builder.Entity<Destination.Models.destinationTest.TblHomePageImagesLink>().HasNoKey();

            builder.Entity<Destination.Models.destinationTest.TblPartialCheckIn>().HasNoKey();

            builder.Entity<Destination.Models.destinationTest.TblTrackDailyRatesExecutionForProperty>().HasNoKey();

            builder.Entity<Destination.Models.destinationTest.Temp12>().HasNoKey();

            builder.Entity<Destination.Models.destinationTest.TempCom>().HasNoKey();

            builder.Entity<Destination.Models.destinationTest.TenantCheckInPhoto>().HasNoKey();

            builder.Entity<Destination.Models.destinationTest.TenantInterestDatum>().HasNoKey();

            builder.Entity<Destination.Models.destinationTest.TenantSheet>().HasNoKey();

            builder.Entity<Destination.Models.destinationTest.TenantWithPlusOneInCell>().HasNoKey();

            builder.Entity<Destination.Models.destinationTest.TestTable>().HasNoKey();

            builder.Entity<Destination.Models.destinationTest.UpdateRateHome>().HasNoKey();

            builder.Entity<Destination.Models.destinationTest.UvGetBackToBackCheckInsPerDay>().HasNoKey();

            builder.Entity<Destination.Models.destinationTest.UvGetBookingBackToBackCount>().HasNoKey();

            builder.Entity<Destination.Models.destinationTest.UvGetBooking>().HasNoKey();

            builder.Entity<Destination.Models.destinationTest.UvGetTotalCheckInsPerDay>().HasNoKey();

            builder.Entity<Destination.Models.destinationTest.VRecord>().HasNoKey();

            builder.Entity<Destination.Models.destinationTest.ViewRevenue>().HasNoKey();

            builder.Entity<Destination.Models.destinationTest.VoiceMail>().HasNoKey();

            builder.Entity<Destination.Models.destinationTest.VrboErrorLogForBookingRequest>().HasNoKey();

            builder.Entity<Destination.Models.destinationTest.VwCleanedStatusCheckOutToday>().HasNoKey();

            builder.Entity<Destination.Models.destinationTest.VwCurrentlyOccupied>().HasNoKey();

            builder.Entity<Destination.Models.destinationTest.VwFutureBooking>().HasNoKey();

            builder.Entity<Destination.Models.destinationTest.VwGetCommMax>().HasNoKey();

            builder.Entity<Destination.Models.destinationTest.VwGetMinuteDifference>().HasNoKey();

            builder.Entity<Destination.Models.destinationTest.VwGetTrackedUser>().HasNoKey();

            builder.Entity<Destination.Models.destinationTest.VwGetAirbnbDepositsInfo>().HasNoKey();

            builder.Entity<Destination.Models.destinationTest.VwGetAllPropertyStatus>().HasNoKey();

            builder.Entity<Destination.Models.destinationTest.VwGetClosestBookingWithCleaningStatus>().HasNoKey();

            builder.Entity<Destination.Models.destinationTest.VwGetclosestwithCleaner>().HasNoKey();

            builder.Entity<Destination.Models.destinationTest.VwGetclosestwithDate>().HasNoKey();

            builder.Entity<Destination.Models.destinationTest.VwGetCommMax1>().HasNoKey();

            builder.Entity<Destination.Models.destinationTest.VwGetDoorCodeLog>().HasNoKey();

            builder.Entity<Destination.Models.destinationTest.VwGetInquiryDatesForBookingsDashboardQuery>().HasNoKey();

            builder.Entity<Destination.Models.destinationTest.VwGetInspectionDateMgtForAllActiveProp>().HasNoKey();

            builder.Entity<Destination.Models.destinationTest.VwGetlast3MonthsTotal>().HasNoKey();

            builder.Entity<Destination.Models.destinationTest.VwGetlast3MonthsTotalPy>().HasNoKey();

            builder.Entity<Destination.Models.destinationTest.VwGetlast6MonthsTotal>().HasNoKey();

            builder.Entity<Destination.Models.destinationTest.VwGetlast6MonthsTotalPy>().HasNoKey();

            builder.Entity<Destination.Models.destinationTest.VwGetLastCleanedDateForAllActiveProp>().HasNoKey();

            builder.Entity<Destination.Models.destinationTest.VwGetLastCleaner>().HasNoKey();

            builder.Entity<Destination.Models.destinationTest.VwGetLastDateCompletedFromExpense>().HasNoKey();

            builder.Entity<Destination.Models.destinationTest.VwGetLastInspectedDateForAllActiveProp>().HasNoKey();

            builder.Entity<Destination.Models.destinationTest.VwGetLastRateChanged>().HasNoKey();

            builder.Entity<Destination.Models.destinationTest.VwGetlastyearTotal>().HasNoKey();

            builder.Entity<Destination.Models.destinationTest.VwGetlastyearTotalPy>().HasNoKey();

            builder.Entity<Destination.Models.destinationTest.VwGetNetSum>().HasNoKey();

            builder.Entity<Destination.Models.destinationTest.VwGetNextBooking>().HasNoKey();

            builder.Entity<Destination.Models.destinationTest.VwGetNextOwnerBooking>().HasNoKey();

            builder.Entity<Destination.Models.destinationTest.VwGetPropClosestDatewithCleaner>().HasNoKey();

            builder.Entity<Destination.Models.destinationTest.VwGetPropertiesWithoutSpace>().HasNoKey();

            builder.Entity<Destination.Models.destinationTest.VwGetPropertyExpense>().HasNoKey();

            builder.Entity<Destination.Models.destinationTest.VwGetPropertyStatus>().HasNoKey();

            builder.Entity<Destination.Models.destinationTest.VwGetPropertyStatusOnlyMaintenanceDept>().HasNoKey();

            builder.Entity<Destination.Models.destinationTest.VwGetPropListWithControlLog>().HasNoKey();

            builder.Entity<Destination.Models.destinationTest.VwGetPropReviewCount>().HasNoKey();

            builder.Entity<Destination.Models.destinationTest.VwGetPrpertiesHotOpen>().HasNoKey();

            builder.Entity<Destination.Models.destinationTest.VwGetSnapshotTotal>().HasNoKey();

            builder.Entity<Destination.Models.destinationTest.VwGetSnapshotTotalPy>().HasNoKey();

            builder.Entity<Destination.Models.destinationTest.VwGetTotalBkngsForBookingsDashboardQuery>().HasNoKey();

            builder.Entity<Destination.Models.destinationTest.VwGetTotalExpense>().HasNoKey();

            builder.Entity<Destination.Models.destinationTest.VwGetTotalExpensesOnlyMaintenanceDept>().HasNoKey();

            builder.Entity<Destination.Models.destinationTest.VwGetTotalExpensesFiltered>().HasNoKey();

            builder.Entity<Destination.Models.destinationTest.VwGetTotalInquiriesForBookingsDashboardQuery>().HasNoKey();

            builder.Entity<Destination.Models.destinationTest.VwGetTrackedUser1>().HasNoKey();

            builder.Entity<Destination.Models.destinationTest.VwGetUniqueTenant>().HasNoKey();

            builder.Entity<Destination.Models.destinationTest.VwGetWorkingBooking>().HasNoKey();

            builder.Entity<Destination.Models.destinationTest.VwGetYearWiseTotal>().HasNoKey();

            builder.Entity<Destination.Models.destinationTest.VwLastBookedOn>().HasNoKey();

            builder.Entity<Destination.Models.destinationTest.VwLastDateChangedOfLockBox>().HasNoKey();

            builder.Entity<Destination.Models.destinationTest.VwLastDoorCodeChangedPerProperty>().HasNoKey();

            builder.Entity<Destination.Models.destinationTest.VwLastRecordedOwnerCommunication>().HasNoKey();

            builder.Entity<Destination.Models.destinationTest.VwMaintenanceNextDateFrom>().HasNoKey();

            builder.Entity<Destination.Models.destinationTest.VwNetPayment>().HasNoKey();

            builder.Entity<Destination.Models.destinationTest.VwPaymentSummary>().HasNoKey();

            builder.Entity<Destination.Models.destinationTest.VwPropertyOccupiedStatus>().HasNoKey();

            builder.Entity<Destination.Models.destinationTest.VwRptGetLastCleaned>().HasNoKey();

            builder.Entity<Destination.Models.destinationTest.VwSpringCleaning>().HasNoKey();

            builder.Entity<Destination.Models.destinationTest.VwSumPropertyExpense>().HasNoKey();

            builder.Entity<Destination.Models.destinationTest.VwTenantCount>().HasNoKey();

            builder.Entity<Destination.Models.destinationTest.VwUnbalanced>().HasNoKey();

            builder.Entity<Destination.Models.destinationTest.WebPageTemplate>().HasNoKey();

            builder.Entity<Destination.Models.destinationTest.RdzVwGet2024Booking>().HasNoKey();

            builder.Entity<Destination.Models.destinationTest.AffiliateBooking>()
              .HasOne(i => i.Affiliate)
              .WithMany(i => i.AffiliateBookings)
              .HasForeignKey(i => i.AffiliateId)
              .HasPrincipalKey(i => i.AffiliateId);

            builder.Entity<Destination.Models.destinationTest.AffiliateBooking>()
              .HasOne(i => i.Booking)
              .WithMany(i => i.AffiliateBookings)
              .HasForeignKey(i => i.BookingId)
              .HasPrincipalKey(i => i.Id);

            builder.Entity<Destination.Models.destinationTest.AgreementHistory>()
              .HasOne(i => i.Booking)
              .WithMany(i => i.AgreementHistories)
              .HasForeignKey(i => i.BookingId)
              .HasPrincipalKey(i => i.Id);

            builder.Entity<Destination.Models.destinationTest.AirbnbSendMessage>()
              .HasOne(i => i.Booking)
              .WithMany(i => i.AirbnbSendMessages)
              .HasForeignKey(i => i.BookingId)
              .HasPrincipalKey(i => i.Id);

            builder.Entity<Destination.Models.destinationTest.AnnualSurvey>()
              .HasOne(i => i.Property)
              .WithMany(i => i.AnnualSurveys)
              .HasForeignKey(i => i.PropId)
              .HasPrincipalKey(i => i.Propid);

            builder.Entity<Destination.Models.destinationTest.AppliedPromoCode>()
              .HasOne(i => i.Booking)
              .WithMany(i => i.AppliedPromoCodes)
              .HasForeignKey(i => i.BookingId)
              .HasPrincipalKey(i => i.Id);

            builder.Entity<Destination.Models.destinationTest.BookingHistory>()
              .HasOne(i => i.Booking)
              .WithMany(i => i.BookingHistories)
              .HasForeignKey(i => i.IntBookingId)
              .HasPrincipalKey(i => i.Id);

            builder.Entity<Destination.Models.destinationTest.Booking>()
              .HasOne(i => i.Property)
              .WithMany(i => i.Bookings)
              .HasForeignKey(i => i.Propertyid)
              .HasPrincipalKey(i => i.Propid);

            builder.Entity<Destination.Models.destinationTest.Booking>()
              .HasOne(i => i.TblService)
              .WithMany(i => i.Bookings)
              .HasForeignKey(i => i.ServiceId)
              .HasPrincipalKey(i => i.Id);

            builder.Entity<Destination.Models.destinationTest.Booking>()
              .HasOne(i => i.PropertySource)
              .WithMany(i => i.Bookings)
              .HasForeignKey(i => i.Sourceid)
              .HasPrincipalKey(i => i.Id);

            builder.Entity<Destination.Models.destinationTest.Booking>()
              .HasOne(i => i.BookingStatus)
              .WithMany(i => i.Bookings)
              .HasForeignKey(i => i.Statusid)
              .HasPrincipalKey(i => i.Id);

            builder.Entity<Destination.Models.destinationTest.Booking>()
              .HasOne(i => i.Tenant)
              .WithMany(i => i.Bookings)
              .HasForeignKey(i => i.Tenantid)
              .HasPrincipalKey(i => i.Tenantid);

            builder.Entity<Destination.Models.destinationTest.BookingsLogic>()
              .HasOne(i => i.Property)
              .WithMany(i => i.BookingsLogics)
              .HasForeignKey(i => i.IntPropId)
              .HasPrincipalKey(i => i.Propid);

            builder.Entity<Destination.Models.destinationTest.Channel>()
              .HasOne(i => i.Property)
              .WithMany(i => i.Channels)
              .HasForeignKey(i => i.Propid)
              .HasPrincipalKey(i => i.Propid);

            builder.Entity<Destination.Models.destinationTest.CreditRequest>()
              .HasOne(i => i.Booking)
              .WithMany(i => i.CreditRequests)
              .HasForeignKey(i => i.BookingId)
              .HasPrincipalKey(i => i.Id);

            builder.Entity<Destination.Models.destinationTest.Currentdiscount>()
              .HasOne(i => i.Property)
              .WithMany(i => i.Currentdiscounts)
              .HasForeignKey(i => i.Propid)
              .HasPrincipalKey(i => i.Propid);

            builder.Entity<Destination.Models.destinationTest.DailyRatesBasedOnPropertyRate>()
              .HasOne(i => i.Property)
              .WithMany(i => i.DailyRatesBasedOnPropertyRates)
              .HasForeignKey(i => i.PropId)
              .HasPrincipalKey(i => i.Propid);

            builder.Entity<Destination.Models.destinationTest.FilterDataForBulkSmsMail>()
              .HasOne(i => i.Campaign)
              .WithMany(i => i.FilterDataForBulkSmsMails)
              .HasForeignKey(i => i.CampaignId)
              .HasPrincipalKey(i => i.CampaignId);

            builder.Entity<Destination.Models.destinationTest.FilterDataForBulkSmsMail>()
              .HasOne(i => i.Property)
              .WithMany(i => i.FilterDataForBulkSmsMails)
              .HasForeignKey(i => i.PropId)
              .HasPrincipalKey(i => i.Propid);

            builder.Entity<Destination.Models.destinationTest.FilterDataForBulkSmsMail>()
              .HasOne(i => i.PropertySource)
              .WithMany(i => i.FilterDataForBulkSmsMails)
              .HasForeignKey(i => i.SourceId)
              .HasPrincipalKey(i => i.Id);

            builder.Entity<Destination.Models.destinationTest.FilterDataForBulkSmsMail>()
              .HasOne(i => i.BookingStatus)
              .WithMany(i => i.FilterDataForBulkSmsMails)
              .HasForeignKey(i => i.StatusId)
              .HasPrincipalKey(i => i.Id);

            builder.Entity<Destination.Models.destinationTest.FilterDataForBulkSmsMail>()
              .HasOne(i => i.Template)
              .WithMany(i => i.FilterDataForBulkSmsMails)
              .HasForeignKey(i => i.TemplateId)
              .HasPrincipalKey(i => i.IntTemplateId);

            builder.Entity<Destination.Models.destinationTest.GoogleUsersKeyword>()
              .HasOne(i => i.Booking)
              .WithMany(i => i.GoogleUsersKeywords)
              .HasForeignKey(i => i.BookingId)
              .HasPrincipalKey(i => i.Id);

            builder.Entity<Destination.Models.destinationTest.MarketingReview>()
              .HasOne(i => i.Property)
              .WithMany(i => i.MarketingReviews)
              .HasForeignKey(i => i.Propid)
              .HasPrincipalKey(i => i.Propid);

            builder.Entity<Destination.Models.destinationTest.MenuManagement>()
              .HasOne(i => i.MenuMaster)
              .WithMany(i => i.MenuManagements)
              .HasForeignKey(i => i.MenuId)
              .HasPrincipalKey(i => i.Id);

            builder.Entity<Destination.Models.destinationTest.OwnerCommunication>()
              .HasOne(i => i.Agent1)
              .WithMany(i => i.OwnerCommunications)
              .HasForeignKey(i => i.Ownerid)
              .HasPrincipalKey(i => i.AgId);

            builder.Entity<Destination.Models.destinationTest.Payment>()
              .HasOne(i => i.Booking)
              .WithMany(i => i.Payments)
              .HasForeignKey(i => i.IntBookingId)
              .HasPrincipalKey(i => i.Id);

            builder.Entity<Destination.Models.destinationTest.Performa>()
              .HasOne(i => i.Property)
              .WithMany(i => i.Performas)
              .HasForeignKey(i => i.PropId)
              .HasPrincipalKey(i => i.Propid);

            builder.Entity<Destination.Models.destinationTest.PromoCode>()
              .HasOne(i => i.Property)
              .WithMany(i => i.PromoCodes)
              .HasForeignKey(i => i.PropId)
              .HasPrincipalKey(i => i.Propid);

            builder.Entity<Destination.Models.destinationTest.Property>()
              .HasOne(i => i.Agent)
              .WithMany(i => i.Properties)
              .HasForeignKey(i => i.Agentid)
              .HasPrincipalKey(i => i.AgId);

            builder.Entity<Destination.Models.destinationTest.Property>()
              .HasOne(i => i.PropertyCleaner)
              .WithMany(i => i.Properties)
              .HasForeignKey(i => i.Cleanerassigned)
              .HasPrincipalKey(i => i.Cleanerid);

            builder.Entity<Destination.Models.destinationTest.Property>()
              .HasOne(i => i.Status1)
              .WithMany(i => i.Properties)
              .HasForeignKey(i => i.Status)
              .HasPrincipalKey(i => i.Statusid);

            builder.Entity<Destination.Models.destinationTest.PropertyBed>()
              .HasOne(i => i.Property)
              .WithMany(i => i.PropertyBeds)
              .HasForeignKey(i => i.PropId)
              .HasPrincipalKey(i => i.Propid);

            builder.Entity<Destination.Models.destinationTest.PropertyExpense>()
              .HasOne(i => i.Property)
              .WithMany(i => i.PropertyExpenses)
              .HasForeignKey(i => i.Propid)
              .HasPrincipalKey(i => i.Propid);

            builder.Entity<Destination.Models.destinationTest.PropertyImprovement>()
              .HasOne(i => i.Property)
              .WithMany(i => i.PropertyImprovements)
              .HasForeignKey(i => i.Propid)
              .HasPrincipalKey(i => i.Propid);

            builder.Entity<Destination.Models.destinationTest.PropertyMgt>()
              .HasOne(i => i.Property)
              .WithMany(i => i.PropertyMgts)
              .HasForeignKey(i => i.Propid)
              .HasPrincipalKey(i => i.Propid);

            builder.Entity<Destination.Models.destinationTest.PropertyRate>()
              .HasOne(i => i.Property)
              .WithMany(i => i.PropertyRates)
              .HasForeignKey(i => i.Propid)
              .HasPrincipalKey(i => i.Propid);

            builder.Entity<Destination.Models.destinationTest.PropertyRatesVrbo>()
              .HasOne(i => i.Property)
              .WithMany(i => i.PropertyRatesVrbos)
              .HasForeignKey(i => i.Propid)
              .HasPrincipalKey(i => i.Propid);

            builder.Entity<Destination.Models.destinationTest.PropertyWarning>()
              .HasOne(i => i.Property)
              .WithMany(i => i.PropertyWarnings)
              .HasForeignKey(i => i.PropId)
              .HasPrincipalKey(i => i.Propid);

            builder.Entity<Destination.Models.destinationTest.PropertyBackToBackBookingsRestrict>()
              .HasOne(i => i.Property)
              .WithMany(i => i.PropertyBackToBackBookingsRestricts)
              .HasForeignKey(i => i.PropId)
              .HasPrincipalKey(i => i.Propid);

            builder.Entity<Destination.Models.destinationTest.PropertyRatesDaily>()
              .HasOne(i => i.Property)
              .WithMany(i => i.PropertyRatesDailies)
              .HasForeignKey(i => i.PropId)
              .HasPrincipalKey(i => i.Propid);

            builder.Entity<Destination.Models.destinationTest.PropertyVisitCount>()
              .HasOne(i => i.Property)
              .WithMany(i => i.PropertyVisitCounts)
              .HasForeignKey(i => i.PropId)
              .HasPrincipalKey(i => i.Propid);

            builder.Entity<Destination.Models.destinationTest.RamTestResult>()
              .HasOne(i => i.RamTestUser)
              .WithMany(i => i.RamTestResults)
              .HasForeignKey(i => i.UserId)
              .HasPrincipalKey(i => i.Id);

            builder.Entity<Destination.Models.destinationTest.RamTestUserResult>()
              .HasOne(i => i.RamQuestion)
              .WithMany(i => i.RamTestUserResults)
              .HasForeignKey(i => i.RamQuestionId)
              .HasPrincipalKey(i => i.Id);

            builder.Entity<Destination.Models.destinationTest.RamTestUserResult>()
              .HasOne(i => i.RamTestUser)
              .WithMany(i => i.RamTestUserResults)
              .HasForeignKey(i => i.UserId)
              .HasPrincipalKey(i => i.Id);

            builder.Entity<Destination.Models.destinationTest.RamTestUser>()
              .HasOne(i => i.RamTest)
              .WithMany(i => i.RamTestUsers)
              .HasForeignKey(i => i.RamTestId)
              .HasPrincipalKey(i => i.TestId);

            builder.Entity<Destination.Models.destinationTest.TblMultiDayDiscount>()
              .HasOne(i => i.Property)
              .WithMany(i => i.TblMultiDayDiscounts)
              .HasForeignKey(i => i.PropId)
              .HasPrincipalKey(i => i.Propid);

            builder.Entity<Destination.Models.destinationTest.AffiliateBooking>()
              .Property(p => p.CreateDate)
              .HasDefaultValueSql(@"(getdate())");

            builder.Entity<Destination.Models.destinationTest.Affiliate>()
              .Property(p => p.IsVerified)
              .HasDefaultValueSql(@"((0))");

            builder.Entity<Destination.Models.destinationTest.Affiliate>()
              .Property(p => p.CreatedOn)
              .HasDefaultValueSql(@"(getdate())");

            builder.Entity<Destination.Models.destinationTest.AffiliatesCommunication>()
              .Property(p => p.LoggedOn)
              .HasDefaultValueSql(@"(getdate())");

            builder.Entity<Destination.Models.destinationTest.AffiliatesPropertyViewHistory>()
              .Property(p => p.ViewedOn)
              .HasDefaultValueSql(@"(getdate())");

            builder.Entity<Destination.Models.destinationTest.AgreementHistory>()
              .Property(p => p.CreatedDate)
              .HasDefaultValueSql(@"(getdate())");

            builder.Entity<Destination.Models.destinationTest.AirbnbApiAutoSyncContent>()
              .Property(p => p.ChangedOn)
              .HasDefaultValueSql(@"(getdate())");

            builder.Entity<Destination.Models.destinationTest.AirbnbApiAutoSyncContent>()
              .Property(p => p.IsSynced)
              .HasDefaultValueSql(@"((0))");

            builder.Entity<Destination.Models.destinationTest.AirbnbSendMessage>()
              .Property(p => p.CreatedAt)
              .HasDefaultValueSql(@"(getdate())");

            builder.Entity<Destination.Models.destinationTest.AnnualSurvey>()
              .Property(p => p.CreatedDate)
              .HasDefaultValueSql(@"(getdate())");

            builder.Entity<Destination.Models.destinationTest.AppliedPromoCode>()
              .Property(p => p.DateApplied)
              .HasDefaultValueSql(@"(getdate())");

            builder.Entity<Destination.Models.destinationTest.Bookingdamage>()
              .Property(p => p.UploadedOn)
              .HasDefaultValueSql(@"(getdate())");

            builder.Entity<Destination.Models.destinationTest.BookingQuote>()
              .Property(p => p.Cleaner)
              .HasDefaultValueSql(@"((119))");

            builder.Entity<Destination.Models.destinationTest.BookingQuote>()
              .Property(p => p.Depositreturned)
              .HasDefaultValueSql(@"((0))");

            builder.Entity<Destination.Models.destinationTest.BookingQuote>()
              .Property(p => p.Ownerbooking)
              .HasDefaultValueSql(@"((0))");

            builder.Entity<Destination.Models.destinationTest.Booking>()
              .Property(p => p.Cleaner)
              .HasDefaultValueSql(@"((119))");

            builder.Entity<Destination.Models.destinationTest.Booking>()
              .Property(p => p.Depositreturned)
              .HasDefaultValueSql(@"((0))");

            builder.Entity<Destination.Models.destinationTest.Booking>()
              .Property(p => p.Ownerbooking)
              .HasDefaultValueSql(@"((0))");

            builder.Entity<Destination.Models.destinationTest.Booking>()
              .Property(p => p.Contractrec)
              .HasDefaultValueSql(@"((0))");

            builder.Entity<Destination.Models.destinationTest.Booking>()
              .Property(p => p.Cleaningcomp)
              .HasDefaultValueSql(@"((0))");

            builder.Entity<Destination.Models.destinationTest.Booking>()
              .Property(p => p.HoldDeposit)
              .HasDefaultValueSql(@"((0))");

            builder.Entity<Destination.Models.destinationTest.BookingsCode>()
              .Property(p => p.GeneratedDate)
              .HasDefaultValueSql(@"(getdate())");

            builder.Entity<Destination.Models.destinationTest.BookingsCode>()
              .Property(p => p.IntStatus)
              .HasDefaultValueSql(@"((0))");

            builder.Entity<Destination.Models.destinationTest.BookingsLogic>()
              .Property(p => p.DtCreated)
              .HasDefaultValueSql(@"(getdate())");

            builder.Entity<Destination.Models.destinationTest.BookingsLogic>()
              .Property(p => p.DtModified)
              .HasDefaultValueSql(@"(getdate())");

            builder.Entity<Destination.Models.destinationTest.BookingsOriginalPubRate>()
              .Property(p => p.CreatedDate)
              .HasDefaultValueSql(@"(getdate())");

            builder.Entity<Destination.Models.destinationTest.Communication>()
              .Property(p => p.Actionrequired)
              .HasDefaultValueSql(@"((0))");

            builder.Entity<Destination.Models.destinationTest.DoorCodeLog>()
              .Property(p => p.ChangeDate)
              .HasDefaultValueSql(@"(getdate())");

            builder.Entity<Destination.Models.destinationTest.GoogleUsersKeyword>()
              .Property(p => p.EnteredOn)
              .HasDefaultValueSql(@"(getdate())");

            builder.Entity<Destination.Models.destinationTest.InntopiaBooking>()
              .Property(p => p.EnteredOn)
              .HasDefaultValueSql(@"(getdate())");

            builder.Entity<Destination.Models.destinationTest.InquiryNa>()
              .Property(p => p.EnteredOn)
              .HasDefaultValueSql(@"(getdate())");

            builder.Entity<Destination.Models.destinationTest.InspectionPlan>()
              .Property(p => p.EnteredDate)
              .HasDefaultValueSql(@"(getdate())");

            builder.Entity<Destination.Models.destinationTest.LogEditPropertyDescription>()
              .Property(p => p.UpdatedOn)
              .HasDefaultValueSql(@"(getdate())");

            builder.Entity<Destination.Models.destinationTest.NoWord>()
              .Property(p => p.EnteredOn)
              .HasDefaultValueSql(@"(getdate())");

            builder.Entity<Destination.Models.destinationTest.OlarkZapier>()
              .Property(p => p.EnteredOn)
              .HasDefaultValueSql(@"(getdate())");

            builder.Entity<Destination.Models.destinationTest.OlarkZapier>()
              .Property(p => p.Status)
              .HasDefaultValueSql(@"((0))");

            builder.Entity<Destination.Models.destinationTest.Performa>()
              .Property(p => p.CreatedDate)
              .HasDefaultValueSql(@"(getdate())");

            builder.Entity<Destination.Models.destinationTest.PinkSheetNote>()
              .Property(p => p.EnteredOn)
              .HasDefaultValueSql(@"(getdate())");

            builder.Entity<Destination.Models.destinationTest.PropertyActivationDate>()
              .Property(p => p.ActivateDate)
              .HasDefaultValueSql(@"(getdate())");

            builder.Entity<Destination.Models.destinationTest.PropertyExpense>()
              .Property(p => p.Dateentered)
              .HasDefaultValueSql(@"(getdate())");

            builder.Entity<Destination.Models.destinationTest.PropertyExpense>()
              .Property(p => p.Priority)
              .HasDefaultValueSql(@"((0))");

            builder.Entity<Destination.Models.destinationTest.PropertyExpense>()
              .Property(p => p.Hot)
              .HasDefaultValueSql(@"('low')");

            builder.Entity<Destination.Models.destinationTest.PropertyExpense>()
              .Property(p => p.Dontshow)
              .HasDefaultValueSql(@"((0))");

            builder.Entity<Destination.Models.destinationTest.PropertyVisitCount>()
              .Property(p => p.VisitedOn)
              .HasDefaultValueSql(@"(getdate())");

            builder.Entity<Destination.Models.destinationTest.SendTwilioSm>()
              .Property(p => p.CreatedDate)
              .HasDefaultValueSql(@"(getdate())");

            builder.Entity<Destination.Models.destinationTest.SendTwilioSmsQueue>()
              .Property(p => p.CreatedDate)
              .HasDefaultValueSql(@"(getdate())");

            builder.Entity<Destination.Models.destinationTest.TblBulkEmailLog>()
              .Property(p => p.SentOn)
              .HasDefaultValueSql(@"(getdate())");

            builder.Entity<Destination.Models.destinationTest.TblDebug>()
              .Property(p => p.DtCreated)
              .HasDefaultValueSql(@"(getdate())");

            builder.Entity<Destination.Models.destinationTest.TblNotAvtivePropertyBooking>()
              .Property(p => p.DateTimeStamp)
              .HasDefaultValueSql(@"(getdate())");

            builder.Entity<Destination.Models.destinationTest.TblNotSendingEmail>()
              .Property(p => p.SentOn)
              .HasDefaultValueSql(@"(getdate())");

            builder.Entity<Destination.Models.destinationTest.TblTrackDailyRatesExecutionForProperty>()
              .Property(p => p.ExecTime)
              .HasDefaultValueSql(@"(getdate())");

            builder.Entity<Destination.Models.destinationTest.TestTableForDailyRoutine>()
              .Property(p => p.ExecutedOn)
              .HasDefaultValueSql(@"(getdate())");

            builder.Entity<Destination.Models.destinationTest.TrackedUser>()
              .Property(p => p.VisitedOn)
              .HasDefaultValueSql(@"(getdate())");

            builder.Entity<Destination.Models.destinationTest.VonageTsheet>()
              .Property(p => p.EnteredOn)
              .HasDefaultValueSql(@"(getdate())");

            builder.Entity<Destination.Models.destinationTest.Vrboimage>()
              .Property(p => p.IsPickedup)
              .HasDefaultValueSql(@"((0))");

            builder.Entity<Destination.Models.destinationTest.Vrboimage>()
              .Property(p => p.CreatedDate)
              .HasDefaultValueSql(@"(getdate())");

            builder.Entity<Destination.Models.destinationTest.VrboimageDetail>()
              .Property(p => p.IsDeleted)
              .HasDefaultValueSql(@"((0))");

            builder.Entity<Destination.Models.destinationTest.VrboimageDetail>()
              .Property(p => p.LastUpdated)
              .HasDefaultValueSql(@"(getdate())");

            builder.Entity<Destination.Models.destinationTest.AirbnbApiAutoSyncContent>()
              .Property(p => p.Id)
              .ValueGeneratedOnAddOrUpdate().UseIdentityColumn()
              .Metadata.SetAfterSaveBehavior(Microsoft.EntityFrameworkCore.Metadata.PropertySaveBehavior.Ignore);

            builder.Entity<Destination.Models.destinationTest.AirbnbApicredential>()
              .Property(p => p.Id)
              .ValueGeneratedOnAddOrUpdate().UseIdentityColumn()
              .Metadata.SetAfterSaveBehavior(Microsoft.EntityFrameworkCore.Metadata.PropertySaveBehavior.Ignore);

            builder.Entity<Destination.Models.destinationTest.AirbnbApireservationsJson>()
              .Property(p => p.Id)
              .ValueGeneratedOnAddOrUpdate().UseIdentityColumn()
              .Metadata.SetAfterSaveBehavior(Microsoft.EntityFrameworkCore.Metadata.PropertySaveBehavior.Ignore);

            builder.Entity<Destination.Models.destinationTest.AirbnbIcalsUpdateTracking>()
              .Property(p => p.Id)
              .ValueGeneratedOnAddOrUpdate().UseIdentityColumn()
              .Metadata.SetAfterSaveBehavior(Microsoft.EntityFrameworkCore.Metadata.PropertySaveBehavior.Ignore);

            builder.Entity<Destination.Models.destinationTest.AirbnbMessage>()
              .Property(p => p.Id)
              .ValueGeneratedOnAddOrUpdate().UseIdentityColumn()
              .Metadata.SetAfterSaveBehavior(Microsoft.EntityFrameworkCore.Metadata.PropertySaveBehavior.Ignore);

            builder.Entity<Destination.Models.destinationTest.AirbnbUploadedPhoto>()
              .Property(p => p.Id)
              .ValueGeneratedOnAddOrUpdate().UseIdentityColumn()
              .Metadata.SetAfterSaveBehavior(Microsoft.EntityFrameworkCore.Metadata.PropertySaveBehavior.Ignore);

            builder.Entity<Destination.Models.destinationTest.Annual>()
              .Property(p => p.Id)
              .ValueGeneratedOnAddOrUpdate().UseIdentityColumn()
              .Metadata.SetAfterSaveBehavior(Microsoft.EntityFrameworkCore.Metadata.PropertySaveBehavior.Ignore);

            builder.Entity<Destination.Models.destinationTest.BookingStatus1>()
              .Property(p => p.Id)
              .ValueGeneratedOnAddOrUpdate().UseIdentityColumn()
              .Metadata.SetAfterSaveBehavior(Microsoft.EntityFrameworkCore.Metadata.PropertySaveBehavior.Ignore);

            builder.Entity<Destination.Models.destinationTest.BookingEmailSetting>()
              .Property(p => p.Id)
              .ValueGeneratedOnAddOrUpdate().UseIdentityColumn()
              .Metadata.SetAfterSaveBehavior(Microsoft.EntityFrameworkCore.Metadata.PropertySaveBehavior.Ignore);

            builder.Entity<Destination.Models.destinationTest.BookingsVisited>()
              .Property(p => p.Id)
              .ValueGeneratedOnAddOrUpdate().UseIdentityColumn()
              .Metadata.SetAfterSaveBehavior(Microsoft.EntityFrameworkCore.Metadata.PropertySaveBehavior.Ignore);

            builder.Entity<Destination.Models.destinationTest.BookingsLargeGroup>()
              .Property(p => p.Id)
              .ValueGeneratedOnAddOrUpdate().UseIdentityColumn()
              .Metadata.SetAfterSaveBehavior(Microsoft.EntityFrameworkCore.Metadata.PropertySaveBehavior.Ignore);

            builder.Entity<Destination.Models.destinationTest.ChannelBu>()
              .Property(p => p.Id)
              .ValueGeneratedOnAddOrUpdate().UseIdentityColumn()
              .Metadata.SetAfterSaveBehavior(Microsoft.EntityFrameworkCore.Metadata.PropertySaveBehavior.Ignore);

            builder.Entity<Destination.Models.destinationTest.ChannelPartnerHit>()
              .Property(p => p.Id)
              .ValueGeneratedOnAddOrUpdate().UseIdentityColumn()
              .Metadata.SetAfterSaveBehavior(Microsoft.EntityFrameworkCore.Metadata.PropertySaveBehavior.Ignore);

            builder.Entity<Destination.Models.destinationTest.ChatBotKeywordMaster>()
              .Property(p => p.Id)
              .ValueGeneratedOnAddOrUpdate().UseIdentityColumn()
              .Metadata.SetAfterSaveBehavior(Microsoft.EntityFrameworkCore.Metadata.PropertySaveBehavior.Ignore);

            builder.Entity<Destination.Models.destinationTest.ChatBotMenuMaster>()
              .Property(p => p.Id)
              .ValueGeneratedOnAddOrUpdate().UseIdentityColumn()
              .Metadata.SetAfterSaveBehavior(Microsoft.EntityFrameworkCore.Metadata.PropertySaveBehavior.Ignore);

            builder.Entity<Destination.Models.destinationTest.CheckInLog>()
              .Property(p => p.Id)
              .ValueGeneratedOnAddOrUpdate().UseIdentityColumn()
              .Metadata.SetAfterSaveBehavior(Microsoft.EntityFrameworkCore.Metadata.PropertySaveBehavior.Ignore);

            builder.Entity<Destination.Models.destinationTest.CleanerAuditedMsg>()
              .Property(p => p.Id)
              .ValueGeneratedOnAddOrUpdate().UseIdentityColumn()
              .Metadata.SetAfterSaveBehavior(Microsoft.EntityFrameworkCore.Metadata.PropertySaveBehavior.Ignore);

            builder.Entity<Destination.Models.destinationTest.CleanerInvoiceMatchedDatum>()
              .Property(p => p.Id)
              .ValueGeneratedOnAddOrUpdate().UseIdentityColumn()
              .Metadata.SetAfterSaveBehavior(Microsoft.EntityFrameworkCore.Metadata.PropertySaveBehavior.Ignore);

            builder.Entity<Destination.Models.destinationTest.CleanerNo>()
              .Property(p => p.Id)
              .ValueGeneratedOnAddOrUpdate().UseIdentityColumn()
              .Metadata.SetAfterSaveBehavior(Microsoft.EntityFrameworkCore.Metadata.PropertySaveBehavior.Ignore);

            builder.Entity<Destination.Models.destinationTest.CleaningPayrolExtraTaskDetail>()
              .Property(p => p.Id)
              .ValueGeneratedOnAddOrUpdate().UseIdentityColumn()
              .Metadata.SetAfterSaveBehavior(Microsoft.EntityFrameworkCore.Metadata.PropertySaveBehavior.Ignore);

            builder.Entity<Destination.Models.destinationTest.CoronaAnnualDatum>()
              .Property(p => p.Id)
              .ValueGeneratedOnAddOrUpdate().UseIdentityColumn()
              .Metadata.SetAfterSaveBehavior(Microsoft.EntityFrameworkCore.Metadata.PropertySaveBehavior.Ignore);

            builder.Entity<Destination.Models.destinationTest.CriticalTaskWarning>()
              .Property(p => p.Id)
              .ValueGeneratedOnAddOrUpdate().UseIdentityColumn()
              .Metadata.SetAfterSaveBehavior(Microsoft.EntityFrameworkCore.Metadata.PropertySaveBehavior.Ignore);

            builder.Entity<Destination.Models.destinationTest.CurrentDiscountsHistory>()
              .Property(p => p.Id)
              .ValueGeneratedOnAddOrUpdate().UseIdentityColumn()
              .Metadata.SetAfterSaveBehavior(Microsoft.EntityFrameworkCore.Metadata.PropertySaveBehavior.Ignore);

            builder.Entity<Destination.Models.destinationTest.DeletedGapHolderBooking>()
              .Property(p => p.Id)
              .ValueGeneratedOnAddOrUpdate().UseIdentityColumn()
              .Metadata.SetAfterSaveBehavior(Microsoft.EntityFrameworkCore.Metadata.PropertySaveBehavior.Ignore);

            builder.Entity<Destination.Models.destinationTest.DepositHoldLog>()
              .Property(p => p.Id)
              .ValueGeneratedOnAddOrUpdate().UseIdentityColumn()
              .Metadata.SetAfterSaveBehavior(Microsoft.EntityFrameworkCore.Metadata.PropertySaveBehavior.Ignore);

            builder.Entity<Destination.Models.destinationTest.DoNotRent>()
              .Property(p => p.Id)
              .ValueGeneratedOnAddOrUpdate().UseIdentityColumn()
              .Metadata.SetAfterSaveBehavior(Microsoft.EntityFrameworkCore.Metadata.PropertySaveBehavior.Ignore);

            builder.Entity<Destination.Models.destinationTest.GuestCodeCall>()
              .Property(p => p.Id)
              .ValueGeneratedOnAddOrUpdate().UseIdentityColumn()
              .Metadata.SetAfterSaveBehavior(Microsoft.EntityFrameworkCore.Metadata.PropertySaveBehavior.Ignore);

            builder.Entity<Destination.Models.destinationTest.HotHome>()
              .Property(p => p.Id)
              .ValueGeneratedOnAddOrUpdate().UseIdentityColumn()
              .Metadata.SetAfterSaveBehavior(Microsoft.EntityFrameworkCore.Metadata.PropertySaveBehavior.Ignore);

            builder.Entity<Destination.Models.destinationTest.LandingPage>()
              .Property(p => p.Id)
              .ValueGeneratedOnAddOrUpdate().UseIdentityColumn()
              .Metadata.SetAfterSaveBehavior(Microsoft.EntityFrameworkCore.Metadata.PropertySaveBehavior.Ignore);

            builder.Entity<Destination.Models.destinationTest.LargeGroupBooking>()
              .Property(p => p.Id)
              .ValueGeneratedOnAddOrUpdate().UseIdentityColumn()
              .Metadata.SetAfterSaveBehavior(Microsoft.EntityFrameworkCore.Metadata.PropertySaveBehavior.Ignore);

            builder.Entity<Destination.Models.destinationTest.OffhoursListForSmsroutine>()
              .Property(p => p.Id)
              .ValueGeneratedOnAddOrUpdate().UseIdentityColumn()
              .Metadata.SetAfterSaveBehavior(Microsoft.EntityFrameworkCore.Metadata.PropertySaveBehavior.Ignore);

            builder.Entity<Destination.Models.destinationTest.PaymentLogDoubleRefunded>()
              .Property(p => p.Id)
              .ValueGeneratedOnAddOrUpdate().UseIdentityColumn()
              .Metadata.SetAfterSaveBehavior(Microsoft.EntityFrameworkCore.Metadata.PropertySaveBehavior.Ignore);

            builder.Entity<Destination.Models.destinationTest.PhoneCallLog>()
              .Property(p => p.Id)
              .ValueGeneratedOnAddOrUpdate().UseIdentityColumn()
              .Metadata.SetAfterSaveBehavior(Microsoft.EntityFrameworkCore.Metadata.PropertySaveBehavior.Ignore);

            builder.Entity<Destination.Models.destinationTest.Promotion>()
              .Property(p => p.Id)
              .ValueGeneratedOnAddOrUpdate().UseIdentityColumn()
              .Metadata.SetAfterSaveBehavior(Microsoft.EntityFrameworkCore.Metadata.PropertySaveBehavior.Ignore);

            builder.Entity<Destination.Models.destinationTest.PropertyExpenseBlankRecord>()
              .Property(p => p.Propexpid)
              .ValueGeneratedOnAddOrUpdate().UseIdentityColumn()
              .Metadata.SetAfterSaveBehavior(Microsoft.EntityFrameworkCore.Metadata.PropertySaveBehavior.Ignore);

            builder.Entity<Destination.Models.destinationTest.PropertyExpensesDeleted>()
              .Property(p => p.Propexpid)
              .ValueGeneratedOnAddOrUpdate().UseIdentityColumn()
              .Metadata.SetAfterSaveBehavior(Microsoft.EntityFrameworkCore.Metadata.PropertySaveBehavior.Ignore);

            builder.Entity<Destination.Models.destinationTest.PropertyLastNextBookingDetail>()
              .Property(p => p.Id)
              .ValueGeneratedOnAddOrUpdate().UseIdentityColumn()
              .Metadata.SetAfterSaveBehavior(Microsoft.EntityFrameworkCore.Metadata.PropertySaveBehavior.Ignore);

            builder.Entity<Destination.Models.destinationTest.PropertyAnnualLog>()
              .Property(p => p.Id)
              .ValueGeneratedOnAddOrUpdate().UseIdentityColumn()
              .Metadata.SetAfterSaveBehavior(Microsoft.EntityFrameworkCore.Metadata.PropertySaveBehavior.Ignore);

            builder.Entity<Destination.Models.destinationTest.PropertyFulltime>()
              .Property(p => p.Id)
              .ValueGeneratedOnAddOrUpdate().UseIdentityColumn()
              .Metadata.SetAfterSaveBehavior(Microsoft.EntityFrameworkCore.Metadata.PropertySaveBehavior.Ignore);

            builder.Entity<Destination.Models.destinationTest.PropertyInsurance>()
              .Property(p => p.Id)
              .ValueGeneratedOnAddOrUpdate().UseIdentityColumn()
              .Metadata.SetAfterSaveBehavior(Microsoft.EntityFrameworkCore.Metadata.PropertySaveBehavior.Ignore);

            builder.Entity<Destination.Models.destinationTest.PropertyRatesDailySingleProp>()
              .Property(p => p.Id)
              .ValueGeneratedOnAddOrUpdate().UseIdentityColumn()
              .Metadata.SetAfterSaveBehavior(Microsoft.EntityFrameworkCore.Metadata.PropertySaveBehavior.Ignore);

            builder.Entity<Destination.Models.destinationTest.Restriction>()
              .Property(p => p.Id)
              .ValueGeneratedOnAddOrUpdate().UseIdentityColumn()
              .Metadata.SetAfterSaveBehavior(Microsoft.EntityFrameworkCore.Metadata.PropertySaveBehavior.Ignore);

            builder.Entity<Destination.Models.destinationTest.Sample23>()
              .Property(p => p.Propid)
              .ValueGeneratedOnAddOrUpdate().UseIdentityColumn()
              .Metadata.SetAfterSaveBehavior(Microsoft.EntityFrameworkCore.Metadata.PropertySaveBehavior.Ignore);

            builder.Entity<Destination.Models.destinationTest.SendAirbnbCheckOutReply>()
              .Property(p => p.Id)
              .ValueGeneratedOnAddOrUpdate().UseIdentityColumn()
              .Metadata.SetAfterSaveBehavior(Microsoft.EntityFrameworkCore.Metadata.PropertySaveBehavior.Ignore);

            builder.Entity<Destination.Models.destinationTest.SendTwilioSmsQueue>()
              .Property(p => p.Smsid)
              .ValueGeneratedOnAddOrUpdate().UseIdentityColumn()
              .Metadata.SetAfterSaveBehavior(Microsoft.EntityFrameworkCore.Metadata.PropertySaveBehavior.Ignore);

            builder.Entity<Destination.Models.destinationTest.SmsRemoveList>()
              .Property(p => p.Id)
              .ValueGeneratedOnAddOrUpdate().UseIdentityColumn()
              .Metadata.SetAfterSaveBehavior(Microsoft.EntityFrameworkCore.Metadata.PropertySaveBehavior.Ignore);

            builder.Entity<Destination.Models.destinationTest.SmstemplateArea>()
              .Property(p => p.Id)
              .ValueGeneratedOnAddOrUpdate().UseIdentityColumn()
              .Metadata.SetAfterSaveBehavior(Microsoft.EntityFrameworkCore.Metadata.PropertySaveBehavior.Ignore);

            builder.Entity<Destination.Models.destinationTest.SnowRemoval>()
              .Property(p => p.Id)
              .ValueGeneratedOnAddOrUpdate().UseIdentityColumn()
              .Metadata.SetAfterSaveBehavior(Microsoft.EntityFrameworkCore.Metadata.PropertySaveBehavior.Ignore);

            builder.Entity<Destination.Models.destinationTest.TblDebug>()
              .Property(p => p.PrimaryId)
              .ValueGeneratedOnAddOrUpdate().UseIdentityColumn()
              .Metadata.SetAfterSaveBehavior(Microsoft.EntityFrameworkCore.Metadata.PropertySaveBehavior.Ignore);

            builder.Entity<Destination.Models.destinationTest.TblPartialCheckIn>()
              .Property(p => p.Id)
              .ValueGeneratedOnAddOrUpdate().UseIdentityColumn()
              .Metadata.SetAfterSaveBehavior(Microsoft.EntityFrameworkCore.Metadata.PropertySaveBehavior.Ignore);

            builder.Entity<Destination.Models.destinationTest.TenantCheckInPhoto>()
              .Property(p => p.Id)
              .ValueGeneratedOnAddOrUpdate().UseIdentityColumn()
              .Metadata.SetAfterSaveBehavior(Microsoft.EntityFrameworkCore.Metadata.PropertySaveBehavior.Ignore);

            builder.Entity<Destination.Models.destinationTest.TenantInterestDatum>()
              .Property(p => p.Id)
              .ValueGeneratedOnAddOrUpdate().UseIdentityColumn()
              .Metadata.SetAfterSaveBehavior(Microsoft.EntityFrameworkCore.Metadata.PropertySaveBehavior.Ignore);

            builder.Entity<Destination.Models.destinationTest.TenantWithPlusOneInCell>()
              .Property(p => p.Tenantid)
              .ValueGeneratedOnAddOrUpdate().UseIdentityColumn()
              .Metadata.SetAfterSaveBehavior(Microsoft.EntityFrameworkCore.Metadata.PropertySaveBehavior.Ignore);

            builder.Entity<Destination.Models.destinationTest.TestTable>()
              .Property(p => p.Id)
              .ValueGeneratedOnAddOrUpdate().UseIdentityColumn()
              .Metadata.SetAfterSaveBehavior(Microsoft.EntityFrameworkCore.Metadata.PropertySaveBehavior.Ignore);

            builder.Entity<Destination.Models.destinationTest.UvGetBooking>()
              .Property(p => p.Id)
              .ValueGeneratedOnAddOrUpdate().UseIdentityColumn()
              .Metadata.SetAfterSaveBehavior(Microsoft.EntityFrameworkCore.Metadata.PropertySaveBehavior.Ignore);

            builder.Entity<Destination.Models.destinationTest.VrboErrorLogForBookingRequest>()
              .Property(p => p.Id)
              .ValueGeneratedOnAddOrUpdate().UseIdentityColumn()
              .Metadata.SetAfterSaveBehavior(Microsoft.EntityFrameworkCore.Metadata.PropertySaveBehavior.Ignore);

            builder.Entity<Destination.Models.destinationTest.VwCurrentlyOccupied>()
              .Property(p => p.BookingId)
              .ValueGeneratedOnAddOrUpdate().UseIdentityColumn()
              .Metadata.SetAfterSaveBehavior(Microsoft.EntityFrameworkCore.Metadata.PropertySaveBehavior.Ignore);

            builder.Entity<Destination.Models.destinationTest.VwGetAllPropertyStatus>()
              .Property(p => p.Propid)
              .ValueGeneratedOnAddOrUpdate().UseIdentityColumn()
              .Metadata.SetAfterSaveBehavior(Microsoft.EntityFrameworkCore.Metadata.PropertySaveBehavior.Ignore);

            builder.Entity<Destination.Models.destinationTest.VwGetDoorCodeLog>()
              .Property(p => p.PropId)
              .ValueGeneratedOnAddOrUpdate().UseIdentityColumn()
              .Metadata.SetAfterSaveBehavior(Microsoft.EntityFrameworkCore.Metadata.PropertySaveBehavior.Ignore);

            builder.Entity<Destination.Models.destinationTest.VwGetInspectionDateMgtForAllActiveProp>()
              .Property(p => p.PropId)
              .ValueGeneratedOnAddOrUpdate().UseIdentityColumn()
              .Metadata.SetAfterSaveBehavior(Microsoft.EntityFrameworkCore.Metadata.PropertySaveBehavior.Ignore);

            builder.Entity<Destination.Models.destinationTest.VwGetLastCleaner>()
              .Property(p => p.BookingId)
              .ValueGeneratedOnAddOrUpdate().UseIdentityColumn()
              .Metadata.SetAfterSaveBehavior(Microsoft.EntityFrameworkCore.Metadata.PropertySaveBehavior.Ignore);

            builder.Entity<Destination.Models.destinationTest.VwGetNetSum>()
              .Property(p => p.Id)
              .ValueGeneratedOnAddOrUpdate().UseIdentityColumn()
              .Metadata.SetAfterSaveBehavior(Microsoft.EntityFrameworkCore.Metadata.PropertySaveBehavior.Ignore);

            builder.Entity<Destination.Models.destinationTest.VwGetPropertiesWithoutSpace>()
              .Property(p => p.Propid)
              .ValueGeneratedOnAddOrUpdate().UseIdentityColumn()
              .Metadata.SetAfterSaveBehavior(Microsoft.EntityFrameworkCore.Metadata.PropertySaveBehavior.Ignore);

            builder.Entity<Destination.Models.destinationTest.WebPageTemplate>()
              .Property(p => p.TemplateId)
              .ValueGeneratedOnAddOrUpdate().UseIdentityColumn()
              .Metadata.SetAfterSaveBehavior(Microsoft.EntityFrameworkCore.Metadata.PropertySaveBehavior.Ignore);

            builder.Entity<Destination.Models.destinationTest.AffiliateBooking>()
              .Property(p => p.CreateDate)
              .HasColumnType("datetime");

            builder.Entity<Destination.Models.destinationTest.AffiliateCollaboration>()
              .Property(p => p.LastTouched)
              .HasColumnType("datetime");

            builder.Entity<Destination.Models.destinationTest.AffiliateCommission>()
              .Property(p => p.DateRangeStart)
              .HasColumnType("datetime");

            builder.Entity<Destination.Models.destinationTest.AffiliateCommission>()
              .Property(p => p.DateRangeEnd)
              .HasColumnType("datetime");

            builder.Entity<Destination.Models.destinationTest.Affiliate>()
              .Property(p => p.CreatedOn)
              .HasColumnType("datetime");

            builder.Entity<Destination.Models.destinationTest.Affiliate>()
              .Property(p => p.LastTouched)
              .HasColumnType("datetime");

            builder.Entity<Destination.Models.destinationTest.AffiliatesCommunication>()
              .Property(p => p.LoggedOn)
              .HasColumnType("datetime");

            builder.Entity<Destination.Models.destinationTest.AffiliatesDatum>()
              .Property(p => p.LastTouched)
              .HasColumnType("datetime");

            builder.Entity<Destination.Models.destinationTest.AffiliatesPropertyViewHistory>()
              .Property(p => p.ViewedOn)
              .HasColumnType("datetime");

            builder.Entity<Destination.Models.destinationTest.AffiliatesPropertyViewHistory>()
              .Property(p => p.FromDate)
              .HasColumnType("datetime");

            builder.Entity<Destination.Models.destinationTest.AffiliatesPropertyViewHistory>()
              .Property(p => p.ToDate)
              .HasColumnType("datetime");

            builder.Entity<Destination.Models.destinationTest.Agent>()
              .Property(p => p.Touched)
              .HasColumnType("datetime");

            builder.Entity<Destination.Models.destinationTest.Agent>()
              .Property(p => p.EnteredOn)
              .HasColumnType("datetime");

            builder.Entity<Destination.Models.destinationTest.Agent>()
              .Property(p => p.DateCreated)
              .HasColumnType("datetime");

            builder.Entity<Destination.Models.destinationTest.AgreementHistory>()
              .Property(p => p.CreatedDate)
              .HasColumnType("datetime");

            builder.Entity<Destination.Models.destinationTest.AirbnbApiAutoSyncContent>()
              .Property(p => p.ChangedOn)
              .HasColumnType("datetime");

            builder.Entity<Destination.Models.destinationTest.AirbnbApiAutoSyncContent>()
              .Property(p => p.SyncedOn)
              .HasColumnType("datetime");

            builder.Entity<Destination.Models.destinationTest.AirbnbApireservationsJson>()
              .Property(p => p.InsertedOn)
              .HasColumnType("datetime");

            builder.Entity<Destination.Models.destinationTest.AirBnbExport>()
              .Property(p => p.Startdate)
              .HasColumnType("datetime");

            builder.Entity<Destination.Models.destinationTest.AirBnbExport>()
              .Property(p => p.Enddate)
              .HasColumnType("datetime");

            builder.Entity<Destination.Models.destinationTest.AirBnbExport>()
              .Property(p => p.Booked)
              .HasColumnType("datetime");

            builder.Entity<Destination.Models.destinationTest.AirbnbIcalsUpdateTracking>()
              .Property(p => p.ExecutedAt)
              .HasColumnType("datetime");

            builder.Entity<Destination.Models.destinationTest.AirbnbMessage>()
              .Property(p => p.MsgDate)
              .HasColumnType("datetime");

            builder.Entity<Destination.Models.destinationTest.AirbnbSendMessage>()
              .Property(p => p.CreatedAt)
              .HasColumnType("datetime");

            builder.Entity<Destination.Models.destinationTest.AirbnbSendMessage>()
              .Property(p => p.SentOn)
              .HasColumnType("datetime");

            builder.Entity<Destination.Models.destinationTest.Annual>()
              .Property(p => p.SubmissionTime)
              .HasColumnType("datetime");

            builder.Entity<Destination.Models.destinationTest.Annual>()
              .Property(p => p.DeepCleanDate)
              .HasColumnType("datetime");

            builder.Entity<Destination.Models.destinationTest.Annual>()
              .Property(p => p.WindowCleanDate)
              .HasColumnType("datetime");

            builder.Entity<Destination.Models.destinationTest.Annual>()
              .Property(p => p.AbatementDate)
              .HasColumnType("datetime");

            builder.Entity<Destination.Models.destinationTest.Annual>()
              .Property(p => p.CarpetDate)
              .HasColumnType("datetime");

            builder.Entity<Destination.Models.destinationTest.Annual>()
              .Property(p => p.HeaterFilterDate)
              .HasColumnType("datetime");

            builder.Entity<Destination.Models.destinationTest.AnnualSurvey>()
              .Property(p => p.SubmissionTime)
              .HasColumnType("datetime");

            builder.Entity<Destination.Models.destinationTest.AnnualSurvey>()
              .Property(p => p.CreatedDate)
              .HasColumnType("datetime");

            builder.Entity<Destination.Models.destinationTest.AppliedPromoCode>()
              .Property(p => p.DateApplied)
              .HasColumnType("datetime");

            builder.Entity<Destination.Models.destinationTest.AutoSmspagesHitPerDay>()
              .Property(p => p.HitDateTime)
              .HasColumnType("datetime");

            builder.Entity<Destination.Models.destinationTest.BookingAddOwnerReport>()
              .Property(p => p.Dateentered)
              .HasColumnType("datetime");

            builder.Entity<Destination.Models.destinationTest.Bookingdamage>()
              .Property(p => p.UploadedOn)
              .HasColumnType("datetime");

            builder.Entity<Destination.Models.destinationTest.BookingHistory>()
              .Property(p => p.Datefrom)
              .HasColumnType("datetime");

            builder.Entity<Destination.Models.destinationTest.BookingHistory>()
              .Property(p => p.Dateto)
              .HasColumnType("datetime");

            builder.Entity<Destination.Models.destinationTest.BookingHistory>()
              .Property(p => p.DtCreated)
              .HasColumnType("datetime");

            builder.Entity<Destination.Models.destinationTest.BookingQuote>()
              .Property(p => p.Datefrom)
              .HasColumnType("datetime");

            builder.Entity<Destination.Models.destinationTest.BookingQuote>()
              .Property(p => p.Dateto)
              .HasColumnType("datetime");

            builder.Entity<Destination.Models.destinationTest.BookingQuote>()
              .Property(p => p.Bookingdate)
              .HasColumnType("datetime");

            builder.Entity<Destination.Models.destinationTest.BookingQuote>()
              .Property(p => p.QuoteDate)
              .HasColumnType("datetime");

            builder.Entity<Destination.Models.destinationTest.BookingQuote>()
              .Property(p => p.LastUpdated)
              .HasColumnType("datetime");

            builder.Entity<Destination.Models.destinationTest.BookingQuote>()
              .Property(p => p.FutureBookings)
              .HasColumnType("datetime");

            builder.Entity<Destination.Models.destinationTest.Booking>()
              .Property(p => p.Datefrom)
              .HasColumnType("datetime");

            builder.Entity<Destination.Models.destinationTest.Booking>()
              .Property(p => p.Dateto)
              .HasColumnType("datetime");

            builder.Entity<Destination.Models.destinationTest.Booking>()
              .Property(p => p.Bookingdate)
              .HasColumnType("datetime");

            builder.Entity<Destination.Models.destinationTest.Booking>()
              .Property(p => p.InquiryDate)
              .HasColumnType("datetime");

            builder.Entity<Destination.Models.destinationTest.Booking>()
              .Property(p => p.LastUpdated)
              .HasColumnType("datetime");

            builder.Entity<Destination.Models.destinationTest.Booking>()
              .Property(p => p.CleanDate1)
              .HasColumnType("datetime");

            builder.Entity<Destination.Models.destinationTest.Booking>()
              .Property(p => p.InspectDate1)
              .HasColumnType("datetime");

            builder.Entity<Destination.Models.destinationTest.Booking>()
              .Property(p => p.DepositDate1)
              .HasColumnType("datetime");

            builder.Entity<Destination.Models.destinationTest.Booking>()
              .Property(p => p.BookingUpdate)
              .HasColumnType("datetime");

            builder.Entity<Destination.Models.destinationTest.Booking>()
              .Property(p => p.ClosingDate)
              .HasColumnType("datetime");

            builder.Entity<Destination.Models.destinationTest.Booking>()
              .Property(p => p.IsRespondComm)
              .HasColumnType("datetime");

            builder.Entity<Destination.Models.destinationTest.Booking>()
              .Property(p => p.MatchedOn)
              .HasColumnType("datetime");

            builder.Entity<Destination.Models.destinationTest.Booking>()
              .Property(p => p.SpaCleanedDate)
              .HasColumnType("datetime");

            builder.Entity<Destination.Models.destinationTest.Booking>()
              .Property(p => p.CityOrdinanceSignedOn)
              .HasColumnType("datetime");

            builder.Entity<Destination.Models.destinationTest.BookingsVisited>()
              .Property(p => p.Datefrom)
              .HasColumnType("datetime");

            builder.Entity<Destination.Models.destinationTest.BookingsVisited>()
              .Property(p => p.Dateto)
              .HasColumnType("datetime");

            builder.Entity<Destination.Models.destinationTest.BookingsVisited>()
              .Property(p => p.Bookingdate)
              .HasColumnType("datetime");

            builder.Entity<Destination.Models.destinationTest.BookingsVisited>()
              .Property(p => p.InquiryDate)
              .HasColumnType("datetime");

            builder.Entity<Destination.Models.destinationTest.BookingsVisited>()
              .Property(p => p.LastUpdated)
              .HasColumnType("datetime");

            builder.Entity<Destination.Models.destinationTest.BookingsVisited>()
              .Property(p => p.CleanDate1)
              .HasColumnType("datetime");

            builder.Entity<Destination.Models.destinationTest.BookingsVisited>()
              .Property(p => p.InspectDate1)
              .HasColumnType("datetime");

            builder.Entity<Destination.Models.destinationTest.BookingsVisited>()
              .Property(p => p.DepositDate1)
              .HasColumnType("datetime");

            builder.Entity<Destination.Models.destinationTest.BookingsVisited>()
              .Property(p => p.BookingUpdate)
              .HasColumnType("datetime");

            builder.Entity<Destination.Models.destinationTest.BookingsVisited>()
              .Property(p => p.ClosingDate)
              .HasColumnType("datetime");

            builder.Entity<Destination.Models.destinationTest.BookingsVisited>()
              .Property(p => p.IsRespondComm)
              .HasColumnType("datetime");

            builder.Entity<Destination.Models.destinationTest.BookingsVisited>()
              .Property(p => p.MatchedOn)
              .HasColumnType("datetime");

            builder.Entity<Destination.Models.destinationTest.BookingsVisited>()
              .Property(p => p.SpaCleanedDate)
              .HasColumnType("datetime");

            builder.Entity<Destination.Models.destinationTest.BookingsCode>()
              .Property(p => p.GeneratedDate)
              .HasColumnType("datetime");

            builder.Entity<Destination.Models.destinationTest.BookingsCode>()
              .Property(p => p.ResDateTime)
              .HasColumnType("datetime");

            builder.Entity<Destination.Models.destinationTest.BookingsLogic>()
              .Property(p => p.DtDateFrom1)
              .HasColumnType("datetime");

            builder.Entity<Destination.Models.destinationTest.BookingsLogic>()
              .Property(p => p.DtDateFrom2)
              .HasColumnType("datetime");

            builder.Entity<Destination.Models.destinationTest.BookingsLogic>()
              .Property(p => p.DtCreated)
              .HasColumnType("datetime");

            builder.Entity<Destination.Models.destinationTest.BookingsLogic>()
              .Property(p => p.DtModified)
              .HasColumnType("datetime");

            builder.Entity<Destination.Models.destinationTest.BookingsLogic2>()
              .Property(p => p.DtDateFrom)
              .HasColumnType("datetime");

            builder.Entity<Destination.Models.destinationTest.BookingsLogic2>()
              .Property(p => p.DtDateTo)
              .HasColumnType("datetime");

            builder.Entity<Destination.Models.destinationTest.BookingsLogic2>()
              .Property(p => p.DtCreated)
              .HasColumnType("datetime");

            builder.Entity<Destination.Models.destinationTest.BookingsLogic2>()
              .Property(p => p.DtModified)
              .HasColumnType("datetime");

            builder.Entity<Destination.Models.destinationTest.BookingsLogic2>()
              .Property(p => p.DtDateFrom2)
              .HasColumnType("datetime");

            builder.Entity<Destination.Models.destinationTest.BookingsLogicVrbo>()
              .Property(p => p.DtDateFrom1)
              .HasColumnType("datetime");

            builder.Entity<Destination.Models.destinationTest.BookingsLogicVrbo>()
              .Property(p => p.DtDateFrom2)
              .HasColumnType("datetime");

            builder.Entity<Destination.Models.destinationTest.BookingsLogicVrbo>()
              .Property(p => p.DtCreated)
              .HasColumnType("datetime");

            builder.Entity<Destination.Models.destinationTest.BookingsLogicVrbo>()
              .Property(p => p.DtModified)
              .HasColumnType("datetime");

            builder.Entity<Destination.Models.destinationTest.BookingsOriginalPubRate>()
              .Property(p => p.OrgDateFrom)
              .HasColumnType("datetime");

            builder.Entity<Destination.Models.destinationTest.BookingsOriginalPubRate>()
              .Property(p => p.OrgDateTo)
              .HasColumnType("datetime");

            builder.Entity<Destination.Models.destinationTest.BookingsOriginalPubRate>()
              .Property(p => p.CreatedDate)
              .HasColumnType("datetime");

            builder.Entity<Destination.Models.destinationTest.Channel>()
              .Property(p => p.PermitExpiry)
              .HasColumnType("datetime");

            builder.Entity<Destination.Models.destinationTest.Channel>()
              .Property(p => p.LastSyncChangedOn)
              .HasColumnType("datetime");

            builder.Entity<Destination.Models.destinationTest.ChannelBu>()
              .Property(p => p.PermitExpiry)
              .HasColumnType("datetime");

            builder.Entity<Destination.Models.destinationTest.ChannelPartnerHit>()
              .Property(p => p.HitDate)
              .HasColumnType("datetime");

            builder.Entity<Destination.Models.destinationTest.Chatbooking>()
              .Property(p => p.Date)
              .HasColumnType("datetime");

            builder.Entity<Destination.Models.destinationTest.CheckInCheckOutSetting>()
              .Property(p => p.StartDate)
              .HasColumnType("datetime");

            builder.Entity<Destination.Models.destinationTest.CheckInCheckOutSetting>()
              .Property(p => p.EndDate)
              .HasColumnType("datetime");

            builder.Entity<Destination.Models.destinationTest.CheckInLog>()
              .Property(p => p.CheckInTime)
              .HasColumnType("datetime");

            builder.Entity<Destination.Models.destinationTest.CleanerAuditedMsg>()
              .Property(p => p.SavedDate)
              .HasColumnType("datetime");

            builder.Entity<Destination.Models.destinationTest.CleanerInvoiceMatchedDatum>()
              .Property(p => p.DateFrom)
              .HasColumnType("datetime");

            builder.Entity<Destination.Models.destinationTest.CleanerInvoiceMatchedDatum>()
              .Property(p => p.DateTo)
              .HasColumnType("datetime");

            builder.Entity<Destination.Models.destinationTest.CleanerInvoiceMatchedDatum>()
              .Property(p => p.PayDate)
              .HasColumnType("datetime");

            builder.Entity<Destination.Models.destinationTest.CleanerInvoiceMatchedDatum>()
              .Property(p => p.EnteredDate)
              .HasColumnType("datetime");

            builder.Entity<Destination.Models.destinationTest.CleanerInvoiceMatchedDatum>()
              .Property(p => p.PartialPaid)
              .HasColumnType("datetime");

            builder.Entity<Destination.Models.destinationTest.CleanerInvoiceMatchedDatum>()
              .Property(p => p.PartialMatchedOn)
              .HasColumnType("datetime");

            builder.Entity<Destination.Models.destinationTest.CleaningPayrolExtraTaskDetail>()
              .Property(p => p.DateFrom)
              .HasColumnType("datetime");

            builder.Entity<Destination.Models.destinationTest.CleaningPayrolExtraTaskDetail>()
              .Property(p => p.DateTo)
              .HasColumnType("datetime");

            builder.Entity<Destination.Models.destinationTest.CleaningPayrolExtraTaskDetail>()
              .Property(p => p.EnteredOn)
              .HasColumnType("datetime");

            builder.Entity<Destination.Models.destinationTest.CleaningPayrolExtraTaskDetail>()
              .Property(p => p.MatchedOn)
              .HasColumnType("datetime");

            builder.Entity<Destination.Models.destinationTest.CleaningPayrolExtraTaskDetail>()
              .Property(p => p.PaidDate)
              .HasColumnType("datetime");

            builder.Entity<Destination.Models.destinationTest.CleaningVariance>()
              .Property(p => p.DateFrom)
              .HasColumnType("datetime");

            builder.Entity<Destination.Models.destinationTest.CleaningVariance>()
              .Property(p => p.DateTo)
              .HasColumnType("datetime");

            builder.Entity<Destination.Models.destinationTest.Communication>()
              .Property(p => p.Commdate)
              .HasColumnType("datetime");

            builder.Entity<Destination.Models.destinationTest.ContractTable>()
              .Property(p => p.InsEffDate)
              .HasColumnType("datetime");

            builder.Entity<Destination.Models.destinationTest.ContractTable>()
              .Property(p => p.InsExpdate)
              .HasColumnType("datetime");

            builder.Entity<Destination.Models.destinationTest.ContractTable>()
              .Property(p => p.InsDateRcvd)
              .HasColumnType("datetime");

            builder.Entity<Destination.Models.destinationTest.ContractTable>()
              .Property(p => p.ContDateSigned)
              .HasColumnType("datetime");

            builder.Entity<Destination.Models.destinationTest.CoronaAnnualDatum>()
              .Property(p => p.SubmissionTime)
              .HasColumnType("datetime");

            builder.Entity<Destination.Models.destinationTest.CreditRequest>()
              .Property(p => p.ReviewedDate)
              .HasColumnType("datetime");

            builder.Entity<Destination.Models.destinationTest.CreditRequest>()
              .Property(p => p.Datefrom)
              .HasColumnType("datetime");

            builder.Entity<Destination.Models.destinationTest.CreditRequest>()
              .Property(p => p.DateTo)
              .HasColumnType("datetime");

            builder.Entity<Destination.Models.destinationTest.Currentdiscount>()
              .Property(p => p.Sdate)
              .HasColumnType("datetime");

            builder.Entity<Destination.Models.destinationTest.Currentdiscount>()
              .Property(p => p.Edate)
              .HasColumnType("datetime");

            builder.Entity<Destination.Models.destinationTest.Currentdiscount>()
              .Property(p => p.ChangeDate)
              .HasColumnType("datetime");

            builder.Entity<Destination.Models.destinationTest.CurrentDiscountsHistory>()
              .Property(p => p.Sdate)
              .HasColumnType("datetime");

            builder.Entity<Destination.Models.destinationTest.CurrentDiscountsHistory>()
              .Property(p => p.Edate)
              .HasColumnType("datetime");

            builder.Entity<Destination.Models.destinationTest.CurrentDiscountsHistory>()
              .Property(p => p.ChangeDate)
              .HasColumnType("datetime");

            builder.Entity<Destination.Models.destinationTest.CurrentDiscountsHistory>()
              .Property(p => p.CreatedDate)
              .HasColumnType("datetime");

            builder.Entity<Destination.Models.destinationTest.DailyProcessedMinNight>()
              .Property(p => p.CreatedDate)
              .HasColumnType("datetime");

            builder.Entity<Destination.Models.destinationTest.DailyProcessedMinNight>()
              .Property(p => p.EffectiveDate)
              .HasColumnType("datetime");

            builder.Entity<Destination.Models.destinationTest.DailyRatesBasedOnPropertyRate>()
              .Property(p => p.DateStart)
              .HasColumnType("datetime");

            builder.Entity<Destination.Models.destinationTest.DailyRatesBasedOnPropertyRate>()
              .Property(p => p.DateEnd)
              .HasColumnType("datetime");

            builder.Entity<Destination.Models.destinationTest.DailyStat>()
              .Property(p => p.DtCreated)
              .HasColumnType("datetime");

            builder.Entity<Destination.Models.destinationTest.DeletedGapHolderBooking>()
              .Property(p => p.DateFrom)
              .HasColumnType("datetime");

            builder.Entity<Destination.Models.destinationTest.DeletedGapHolderBooking>()
              .Property(p => p.DateTo)
              .HasColumnType("datetime");

            builder.Entity<Destination.Models.destinationTest.DeletedGapHolderBooking>()
              .Property(p => p.EnteredDate)
              .HasColumnType("datetime");

            builder.Entity<Destination.Models.destinationTest.DepositHoldLog>()
              .Property(p => p.CreatedOn)
              .HasColumnType("datetime");

            builder.Entity<Destination.Models.destinationTest.DoNotRent>()
              .Property(p => p.DateOpened)
              .HasColumnType("datetime");

            builder.Entity<Destination.Models.destinationTest.DoNotRent>()
              .Property(p => p.CloseDate)
              .HasColumnType("datetime");

            builder.Entity<Destination.Models.destinationTest.DoNotRent>()
              .Property(p => p.LastUpdated)
              .HasColumnType("datetime");

            builder.Entity<Destination.Models.destinationTest.DoorCodeLog>()
              .Property(p => p.ChangeDate)
              .HasColumnType("datetime");

            builder.Entity<Destination.Models.destinationTest.EmailRemoveList>()
              .Property(p => p.Removedate)
              .HasColumnType("datetime");

            builder.Entity<Destination.Models.destinationTest.EmailRemoveList1>()
              .Property(p => p.Removedate)
              .HasColumnType("datetime");

            builder.Entity<Destination.Models.destinationTest.EventDate>()
              .Property(p => p.StartDate)
              .HasColumnType("datetime");

            builder.Entity<Destination.Models.destinationTest.EventDate>()
              .Property(p => p.EndDate)
              .HasColumnType("datetime");

            builder.Entity<Destination.Models.destinationTest.Favorite>()
              .Property(p => p.DtCreated)
              .HasColumnType("datetime");

            builder.Entity<Destination.Models.destinationTest.Favorite>()
              .Property(p => p.DateFrom)
              .HasColumnType("datetime");

            builder.Entity<Destination.Models.destinationTest.Favorite>()
              .Property(p => p.DateTo)
              .HasColumnType("datetime");

            builder.Entity<Destination.Models.destinationTest.FilterDataForBulkSmsMail>()
              .Property(p => p.InquiryDateFrom)
              .HasColumnType("datetime");

            builder.Entity<Destination.Models.destinationTest.FilterDataForBulkSmsMail>()
              .Property(p => p.InquiryDateTo)
              .HasColumnType("datetime");

            builder.Entity<Destination.Models.destinationTest.FilterDataForBulkSmsMail>()
              .Property(p => p.BookedDateFrom)
              .HasColumnType("datetime");

            builder.Entity<Destination.Models.destinationTest.FilterDataForBulkSmsMail>()
              .Property(p => p.BookedDateTo)
              .HasColumnType("datetime");

            builder.Entity<Destination.Models.destinationTest.FilterDataForBulkSmsMail>()
              .Property(p => p.LastUpdatedFrom)
              .HasColumnType("datetime");

            builder.Entity<Destination.Models.destinationTest.FilterDataForBulkSmsMail>()
              .Property(p => p.LastUpdatedTo)
              .HasColumnType("datetime");

            builder.Entity<Destination.Models.destinationTest.FilterDataForBulkSmsMail>()
              .Property(p => p.DateFrom1)
              .HasColumnType("datetime");

            builder.Entity<Destination.Models.destinationTest.FilterDataForBulkSmsMail>()
              .Property(p => p.DateFrom2)
              .HasColumnType("datetime");

            builder.Entity<Destination.Models.destinationTest.FilterDataForBulkSmsMail>()
              .Property(p => p.DateTo1)
              .HasColumnType("datetime");

            builder.Entity<Destination.Models.destinationTest.FilterDataForBulkSmsMail>()
              .Property(p => p.Dateto2)
              .HasColumnType("datetime");

            builder.Entity<Destination.Models.destinationTest.FilterDataForBulkSmsMail>()
              .Property(p => p.SentOn)
              .HasColumnType("datetime");

            builder.Entity<Destination.Models.destinationTest.GoogleUsersKeyword>()
              .Property(p => p.EnteredOn)
              .HasColumnType("datetime");

            builder.Entity<Destination.Models.destinationTest.InntopiaCallLog>()
              .Property(p => p.CreatedDate)
              .HasColumnType("datetime");

            builder.Entity<Destination.Models.destinationTest.InntopiaPushTimeLog>()
              .Property(p => p.PushTime)
              .HasColumnType("datetime");

            builder.Entity<Destination.Models.destinationTest.InntopiaAudit>()
              .Property(p => p.RequestDateTime)
              .HasColumnType("datetime");

            builder.Entity<Destination.Models.destinationTest.InntopiaBooking>()
              .Property(p => p.CheckInDate)
              .HasColumnType("datetime");

            builder.Entity<Destination.Models.destinationTest.InntopiaBooking>()
              .Property(p => p.CheckOutDate)
              .HasColumnType("datetime");

            builder.Entity<Destination.Models.destinationTest.InntopiaBooking>()
              .Property(p => p.EnteredOn)
              .HasColumnType("datetime");

            builder.Entity<Destination.Models.destinationTest.InntopiaBooking>()
              .Property(p => p.ModifiedOn)
              .HasColumnType("datetime");

            builder.Entity<Destination.Models.destinationTest.InquiryNa>()
              .Property(p => p.StartDate)
              .HasColumnType("datetime");

            builder.Entity<Destination.Models.destinationTest.InquiryNa>()
              .Property(p => p.EnteredOn)
              .HasColumnType("datetime");

            builder.Entity<Destination.Models.destinationTest.InspectionPlan>()
              .Property(p => p.EnteredDate)
              .HasColumnType("datetime");

            builder.Entity<Destination.Models.destinationTest.InstructionAgent>()
              .Property(p => p.Datereviewed)
              .HasColumnType("datetime");

            builder.Entity<Destination.Models.destinationTest.LargeGroupBooking>()
              .Property(p => p.DateEntered)
              .HasColumnType("datetime");

            builder.Entity<Destination.Models.destinationTest.LogEditPropertyDescription>()
              .Property(p => p.UpdatedOn)
              .HasColumnType("datetime");

            builder.Entity<Destination.Models.destinationTest.LogDoorCodes2020>()
              .Property(p => p.DateChanged)
              .HasColumnType("datetime");

            builder.Entity<Destination.Models.destinationTest.MaintenanceAction>()
              .Property(p => p.DtCreated)
              .HasColumnType("datetime");

            builder.Entity<Destination.Models.destinationTest.MarketingReview>()
              .Property(p => p.Datereviewed)
              .HasColumnType("datetime");

            builder.Entity<Destination.Models.destinationTest.NoWord>()
              .Property(p => p.EnteredOn)
              .HasColumnType("datetime");

            builder.Entity<Destination.Models.destinationTest.OffhoursListForSmsroutine>()
              .Property(p => p.StartDate)
              .HasColumnType("datetime");

            builder.Entity<Destination.Models.destinationTest.OffhoursListForSmsroutine>()
              .Property(p => p.EndDate)
              .HasColumnType("datetime");

            builder.Entity<Destination.Models.destinationTest.OlarkZapier>()
              .Property(p => p.EnteredOn)
              .HasColumnType("datetime");

            builder.Entity<Destination.Models.destinationTest.OlarkZapierNew>()
              .Property(p => p.EnteredOn)
              .HasColumnType("datetime");

            builder.Entity<Destination.Models.destinationTest.OpinionStageSurveyLeadsRepor>()
              .Property(p => p.SubmissionTime)
              .HasColumnType("datetime");

            builder.Entity<Destination.Models.destinationTest.OwnerCommunication>()
              .Property(p => p.Cdate)
              .HasColumnType("datetime");

            builder.Entity<Destination.Models.destinationTest.OwnerUpdate>()
              .Property(p => p.DateCreated)
              .HasColumnType("datetime");

            builder.Entity<Destination.Models.destinationTest.Payment>()
              .Property(p => p.DtCreated)
              .HasColumnType("datetime");

            builder.Entity<Destination.Models.destinationTest.Payment>()
              .Property(p => p.DtModified)
              .HasColumnType("datetime");

            builder.Entity<Destination.Models.destinationTest.PaymentLogDoubleRefunded>()
              .Property(p => p.DtCreated)
              .HasColumnType("datetime");

            builder.Entity<Destination.Models.destinationTest.PaymentLogDoubleRefunded>()
              .Property(p => p.DtModified)
              .HasColumnType("datetime");

            builder.Entity<Destination.Models.destinationTest.Performa>()
              .Property(p => p.CreatedDate)
              .HasColumnType("datetime");

            builder.Entity<Destination.Models.destinationTest.PhoneCallLog>()
              .Property(p => p.CreatedOn)
              .HasColumnType("datetime");

            builder.Entity<Destination.Models.destinationTest.PhoneCallLog>()
              .Property(p => p.DateOfCall)
              .HasColumnType("datetime");

            builder.Entity<Destination.Models.destinationTest.PinkSheetNote>()
              .Property(p => p.EnteredOn)
              .HasColumnType("datetime");

            builder.Entity<Destination.Models.destinationTest.ProcGetLastBookingDetail>()
              .Property(p => p.Datefrom)
              .HasColumnType("datetime");

            builder.Entity<Destination.Models.destinationTest.ProcGetLastBookingDetail>()
              .Property(p => p.Dateto)
              .HasColumnType("datetime");

            builder.Entity<Destination.Models.destinationTest.ProcGetLastBookingDetail>()
              .Property(p => p.InspectDate)
              .HasColumnType("datetime");

            builder.Entity<Destination.Models.destinationTest.ProcGetLastBookingDetail>()
              .Property(p => p.CleanDate)
              .HasColumnType("datetime");

            builder.Entity<Destination.Models.destinationTest.PromoCode>()
              .Property(p => p.FromDate)
              .HasColumnType("datetime");

            builder.Entity<Destination.Models.destinationTest.PromoCode>()
              .Property(p => p.ToDate)
              .HasColumnType("datetime");

            builder.Entity<Destination.Models.destinationTest.Promotion>()
              .Property(p => p.DateFrom)
              .HasColumnType("datetime");

            builder.Entity<Destination.Models.destinationTest.Promotion>()
              .Property(p => p.DateTo)
              .HasColumnType("datetime");

            builder.Entity<Destination.Models.destinationTest.Promotion>()
              .Property(p => p.CreatedOn)
              .HasColumnType("datetime");

            builder.Entity<Destination.Models.destinationTest.Property>()
              .Property(p => p.DateCreated)
              .HasColumnType("datetime");

            builder.Entity<Destination.Models.destinationTest.Property>()
              .Property(p => p.DateLastUpdated)
              .HasColumnType("datetime");

            builder.Entity<Destination.Models.destinationTest.Property>()
              .Property(p => p.Available)
              .HasColumnType("datetime");

            builder.Entity<Destination.Models.destinationTest.Property>()
              .Property(p => p.Cityinspectdate)
              .HasColumnType("datetime");

            builder.Entity<Destination.Models.destinationTest.Property>()
              .Property(p => p.Inspectiondatemgt)
              .HasColumnType("datetime");

            builder.Entity<Destination.Models.destinationTest.Property>()
              .Property(p => p.DateClosed)
              .HasColumnType("datetime");

            builder.Entity<Destination.Models.destinationTest.PropertyActivationDate>()
              .Property(p => p.ActivateDate)
              .HasColumnType("datetime");

            builder.Entity<Destination.Models.destinationTest.PropertyCleaner>()
              .Property(p => p.Lastraise)
              .HasColumnType("datetime");

            builder.Entity<Destination.Models.destinationTest.PropertyCleaner>()
              .Property(p => p.Lastcontact)
              .HasColumnType("datetime");

            builder.Entity<Destination.Models.destinationTest.PropertyContent>()
              .Property(p => p.Date)
              .HasColumnType("datetime");

            builder.Entity<Destination.Models.destinationTest.PropertyContent>()
              .Property(p => p.Lasttouched)
              .HasColumnType("datetime");

            builder.Entity<Destination.Models.destinationTest.PropertyExpenseBlankRecord>()
              .Property(p => p.Dateentered)
              .HasColumnType("datetime");

            builder.Entity<Destination.Models.destinationTest.PropertyExpenseBlankRecord>()
              .Property(p => p.Datecompleted)
              .HasColumnType("datetime");

            builder.Entity<Destination.Models.destinationTest.PropertyExpenseBlankRecord>()
              .Property(p => p.Datetocomp)
              .HasColumnType("datetime");

            builder.Entity<Destination.Models.destinationTest.PropertyExpense>()
              .Property(p => p.Dateentered)
              .HasColumnType("datetime");

            builder.Entity<Destination.Models.destinationTest.PropertyExpense>()
              .Property(p => p.Datecompleted)
              .HasColumnType("datetime");

            builder.Entity<Destination.Models.destinationTest.PropertyExpense>()
              .Property(p => p.Datetocomp)
              .HasColumnType("datetime");

            builder.Entity<Destination.Models.destinationTest.PropertyExpense>()
              .Property(p => p.PlannedDate)
              .HasColumnType("datetime");

            builder.Entity<Destination.Models.destinationTest.PropertyExpensesDeleted>()
              .Property(p => p.Dateentered)
              .HasColumnType("datetime");

            builder.Entity<Destination.Models.destinationTest.PropertyExpensesDeleted>()
              .Property(p => p.Datecompleted)
              .HasColumnType("datetime");

            builder.Entity<Destination.Models.destinationTest.PropertyExpensesDeleted>()
              .Property(p => p.Datetocomp)
              .HasColumnType("datetime");

            builder.Entity<Destination.Models.destinationTest.PropertyExpensesDeleted>()
              .Property(p => p.PlannedDate)
              .HasColumnType("datetime");

            builder.Entity<Destination.Models.destinationTest.PropertyImprovement>()
              .Property(p => p.DateOpen2)
              .HasColumnType("datetime");

            builder.Entity<Destination.Models.destinationTest.PropertyImprovement>()
              .Property(p => p.ModifiedDate)
              .HasColumnType("datetime");

            builder.Entity<Destination.Models.destinationTest.PropertyLastNextBookingDetail>()
              .Property(p => p.LastCleanDate)
              .HasColumnType("datetime");

            builder.Entity<Destination.Models.destinationTest.PropertyRatesTracking>()
              .Property(p => p.DateChanged)
              .HasColumnType("datetime");

            builder.Entity<Destination.Models.destinationTest.PropertyAnnualLog>()
              .Property(p => p.LastUpdated)
              .HasColumnType("datetime");

            builder.Entity<Destination.Models.destinationTest.PropertyBackToBackBookingsRestrict>()
              .Property(p => p.StartDate)
              .HasColumnType("datetime");

            builder.Entity<Destination.Models.destinationTest.PropertyBackToBackBookingsRestrict>()
              .Property(p => p.EndDate)
              .HasColumnType("datetime");

            builder.Entity<Destination.Models.destinationTest.PropertyFulltime>()
              .Property(p => p.When)
              .HasColumnType("datetime");

            builder.Entity<Destination.Models.destinationTest.PropertyInsurance>()
              .Property(p => p.PermitRenewalDate)
              .HasColumnType("datetime");

            builder.Entity<Destination.Models.destinationTest.PropertyInsurance>()
              .Property(p => p.Expiration)
              .HasColumnType("datetime");

            builder.Entity<Destination.Models.destinationTest.PropertyInsuranceCity>()
              .Property(p => p.PermitRenewalDate)
              .HasColumnType("datetime");

            builder.Entity<Destination.Models.destinationTest.PropertyInsuranceCity>()
              .Property(p => p.Expiration)
              .HasColumnType("datetime");

            builder.Entity<Destination.Models.destinationTest.PropertyInsuranceCounty>()
              .Property(p => p.PermitExpiration)
              .HasColumnType("datetime");

            builder.Entity<Destination.Models.destinationTest.PropertyRatesDaily>()
              .Property(p => p.DateStart)
              .HasColumnType("datetime");

            builder.Entity<Destination.Models.destinationTest.PropertyRatesDaily>()
              .Property(p => p.DateEnd)
              .HasColumnType("datetime");

            builder.Entity<Destination.Models.destinationTest.PropertyRatesDailySingleProp>()
              .Property(p => p.DateStart)
              .HasColumnType("datetime");

            builder.Entity<Destination.Models.destinationTest.PropertyRatesDailySingleProp>()
              .Property(p => p.DateEnd)
              .HasColumnType("datetime");

            builder.Entity<Destination.Models.destinationTest.PropertyRatesDailyTemp>()
              .Property(p => p.DateStart)
              .HasColumnType("datetime");

            builder.Entity<Destination.Models.destinationTest.PropertyRatesDailyTemp>()
              .Property(p => p.DateEnd)
              .HasColumnType("datetime");

            builder.Entity<Destination.Models.destinationTest.PropertyRatesDailyMinRate>()
              .Property(p => p.DateStart)
              .HasColumnType("datetime");

            builder.Entity<Destination.Models.destinationTest.PropertyRatesDailyMinRate>()
              .Property(p => p.DateEnd)
              .HasColumnType("datetime");

            builder.Entity<Destination.Models.destinationTest.PropertyVisitCount>()
              .Property(p => p.VisitedOn)
              .HasColumnType("datetime");

            builder.Entity<Destination.Models.destinationTest.PropertyVisitCount>()
              .Property(p => p.DateFrom)
              .HasColumnType("datetime");

            builder.Entity<Destination.Models.destinationTest.PropertyVisitCount>()
              .Property(p => p.DateTo)
              .HasColumnType("datetime");

            builder.Entity<Destination.Models.destinationTest.RateReview>()
              .Property(p => p.ReviewDate)
              .HasColumnType("datetime");

            builder.Entity<Destination.Models.destinationTest.RatesMin>()
              .Property(p => p.StartDate)
              .HasColumnType("datetime");

            builder.Entity<Destination.Models.destinationTest.RatesMin>()
              .Property(p => p.EndDate)
              .HasColumnType("datetime");

            builder.Entity<Destination.Models.destinationTest.Review>()
              .Property(p => p.LastUpdatedDate)
              .HasColumnType("datetime");

            builder.Entity<Destination.Models.destinationTest.Review>()
              .Property(p => p.DateFrom)
              .HasColumnType("datetime");

            builder.Entity<Destination.Models.destinationTest.Search>()
              .Property(p => p.DtCreated)
              .HasColumnType("datetime");

            builder.Entity<Destination.Models.destinationTest.SendAirbnbCheckOutReply>()
              .Property(p => p.InsertedAt)
              .HasColumnType("datetime");

            builder.Entity<Destination.Models.destinationTest.SendAirbnbCheckOutReply>()
              .Property(p => p.SentAt)
              .HasColumnType("datetime");

            builder.Entity<Destination.Models.destinationTest.SendTwilioSm>()
              .Property(p => p.CreatedDate)
              .HasColumnType("datetime");

            builder.Entity<Destination.Models.destinationTest.SendTwilioSm>()
              .Property(p => p.UpdatedAt)
              .HasColumnType("datetime");

            builder.Entity<Destination.Models.destinationTest.SendTwilioSmsQueue>()
              .Property(p => p.CreatedDate)
              .HasColumnType("datetime");

            builder.Entity<Destination.Models.destinationTest.Sheet1>()
              .Property(p => p.DateChanged)
              .HasColumnType("datetime");

            builder.Entity<Destination.Models.destinationTest.Smsmessage>()
              .Property(p => p.MessageDate)
              .HasColumnType("datetime");

            builder.Entity<Destination.Models.destinationTest.SmsRemoveList>()
              .Property(p => p.Removedate)
              .HasColumnType("datetime");

            builder.Entity<Destination.Models.destinationTest.Smstemplate>()
              .Property(p => p.DtCreated)
              .HasColumnType("datetime");

            builder.Entity<Destination.Models.destinationTest.Smstemplate>()
              .Property(p => p.LastUpdated)
              .HasColumnType("datetime");

            builder.Entity<Destination.Models.destinationTest.SpaTransaction>()
              .Property(p => p.DateCleaned)
              .HasColumnType("datetime");

            builder.Entity<Destination.Models.destinationTest.TblAirbnbExportTemp>()
              .Property(p => p.StartDate)
              .HasColumnType("datetime");

            builder.Entity<Destination.Models.destinationTest.TblAirbnbExportTemp>()
              .Property(p => p.EndDate)
              .HasColumnType("datetime");

            builder.Entity<Destination.Models.destinationTest.TblBookingInterest>()
              .Property(p => p.LoggedDate)
              .HasColumnType("datetime");

            builder.Entity<Destination.Models.destinationTest.TblBulkEmailLog>()
              .Property(p => p.InquiryDateFrom)
              .HasColumnType("datetime");

            builder.Entity<Destination.Models.destinationTest.TblBulkEmailLog>()
              .Property(p => p.InquiryDateTo)
              .HasColumnType("datetime");

            builder.Entity<Destination.Models.destinationTest.TblBulkEmailLog>()
              .Property(p => p.SentOn)
              .HasColumnType("datetime");

            builder.Entity<Destination.Models.destinationTest.TblBulkEmailLog>()
              .Property(p => p.DateFrom1)
              .HasColumnType("datetime");

            builder.Entity<Destination.Models.destinationTest.TblBulkEmailLog>()
              .Property(p => p.DateFrom2)
              .HasColumnType("datetime");

            builder.Entity<Destination.Models.destinationTest.TblBulkEmailLog>()
              .Property(p => p.DateTo1)
              .HasColumnType("datetime");

            builder.Entity<Destination.Models.destinationTest.TblBulkEmailLog>()
              .Property(p => p.DateTo2)
              .HasColumnType("datetime");

            builder.Entity<Destination.Models.destinationTest.TblBulkEmailLog>()
              .Property(p => p.BookedDateFrom)
              .HasColumnType("datetime");

            builder.Entity<Destination.Models.destinationTest.TblBulkEmailLog>()
              .Property(p => p.BookedDateTo)
              .HasColumnType("datetime");

            builder.Entity<Destination.Models.destinationTest.TblBulkEmailLog>()
              .Property(p => p.LastUpdatedFrom)
              .HasColumnType("datetime");

            builder.Entity<Destination.Models.destinationTest.TblBulkEmailLog>()
              .Property(p => p.LastUpdatedTo)
              .HasColumnType("datetime");

            builder.Entity<Destination.Models.destinationTest.TblDebug>()
              .Property(p => p.DtCreated)
              .HasColumnType("datetime");

            builder.Entity<Destination.Models.destinationTest.TblMultiDayDiscount>()
              .Property(p => p.StartDate)
              .HasColumnType("datetime");

            builder.Entity<Destination.Models.destinationTest.TblMultiDayDiscount>()
              .Property(p => p.EndDate)
              .HasColumnType("datetime");

            builder.Entity<Destination.Models.destinationTest.TblNotAvtivePropertyBooking>()
              .Property(p => p.DateTimeStamp)
              .HasColumnType("datetime");

            builder.Entity<Destination.Models.destinationTest.TblNotSendingEmail>()
              .Property(p => p.SentOn)
              .HasColumnType("datetime");

            builder.Entity<Destination.Models.destinationTest.TblPartialCheckIn>()
              .Property(p => p.DateTimeStamp)
              .HasColumnType("datetime");

            builder.Entity<Destination.Models.destinationTest.TblPropertyActiveInactiveTrackForFlipkeyFeed>()
              .Property(p => p.UpdatedDate)
              .HasColumnType("datetime");

            builder.Entity<Destination.Models.destinationTest.TblPropertyRatesDailyMissedDatesProp>()
              .Property(p => p.MissedDate)
              .HasColumnType("datetime");

            builder.Entity<Destination.Models.destinationTest.TblrateTemp>()
              .Property(p => p.DateStart)
              .HasColumnType("datetime");

            builder.Entity<Destination.Models.destinationTest.TblTrackDailyRatesExecutionForProperty>()
              .Property(p => p.ExecTime)
              .HasColumnType("datetime");

            builder.Entity<Destination.Models.destinationTest.TempCom>()
              .Property(p => p.MsgDate)
              .HasColumnType("datetime");

            builder.Entity<Destination.Models.destinationTest.Template>()
              .Property(p => p.DtCreated)
              .HasColumnType("datetime");

            builder.Entity<Destination.Models.destinationTest.Template>()
              .Property(p => p.LastUpdated)
              .HasColumnType("datetime");

            builder.Entity<Destination.Models.destinationTest.Tenant>()
              .Property(p => p.Datefrom)
              .HasColumnType("datetime");

            builder.Entity<Destination.Models.destinationTest.Tenant>()
              .Property(p => p.Dateto)
              .HasColumnType("datetime");

            builder.Entity<Destination.Models.destinationTest.Tenant>()
              .Property(p => p.Begdate)
              .HasColumnType("datetime");

            builder.Entity<Destination.Models.destinationTest.Tenant>()
              .Property(p => p.LastVisited)
              .HasColumnType("datetime");

            builder.Entity<Destination.Models.destinationTest.TenantCheckInPhoto>()
              .Property(p => p.UploadedOn)
              .HasColumnType("datetime");

            builder.Entity<Destination.Models.destinationTest.TenantInterestDatum>()
              .Property(p => p.SubmissionTime)
              .HasColumnType("datetime");

            builder.Entity<Destination.Models.destinationTest.TenantOrderAlertEmailMessage>()
              .Property(p => p.DtCreated)
              .HasColumnType("datetime");

            builder.Entity<Destination.Models.destinationTest.TenantWithPlusOneInCell>()
              .Property(p => p.Datefrom)
              .HasColumnType("datetime");

            builder.Entity<Destination.Models.destinationTest.TenantWithPlusOneInCell>()
              .Property(p => p.Dateto)
              .HasColumnType("datetime");

            builder.Entity<Destination.Models.destinationTest.TenantWithPlusOneInCell>()
              .Property(p => p.Begdate)
              .HasColumnType("datetime");

            builder.Entity<Destination.Models.destinationTest.TestTable>()
              .Property(p => p.CreatedOn)
              .HasColumnType("datetime");

            builder.Entity<Destination.Models.destinationTest.TestTableForDailyRoutine>()
              .Property(p => p.ExecutedOn)
              .HasColumnType("datetime");

            builder.Entity<Destination.Models.destinationTest.TrackClosedPastBooking>()
              .Property(p => p.Datefrom)
              .HasColumnType("datetime");

            builder.Entity<Destination.Models.destinationTest.TrackClosedPastBooking>()
              .Property(p => p.Dateto)
              .HasColumnType("datetime");

            builder.Entity<Destination.Models.destinationTest.TrackClosedPastBooking>()
              .Property(p => p.PunchDate)
              .HasColumnType("datetime");

            builder.Entity<Destination.Models.destinationTest.TrackedCampaign>()
              .Property(p => p.VisitedOn)
              .HasColumnType("datetime");

            builder.Entity<Destination.Models.destinationTest.TrackedCampaign>()
              .Property(p => p.FromDate)
              .HasColumnType("datetime");

            builder.Entity<Destination.Models.destinationTest.TrackedCampaign>()
              .Property(p => p.ToDate)
              .HasColumnType("datetime");

            builder.Entity<Destination.Models.destinationTest.TrackedUser>()
              .Property(p => p.VisitedOn)
              .HasColumnType("datetime");

            builder.Entity<Destination.Models.destinationTest.TrackedUser>()
              .Property(p => p.FromDate)
              .HasColumnType("datetime");

            builder.Entity<Destination.Models.destinationTest.TrackedUser>()
              .Property(p => p.ToDate)
              .HasColumnType("datetime");

            builder.Entity<Destination.Models.destinationTest.TrainingScore>()
              .Property(p => p.DtCreated)
              .HasColumnType("datetime");

            builder.Entity<Destination.Models.destinationTest.UvGetBackToBackCheckInsPerDay>()
              .Property(p => p.Dateto)
              .HasColumnType("datetime");

            builder.Entity<Destination.Models.destinationTest.UvGetBookingBackToBackCount>()
              .Property(p => p.DateFrom)
              .HasColumnType("datetime");

            builder.Entity<Destination.Models.destinationTest.UvGetBooking>()
              .Property(p => p.Datefrom)
              .HasColumnType("datetime");

            builder.Entity<Destination.Models.destinationTest.UvGetBooking>()
              .Property(p => p.Dateto)
              .HasColumnType("datetime");

            builder.Entity<Destination.Models.destinationTest.UvGetBooking>()
              .Property(p => p.Bookingdate)
              .HasColumnType("datetime");

            builder.Entity<Destination.Models.destinationTest.UvGetBooking>()
              .Property(p => p.InquiryDate)
              .HasColumnType("datetime");

            builder.Entity<Destination.Models.destinationTest.UvGetBooking>()
              .Property(p => p.LastUpdated)
              .HasColumnType("datetime");

            builder.Entity<Destination.Models.destinationTest.UvGetBooking>()
              .Property(p => p.CleanDate1)
              .HasColumnType("datetime");

            builder.Entity<Destination.Models.destinationTest.UvGetBooking>()
              .Property(p => p.InspectDate1)
              .HasColumnType("datetime");

            builder.Entity<Destination.Models.destinationTest.UvGetBooking>()
              .Property(p => p.DepositDate1)
              .HasColumnType("datetime");

            builder.Entity<Destination.Models.destinationTest.UvGetBooking>()
              .Property(p => p.BookingUpdate)
              .HasColumnType("datetime");

            builder.Entity<Destination.Models.destinationTest.UvGetBooking>()
              .Property(p => p.ClosingDate)
              .HasColumnType("datetime");

            builder.Entity<Destination.Models.destinationTest.UvGetTotalCheckInsPerDay>()
              .Property(p => p.Datefrom)
              .HasColumnType("datetime");

            builder.Entity<Destination.Models.destinationTest.ViewRevenue>()
              .Property(p => p.Datefrom)
              .HasColumnType("datetime");

            builder.Entity<Destination.Models.destinationTest.ViewRevenue>()
              .Property(p => p.Dateto)
              .HasColumnType("datetime");

            builder.Entity<Destination.Models.destinationTest.VoiceMail>()
              .Property(p => p.DateCreated)
              .HasColumnType("datetime");

            builder.Entity<Destination.Models.destinationTest.VonageTsheet>()
              .Property(p => p.EnteredOn)
              .HasColumnType("datetime");

            builder.Entity<Destination.Models.destinationTest.VrboErrorLogForBookingRequest>()
              .Property(p => p.ErrorTime)
              .HasColumnType("datetime");

            builder.Entity<Destination.Models.destinationTest.Vrboimage>()
              .Property(p => p.DateOfChange)
              .HasColumnType("datetime");

            builder.Entity<Destination.Models.destinationTest.Vrboimage>()
              .Property(p => p.CreatedDate)
              .HasColumnType("datetime");

            builder.Entity<Destination.Models.destinationTest.Vrboimage>()
              .Property(p => p.ModifyDate)
              .HasColumnType("datetime");

            builder.Entity<Destination.Models.destinationTest.VrboImage1>()
              .Property(p => p.DateOfChange)
              .HasColumnType("datetime");

            builder.Entity<Destination.Models.destinationTest.VrboImage1>()
              .Property(p => p.CreatedDate)
              .HasColumnType("datetime");

            builder.Entity<Destination.Models.destinationTest.VrboImage1>()
              .Property(p => p.ModifyDate)
              .HasColumnType("datetime");

            builder.Entity<Destination.Models.destinationTest.VrboimageDetail>()
              .Property(p => p.LastUpdated)
              .HasColumnType("datetime");

            builder.Entity<Destination.Models.destinationTest.VrboimageDetail>()
              .Property(p => p.FileLastWriteTime)
              .HasColumnType("datetime");

            builder.Entity<Destination.Models.destinationTest.VrboImageDetailBackup>()
              .Property(p => p.LastUpdated)
              .HasColumnType("datetime");

            builder.Entity<Destination.Models.destinationTest.VrboImageDetailBackup>()
              .Property(p => p.FileLastWriteTime)
              .HasColumnType("datetime");

            builder.Entity<Destination.Models.destinationTest.VwFutureBooking>()
              .Property(p => p.LastDateFrom)
              .HasColumnType("datetime");

            builder.Entity<Destination.Models.destinationTest.VwGetCommMax>()
              .Property(p => p.Commdate)
              .HasColumnType("datetime");

            builder.Entity<Destination.Models.destinationTest.VwGetMinuteDifference>()
              .Property(p => p.LastvisitedOn)
              .HasColumnType("datetime");

            builder.Entity<Destination.Models.destinationTest.VwGetTrackedUser>()
              .Property(p => p.LastVisitedOn)
              .HasColumnType("datetime");

            builder.Entity<Destination.Models.destinationTest.VwGetClosestBookingWithCleaningStatus>()
              .Property(p => p.Dateto)
              .HasColumnType("datetime");

            builder.Entity<Destination.Models.destinationTest.VwGetclosestwithDate>()
              .Property(p => p.Dateto)
              .HasColumnType("datetime");

            builder.Entity<Destination.Models.destinationTest.VwGetCommMax1>()
              .Property(p => p.Commdate)
              .HasColumnType("datetime");

            builder.Entity<Destination.Models.destinationTest.VwGetInspectionDateMgtForAllActiveProp>()
              .Property(p => p.InsMgtDate)
              .HasColumnType("datetime");

            builder.Entity<Destination.Models.destinationTest.VwGetLastDateCompletedFromExpense>()
              .Property(p => p.ClosedDate)
              .HasColumnType("datetime");

            builder.Entity<Destination.Models.destinationTest.VwGetLastInspectedDateForAllActiveProp>()
              .Property(p => p.InspectedDate)
              .HasColumnType("datetime");

            builder.Entity<Destination.Models.destinationTest.VwGetLastRateChanged>()
              .Property(p => p.LastUpdated)
              .HasColumnType("datetime");

            builder.Entity<Destination.Models.destinationTest.VwGetNetSum>()
              .Property(p => p.Datefrom)
              .HasColumnType("datetime");

            builder.Entity<Destination.Models.destinationTest.VwGetNetSum>()
              .Property(p => p.Dateto)
              .HasColumnType("datetime");

            builder.Entity<Destination.Models.destinationTest.VwGetNetSum>()
              .Property(p => p.Bookingdate)
              .HasColumnType("datetime");

            builder.Entity<Destination.Models.destinationTest.VwGetNextBooking>()
              .Property(p => p.NextdateFrom)
              .HasColumnType("datetime");

            builder.Entity<Destination.Models.destinationTest.VwGetNextOwnerBooking>()
              .Property(p => p.NextdateFrom)
              .HasColumnType("datetime");

            builder.Entity<Destination.Models.destinationTest.VwGetPropClosestDatewithCleaner>()
              .Property(p => p.Dateto)
              .HasColumnType("datetime");

            builder.Entity<Destination.Models.destinationTest.VwGetPropertyExpense>()
              .Property(p => p.Datecompleted)
              .HasColumnType("datetime");

            builder.Entity<Destination.Models.destinationTest.VwGetTrackedUser1>()
              .Property(p => p.LastVisitedOn)
              .HasColumnType("datetime");

            builder.Entity<Destination.Models.destinationTest.VwGetUniqueTenant>()
              .Property(p => p.VisitedOn)
              .HasColumnType("datetime");

            builder.Entity<Destination.Models.destinationTest.VwGetWorkingBooking>()
              .Property(p => p.CheckOutDate)
              .HasColumnType("datetime");

            builder.Entity<Destination.Models.destinationTest.VwGetWorkingBooking>()
              .Property(p => p.Datefrom)
              .HasColumnType("datetime");

            builder.Entity<Destination.Models.destinationTest.VwGetWorkingBooking>()
              .Property(p => p.Dateto)
              .HasColumnType("datetime");

            builder.Entity<Destination.Models.destinationTest.VwGetWorkingBooking>()
              .Property(p => p.Bookingdate)
              .HasColumnType("datetime");

            builder.Entity<Destination.Models.destinationTest.VwGetWorkingBooking>()
              .Property(p => p.InquiryDate)
              .HasColumnType("datetime");

            builder.Entity<Destination.Models.destinationTest.VwGetWorkingBooking>()
              .Property(p => p.LastUpdated)
              .HasColumnType("datetime");

            builder.Entity<Destination.Models.destinationTest.VwGetWorkingBooking>()
              .Property(p => p.CleanDate1)
              .HasColumnType("datetime");

            builder.Entity<Destination.Models.destinationTest.VwGetWorkingBooking>()
              .Property(p => p.InspectDate1)
              .HasColumnType("datetime");

            builder.Entity<Destination.Models.destinationTest.VwGetWorkingBooking>()
              .Property(p => p.DepositDate1)
              .HasColumnType("datetime");

            builder.Entity<Destination.Models.destinationTest.VwGetWorkingBooking>()
              .Property(p => p.BookingUpdate)
              .HasColumnType("datetime");

            builder.Entity<Destination.Models.destinationTest.VwGetWorkingBooking>()
              .Property(p => p.ClosingDate)
              .HasColumnType("datetime");

            builder.Entity<Destination.Models.destinationTest.VwGetWorkingBooking>()
              .Property(p => p.IsRespondComm)
              .HasColumnType("datetime");

            builder.Entity<Destination.Models.destinationTest.VwGetWorkingBooking>()
              .Property(p => p.MatchedOn)
              .HasColumnType("datetime");

            builder.Entity<Destination.Models.destinationTest.VwGetWorkingBooking>()
              .Property(p => p.SpaCleanedDate)
              .HasColumnType("datetime");

            builder.Entity<Destination.Models.destinationTest.VwGetWorkingBooking>()
              .Property(p => p.CityOrdinanceSignedOn)
              .HasColumnType("datetime");

            builder.Entity<Destination.Models.destinationTest.VwGetWorkingBooking>()
              .Property(p => p.LastVisitedOn)
              .HasColumnType("datetime");

            builder.Entity<Destination.Models.destinationTest.VwGetWorkingBooking>()
              .Property(p => p.LastVisited)
              .HasColumnType("datetime");

            builder.Entity<Destination.Models.destinationTest.VwGetWorkingBooking>()
              .Property(p => p.LastResponse)
              .HasColumnType("datetime");

            builder.Entity<Destination.Models.destinationTest.VwGetWorkingBooking>()
              .Property(p => p.SpokeOn)
              .HasColumnType("datetime");

            builder.Entity<Destination.Models.destinationTest.VwGetWorkingBooking>()
              .Property(p => p.VoiceMail)
              .HasColumnType("datetime");

            builder.Entity<Destination.Models.destinationTest.VwLastBookedOn>()
              .Property(p => p.BookedOn)
              .HasColumnType("datetime");

            builder.Entity<Destination.Models.destinationTest.VwLastDateChangedOfLockBox>()
              .Property(p => p.DateChange)
              .HasColumnType("datetime");

            builder.Entity<Destination.Models.destinationTest.VwLastDoorCodeChangedPerProperty>()
              .Property(p => p.LastDateChanged)
              .HasColumnType("datetime");

            builder.Entity<Destination.Models.destinationTest.VwLastRecordedOwnerCommunication>()
              .Property(p => p.Cdate)
              .HasColumnType("datetime");

            builder.Entity<Destination.Models.destinationTest.VwMaintenanceNextDateFrom>()
              .Property(p => p.Dateentered)
              .HasColumnType("datetime");

            builder.Entity<Destination.Models.destinationTest.VwMaintenanceNextDateFrom>()
              .Property(p => p.Datecompleted)
              .HasColumnType("datetime");

            builder.Entity<Destination.Models.destinationTest.VwMaintenanceNextDateFrom>()
              .Property(p => p.Datetocomp)
              .HasColumnType("datetime");

            builder.Entity<Destination.Models.destinationTest.VwMaintenanceNextDateFrom>()
              .Property(p => p.NextdateFrom)
              .HasColumnType("datetime");

            builder.Entity<Destination.Models.destinationTest.VwUnbalanced>()
              .Property(p => p.Datefrom)
              .HasColumnType("datetime");

            builder.Entity<Destination.Models.destinationTest.WebPageTemplate>()
              .Property(p => p.DtCreated)
              .HasColumnType("datetime");

            builder.Entity<Destination.Models.destinationTest.WebPageTemplate>()
              .Property(p => p.LastUpdated)
              .HasColumnType("datetime");

            builder.Entity<Destination.Models.destinationTest.RdzVwGet2024Booking>()
              .Property(p => p.DateFrom)
              .HasColumnType("datetime");

            builder.Entity<Destination.Models.destinationTest.RdzVwGet2024Booking>()
              .Property(p => p.DateTo)
              .HasColumnType("datetime");
            this.OnModelBuilding(builder);
        }

        public DbSet<Destination.Models.destinationTest.AffiliateBooking> AffiliateBookings { get; set; }

        public DbSet<PropertyImprovementDto> PropertyImprovementResults { get; set; }
        public DbSet<PropertyAnnualLogDto> PropertyAnnualLogResults { get; set; }

        public DbSet<Destination.Models.destinationTest.AffiliateCollaboration> AffiliateCollaborations { get; set; }

        public DbSet<Destination.Models.destinationTest.AffiliateCommission> AffiliateCommissions { get; set; }

        public DbSet<Destination.Models.destinationTest.Affiliate> Affiliates { get; set; }

        public DbSet<Destination.Models.destinationTest.AffiliatesCommunication> AffiliatesCommunications { get; set; }

        public DbSet<Destination.Models.destinationTest.AffiliatesDatum> AffiliatesData { get; set; }

        public DbSet<Destination.Models.destinationTest.AffiliatesPropertyViewHistory> AffiliatesPropertyViewHistories { get; set; }

        public DbSet<Destination.Models.destinationTest.AffiliatesType> AffiliatesTypes { get; set; }

        public DbSet<Destination.Models.destinationTest.Agent> Agents { get; set; }

        public DbSet<Destination.Models.destinationTest.Agentstat> Agentstats { get; set; }

        public DbSet<Destination.Models.destinationTest.AgentStatus> AgentStatuses { get; set; }

        public DbSet<Destination.Models.destinationTest.AgreementContent> AgreementContents { get; set; }

        public DbSet<Destination.Models.destinationTest.AgreementHistory> AgreementHistories { get; set; }

        public DbSet<Destination.Models.destinationTest.AirbnbApiAutoSyncContent> AirbnbApiAutoSyncContents { get; set; }

        public DbSet<Destination.Models.destinationTest.AirbnbApicredential> AirbnbApicredentials { get; set; }

        public DbSet<Destination.Models.destinationTest.AirbnbApireservationsJson> AirbnbApireservationsJsons { get; set; }

        public DbSet<Destination.Models.destinationTest.AirBnbExport> AirBnbExports { get; set; }

        public DbSet<Destination.Models.destinationTest.AirbnbIcalsUpdateTracking> AirbnbIcalsUpdateTrackings { get; set; }

        public DbSet<Destination.Models.destinationTest.AirbnbMessage> AirbnbMessages { get; set; }

        public DbSet<Destination.Models.destinationTest.AirbnbSendMessage> AirbnbSendMessages { get; set; }

        public DbSet<Destination.Models.destinationTest.AirbnbUploadedPhoto> AirbnbUploadedPhotos { get; set; }

        public DbSet<Destination.Models.destinationTest.Annual> Annuals { get; set; }

        public DbSet<Destination.Models.destinationTest.AnnualSurvey> AnnualSurveys { get; set; }

        public DbSet<Destination.Models.destinationTest.AnnualType> AnnualTypes { get; set; }

        public DbSet<Destination.Models.destinationTest.AppliedPromoCode> AppliedPromoCodes { get; set; }

        public DbSet<Destination.Models.destinationTest.AutoSmspagesHitPerDay> AutoSmspagesHitPerDays { get; set; }

        public DbSet<Destination.Models.destinationTest.Bedcount> Bedcounts { get; set; }

        public DbSet<Destination.Models.destinationTest.BookingStatus> BookingStatuses { get; set; }

        public DbSet<Destination.Models.destinationTest.BookingStatus1> BookingStatus1S { get; set; }

        public DbSet<Destination.Models.destinationTest.BookingAddOwnerReport> BookingAddOwnerReports { get; set; }

        public DbSet<Destination.Models.destinationTest.Bookingdamage> Bookingdamages { get; set; }

        public DbSet<Destination.Models.destinationTest.BookingEmailSetting> BookingEmailSettings { get; set; }

        public DbSet<Destination.Models.destinationTest.BookingHistory> BookingHistories { get; set; }

        public DbSet<Destination.Models.destinationTest.BookingQuote> BookingQuotes { get; set; }

        public DbSet<Destination.Models.destinationTest.Booking> Bookings { get; set; }

        public DbSet<Destination.Models.destinationTest.BookingsOwner> BookingsOwners { get; set; }

        public DbSet<Destination.Models.destinationTest.BookingsVisited> BookingsVisiteds { get; set; }

        public DbSet<Destination.Models.destinationTest.BookingsCode> BookingsCodes { get; set; }

        public DbSet<Destination.Models.destinationTest.BookingsLargeGroup> BookingsLargeGroups { get; set; }

        public DbSet<Destination.Models.destinationTest.BookingsLogic> BookingsLogics { get; set; }

        public DbSet<Destination.Models.destinationTest.BookingsLogic2> BookingsLogic2S { get; set; }

        public DbSet<Destination.Models.destinationTest.BookingsLogicVrbo> BookingsLogicVrbos { get; set; }

        public DbSet<Destination.Models.destinationTest.BookingsOriginalPubRate> BookingsOriginalPubRates { get; set; }

        public DbSet<Destination.Models.destinationTest.Broker> Brokers { get; set; }

        public DbSet<Destination.Models.destinationTest.BulkSmstest> BulkSmstests { get; set; }

        public DbSet<Destination.Models.destinationTest.BulkSmstest1> BulkSmstest1S { get; set; }

        public DbSet<Destination.Models.destinationTest.CalenderFileBooking> CalenderFileBookings { get; set; }

        public DbSet<Destination.Models.destinationTest.Campaign> Campaigns { get; set; }

        public DbSet<Destination.Models.destinationTest.Channel> Channels { get; set; }

        public DbSet<Destination.Models.destinationTest.ChannelBu> ChannelBus { get; set; }

        public DbSet<Destination.Models.destinationTest.ChannelPartial> ChannelPartials { get; set; }

        public DbSet<Destination.Models.destinationTest.ChannelPartnerHit> ChannelPartnerHits { get; set; }

        public DbSet<Destination.Models.destinationTest.ChannelVariance> ChannelVariances { get; set; }

        public DbSet<Destination.Models.destinationTest.Chatbooking> Chatbookings { get; set; }

        public DbSet<Destination.Models.destinationTest.ChatBotKeywordMaster> ChatBotKeywordMasters { get; set; }

        public DbSet<Destination.Models.destinationTest.ChatBotMenuMaster> ChatBotMenuMasters { get; set; }

        public DbSet<Destination.Models.destinationTest.CheckInCheckOutSetting> CheckInCheckOutSettings { get; set; }

        public DbSet<Destination.Models.destinationTest.CheckInLog> CheckInLogs { get; set; }

        public DbSet<Destination.Models.destinationTest.CleanerAuditedMsg> CleanerAuditedMsgs { get; set; }

        public DbSet<Destination.Models.destinationTest.CleanerGroup> CleanerGroups { get; set; }

        public DbSet<Destination.Models.destinationTest.CleanerInvoiceMatchedDatum> CleanerInvoiceMatchedData { get; set; }

        public DbSet<Destination.Models.destinationTest.CleanerNo> CleanerNos { get; set; }

        public DbSet<Destination.Models.destinationTest.CleaningPayrolExtraTaskDetail> CleaningPayrolExtraTaskDetails { get; set; }

        public DbSet<Destination.Models.destinationTest.CleaningVariance> CleaningVariances { get; set; }

        public DbSet<Destination.Models.destinationTest.CommCode> CommCodes { get; set; }

        public DbSet<Destination.Models.destinationTest.Communication> Communications { get; set; }

        public DbSet<Destination.Models.destinationTest.CompanyHistory> CompanyHistories { get; set; }

        public DbSet<Destination.Models.destinationTest.ContractTable> ContractTables { get; set; }

        public DbSet<Destination.Models.destinationTest.Controllist> Controllists { get; set; }

        public DbSet<Destination.Models.destinationTest.Controllog> Controllogs { get; set; }

        public DbSet<Destination.Models.destinationTest.CoronaAnnualDatum> CoronaAnnualData { get; set; }

        public DbSet<Destination.Models.destinationTest.CreditRequest> CreditRequests { get; set; }

        public DbSet<Destination.Models.destinationTest.CreditRequestType> CreditRequestTypes { get; set; }

        public DbSet<Destination.Models.destinationTest.CriticalTaskWarning> CriticalTaskWarnings { get; set; }

        public DbSet<Destination.Models.destinationTest.Currentdiscount> Currentdiscounts { get; set; }

        public DbSet<Destination.Models.destinationTest.CurrentDiscountsHistory> CurrentDiscountsHistories { get; set; }

        public DbSet<Destination.Models.destinationTest.DailyProcessedMinNight> DailyProcessedMinNights { get; set; }

        public DbSet<Destination.Models.destinationTest.DailyRatesBasedOnPropertyRate> DailyRatesBasedOnPropertyRates { get; set; }

        public DbSet<Destination.Models.destinationTest.DailyStat> DailyStats { get; set; }

        public DbSet<Destination.Models.destinationTest.DeletedGapHolderBooking> DeletedGapHolderBookings { get; set; }

        public DbSet<Destination.Models.destinationTest.DepositHoldLog> DepositHoldLogs { get; set; }

        public DbSet<Destination.Models.destinationTest.Discount> Discounts { get; set; }

        public DbSet<Destination.Models.destinationTest.DoNotRent> DoNotRents { get; set; }

        public DbSet<Destination.Models.destinationTest.DoorCodeLog> DoorCodeLogs { get; set; }

        public DbSet<Destination.Models.destinationTest.EmailRemoveList> EmailRemoveLists { get; set; }

        public DbSet<Destination.Models.destinationTest.EmailRemoveList1> EmailRemoveList1S { get; set; }

        public DbSet<Destination.Models.destinationTest.Email> Emails { get; set; }

        public DbSet<Destination.Models.destinationTest.EventDate> EventDates { get; set; }

        public DbSet<Destination.Models.destinationTest.Favorite> Favorites { get; set; }

        public DbSet<Destination.Models.destinationTest.FilterDataForBulkSmsMail> FilterDataForBulkSmsMails { get; set; }

        public DbSet<Destination.Models.destinationTest.FinalDatum> FinalData { get; set; }

        public DbSet<Destination.Models.destinationTest.Forecast> Forecasts { get; set; }

        public DbSet<Destination.Models.destinationTest.GoogleUsersKeyword> GoogleUsersKeywords { get; set; }

        public DbSet<Destination.Models.destinationTest.GuestCodeCall> GuestCodeCalls { get; set; }

        public DbSet<Destination.Models.destinationTest.HotHome> HotHomes { get; set; }

        public DbSet<Destination.Models.destinationTest.HouseRule> HouseRules { get; set; }

        public DbSet<Destination.Models.destinationTest.InntopiaCallLog> InntopiaCallLogs { get; set; }

        public DbSet<Destination.Models.destinationTest.InntopiaPushTimeLog> InntopiaPushTimeLogs { get; set; }

        public DbSet<Destination.Models.destinationTest.InntopiaAudit> InntopiaAudits { get; set; }

        public DbSet<Destination.Models.destinationTest.InntopiaBooking> InntopiaBookings { get; set; }

        public DbSet<Destination.Models.destinationTest.InquiryNa> InquiryNas { get; set; }

        public DbSet<Destination.Models.destinationTest.InspectionPlan> InspectionPlans { get; set; }

        public DbSet<Destination.Models.destinationTest.Instruction> Instructions { get; set; }

        public DbSet<Destination.Models.destinationTest.InstructionAgent> InstructionAgents { get; set; }

        public DbSet<Destination.Models.destinationTest.LandingPage> LandingPages { get; set; }

        public DbSet<Destination.Models.destinationTest.LargeGroupBooking> LargeGroupBookings { get; set; }

        public DbSet<Destination.Models.destinationTest.LaundryRate> LaundryRates { get; set; }

        public DbSet<Destination.Models.destinationTest.LogEditPropertyDescription> LogEditPropertyDescriptions { get; set; }

        public DbSet<Destination.Models.destinationTest.LogDoorCodes2020> LogDoorCodes2020S { get; set; }

        public DbSet<Destination.Models.destinationTest.MaintenanceAction> MaintenanceActions { get; set; }

        public DbSet<Destination.Models.destinationTest.MarketingReview> MarketingReviews { get; set; }

        public DbSet<Destination.Models.destinationTest.Medium> Media { get; set; }

        public DbSet<Destination.Models.destinationTest.MenuManagement> MenuManagements { get; set; }

        public DbSet<Destination.Models.destinationTest.MenuMaster> MenuMasters { get; set; }

        public DbSet<Destination.Models.destinationTest.MoreContent> MoreContents { get; set; }

        public DbSet<Destination.Models.destinationTest.Neighborhood> Neighborhoods { get; set; }

        public DbSet<Destination.Models.destinationTest.NoWord> NoWords { get; set; }

        public DbSet<Destination.Models.destinationTest.OffhoursListForSmsroutine> OffhoursListForSmsroutines { get; set; }

        public DbSet<Destination.Models.destinationTest.OlarkZapier> OlarkZapiers { get; set; }

        public DbSet<Destination.Models.destinationTest.OlarkZapierNew> OlarkZapierNews { get; set; }

        public DbSet<Destination.Models.destinationTest.OpinionStageSurveyLeadsRepor> OpinionStageSurveyLeadsRepors { get; set; }

        public DbSet<Destination.Models.destinationTest.OwnerCommunication> OwnerCommunications { get; set; }

        public DbSet<Destination.Models.destinationTest.OwnerUpdate> OwnerUpdates { get; set; }

        public DbSet<Destination.Models.destinationTest.PageEmailRecipient> PageEmailRecipients { get; set; }

        public DbSet<Destination.Models.destinationTest.Payment> Payments { get; set; }

        public DbSet<Destination.Models.destinationTest.PaymentLogDoubleRefunded> PaymentLogDoubleRefundeds { get; set; }

        public DbSet<Destination.Models.destinationTest.Performa> Performas { get; set; }

        public DbSet<Destination.Models.destinationTest.PerformaComp> PerformaComps { get; set; }

        public DbSet<Destination.Models.destinationTest.Permit> Permits { get; set; }

        public DbSet<Destination.Models.destinationTest.PhoneCallLog> PhoneCallLogs { get; set; }

        public DbSet<Destination.Models.destinationTest.PinkSheetNote> PinkSheetNotes { get; set; }

        public DbSet<Destination.Models.destinationTest.ProcGetLastBookingDetail> ProcGetLastBookingDetails { get; set; }

        public DbSet<Destination.Models.destinationTest.PromoCode> PromoCodes { get; set; }

        public DbSet<Destination.Models.destinationTest.Promotion> Promotions { get; set; }

        public DbSet<Destination.Models.destinationTest.Property> Properties { get; set; }

        public DbSet<Destination.Models.destinationTest.PropertyActivationDate> PropertyActivationDates { get; set; }

        public DbSet<Destination.Models.destinationTest.PropertyBed> PropertyBeds { get; set; }

        public DbSet<Destination.Models.destinationTest.PropertyCleaner> PropertyCleaners { get; set; }

        public DbSet<Destination.Models.destinationTest.PropertyConduct> PropertyConducts { get; set; }

        public DbSet<Destination.Models.destinationTest.PropertyContent> PropertyContents { get; set; }

        public DbSet<Destination.Models.destinationTest.PropertyExpenseBlankRecord> PropertyExpenseBlankRecords { get; set; }

        public DbSet<Destination.Models.destinationTest.PropertyExpense> PropertyExpenses { get; set; }

        public DbSet<Destination.Models.destinationTest.PropertyExpensesDeleted> PropertyExpensesDeleteds { get; set; }

        public DbSet<Destination.Models.destinationTest.PropertyImprovement> PropertyImprovements { get; set; }

        public DbSet<Destination.Models.destinationTest.PropertyImprovementType> PropertyImprovementTypes { get; set; }

        public DbSet<Destination.Models.destinationTest.PropertyLastNextBookingDetail> PropertyLastNextBookingDetails { get; set; }

        public DbSet<Destination.Models.destinationTest.PropertyMgt> PropertyMgts { get; set; }

        public DbSet<Destination.Models.destinationTest.PropertyNeighbor> PropertyNeighbors { get; set; }

        public DbSet<Destination.Models.destinationTest.PropertyOwnerInstruction> PropertyOwnerInstructions { get; set; }

        public DbSet<Destination.Models.destinationTest.PropertyRate> PropertyRates { get; set; }

        public DbSet<Destination.Models.destinationTest.PropertyRatesAirbnb> PropertyRatesAirbnbs { get; set; }

        public DbSet<Destination.Models.destinationTest.PropertyRatesBase> PropertyRatesBases { get; set; }

        public DbSet<Destination.Models.destinationTest.PropertyRatesBb> PropertyRatesBbs { get; set; }

        public DbSet<Destination.Models.destinationTest.PropertyRatesTracking> PropertyRatesTrackings { get; set; }

        public DbSet<Destination.Models.destinationTest.PropertyRatesVrbo> PropertyRatesVrbos { get; set; }

        public DbSet<Destination.Models.destinationTest.PropertySource> PropertySources { get; set; }

        public DbSet<Destination.Models.destinationTest.PropertyType> PropertyTypes { get; set; }

        public DbSet<Destination.Models.destinationTest.PropertyWarning> PropertyWarnings { get; set; }

        public DbSet<Destination.Models.destinationTest.PropertyAnnualLog> PropertyAnnualLogs { get; set; }

        public DbSet<Destination.Models.destinationTest.PropertyBackToBackBookingsRestrict> PropertyBackToBackBookingsRestricts { get; set; }

        public DbSet<Destination.Models.destinationTest.Propertycontenttype> Propertycontenttypes { get; set; }

        public DbSet<Destination.Models.destinationTest.PropertyDeposit> PropertyDeposits { get; set; }

        public DbSet<Destination.Models.destinationTest.PropertyFulltime> PropertyFulltimes { get; set; }

        public DbSet<Destination.Models.destinationTest.PropertyInsurance> PropertyInsurances { get; set; }

        public DbSet<Destination.Models.destinationTest.PropertyInsuranceCity> PropertyInsuranceCities { get; set; }

        public DbSet<Destination.Models.destinationTest.PropertyInsuranceCounty> PropertyInsuranceCounties { get; set; }

        public DbSet<Destination.Models.destinationTest.PropertyRatesDaily> PropertyRatesDailies { get; set; }

        public DbSet<Destination.Models.destinationTest.PropertyRatesDailySingleProp> PropertyRatesDailySingleProps { get; set; }

        public DbSet<Destination.Models.destinationTest.PropertyRatesDailyTemp> PropertyRatesDailyTemps { get; set; }

        public DbSet<Destination.Models.destinationTest.PropertyRatesDailyMinRate> PropertyRatesDailyMinRates { get; set; }

        public DbSet<Destination.Models.destinationTest.PropertyVisitCount> PropertyVisitCounts { get; set; }

        public DbSet<Destination.Models.destinationTest.PropertyWatchList> PropertyWatchLists { get; set; }

        public DbSet<Destination.Models.destinationTest.PropExpMgr> PropExpMgrs { get; set; }

        public DbSet<Destination.Models.destinationTest.RamQuestion> RamQuestions { get; set; }

        public DbSet<Destination.Models.destinationTest.RamTest> RamTests { get; set; }

        public DbSet<Destination.Models.destinationTest.RamTestResult> RamTestResults { get; set; }

        public DbSet<Destination.Models.destinationTest.RamTestUserResult> RamTestUserResults { get; set; }

        public DbSet<Destination.Models.destinationTest.RamTestUser> RamTestUsers { get; set; }

        public DbSet<Destination.Models.destinationTest.RateReview> RateReviews { get; set; }

        public DbSet<Destination.Models.destinationTest.RateSetting> RateSettings { get; set; }

        public DbSet<Destination.Models.destinationTest.RatesMin> RatesMins { get; set; }

        public DbSet<Destination.Models.destinationTest.Restriction> Restrictions { get; set; }

        public DbSet<Destination.Models.destinationTest.ReviewMapping> ReviewMappings { get; set; }

        public DbSet<Destination.Models.destinationTest.Review> Reviews { get; set; }

        public DbSet<Destination.Models.destinationTest.Sample23> Sample23S { get; set; }

        public DbSet<Destination.Models.destinationTest.Search> Searches { get; set; }

        public DbSet<Destination.Models.destinationTest.SendAirbnbCheckOutReply> SendAirbnbCheckOutReplies { get; set; }

        public DbSet<Destination.Models.destinationTest.SendToEmailForNotificationPage> SendToEmailForNotificationPages { get; set; }

        public DbSet<Destination.Models.destinationTest.SendTwilioSm> SendTwilioSms { get; set; }

        public DbSet<Destination.Models.destinationTest.SendTwilioSmsQueue> SendTwilioSmsQueues { get; set; }

        public DbSet<Destination.Models.destinationTest.Setting> Settings { get; set; }

        public DbSet<Destination.Models.destinationTest.Sheet1> Sheet1S { get; set; }

        public DbSet<Destination.Models.destinationTest.Sheet2> Sheet2S { get; set; }

        public DbSet<Destination.Models.destinationTest.Smsgroup> Smsgroups { get; set; }

        public DbSet<Destination.Models.destinationTest.Smsmessage> Smsmessages { get; set; }

        public DbSet<Destination.Models.destinationTest.SmsRemoveList> SmsRemoveLists { get; set; }

        public DbSet<Destination.Models.destinationTest.SmstemplateArea> SmstemplateAreas { get; set; }

        public DbSet<Destination.Models.destinationTest.Smstemplate> Smstemplates { get; set; }

        public DbSet<Destination.Models.destinationTest.SnowRemoval> SnowRemovals { get; set; }

        public DbSet<Destination.Models.destinationTest.SpaTransaction> SpaTransactions { get; set; }

        public DbSet<Destination.Models.destinationTest.Status> Statuses { get; set; }

        public DbSet<Destination.Models.destinationTest.SystemPage> SystemPages { get; set; }

        public DbSet<Destination.Models.destinationTest.TaskDesc> TaskDescs { get; set; }

        public DbSet<Destination.Models.destinationTest.TblAirbnbExportTemp> TblAirbnbExportTemps { get; set; }

        public DbSet<Destination.Models.destinationTest.TblBookingIdsForMail> TblBookingIdsForMails { get; set; }

        public DbSet<Destination.Models.destinationTest.TblBookingInterest> TblBookingInterests { get; set; }

        public DbSet<Destination.Models.destinationTest.TblBulkEmailLog> TblBulkEmailLogs { get; set; }

        public DbSet<Destination.Models.destinationTest.TblChkSm> TblChkSms { get; set; }

        public DbSet<Destination.Models.destinationTest.TblDebug> TblDebugs { get; set; }

        public DbSet<Destination.Models.destinationTest.TblHomePageImagesLink> TblHomePageImagesLinks { get; set; }

        public DbSet<Destination.Models.destinationTest.TblInterest> TblInterests { get; set; }

        public DbSet<Destination.Models.destinationTest.TblInterest1> TblInterests1 { get; set; }

        public DbSet<Destination.Models.destinationTest.TblMultiDayDiscount> TblMultiDayDiscounts { get; set; }

        public DbSet<Destination.Models.destinationTest.TblNotAvtivePropertyBooking> TblNotAvtivePropertyBookings { get; set; }

        public DbSet<Destination.Models.destinationTest.TblNotSendingEmail> TblNotSendingEmails { get; set; }

        public DbSet<Destination.Models.destinationTest.TblPartialCheckIn> TblPartialCheckIns { get; set; }

        public DbSet<Destination.Models.destinationTest.TblPropertyActiveInactiveTrackForFlipkeyFeed> TblPropertyActiveInactiveTrackForFlipkeyFeeds { get; set; }

        public DbSet<Destination.Models.destinationTest.TblPropertyImage> TblPropertyImages { get; set; }

        public DbSet<Destination.Models.destinationTest.TblPropertyRatesDailyMissedDatesProp> TblPropertyRatesDailyMissedDatesProps { get; set; }

        public DbSet<Destination.Models.destinationTest.TblrateTemp> TblrateTemps { get; set; }

        public DbSet<Destination.Models.destinationTest.TblService> TblServices { get; set; }

        public DbSet<Destination.Models.destinationTest.TblTrackDailyRatesExecutionForProperty> TblTrackDailyRatesExecutionForProperties { get; set; }

        public DbSet<Destination.Models.destinationTest.TblTypeMaster> TblTypeMasters { get; set; }

        public DbSet<Destination.Models.destinationTest.Temp12> Temp12S { get; set; }

        public DbSet<Destination.Models.destinationTest.TempCom> TempComs { get; set; }

        public DbSet<Destination.Models.destinationTest.TemplateCat> TemplateCats { get; set; }

        public DbSet<Destination.Models.destinationTest.Template> Templates { get; set; }

        public DbSet<Destination.Models.destinationTest.Tenant> Tenants { get; set; }

        public DbSet<Destination.Models.destinationTest.TenantCheckInPhoto> TenantCheckInPhotos { get; set; }

        public DbSet<Destination.Models.destinationTest.TenantInterestDatum> TenantInterestData { get; set; }

        public DbSet<Destination.Models.destinationTest.TenantOrderAlertEmailMessage> TenantOrderAlertEmailMessages { get; set; }

        public DbSet<Destination.Models.destinationTest.TenantSheet> TenantSheets { get; set; }

        public DbSet<Destination.Models.destinationTest.TenantWithPlusOneInCell> TenantWithPlusOneInCells { get; set; }

        public DbSet<Destination.Models.destinationTest.TestTable> TestTables { get; set; }

        public DbSet<Destination.Models.destinationTest.TestTableForDailyRoutine> TestTableForDailyRoutines { get; set; }

        public DbSet<Destination.Models.destinationTest.TrackClosedPastBooking> TrackClosedPastBookings { get; set; }

        public DbSet<Destination.Models.destinationTest.TrackedCampaign> TrackedCampaigns { get; set; }

        public DbSet<Destination.Models.destinationTest.TrackedUser> TrackedUsers { get; set; }

        public DbSet<Destination.Models.destinationTest.TrainingScore> TrainingScores { get; set; }

        public DbSet<Destination.Models.destinationTest.UpdateRateHome> UpdateRateHomes { get; set; }

        public DbSet<Destination.Models.destinationTest.Utility> Utilities { get; set; }

        public DbSet<Destination.Models.destinationTest.UvGetBackToBackCheckInsPerDay> UvGetBackToBackCheckInsPerDays { get; set; }

        public DbSet<Destination.Models.destinationTest.UvGetBookingBackToBackCount> UvGetBookingBackToBackCounts { get; set; }

        public DbSet<Destination.Models.destinationTest.UvGetBooking> UvGetBookings { get; set; }

        public DbSet<Destination.Models.destinationTest.UvGetTotalCheckInsPerDay> UvGetTotalCheckInsPerDays { get; set; }

        public DbSet<Destination.Models.destinationTest.VRecord> VRecords { get; set; }

        public DbSet<Destination.Models.destinationTest.ViewRevenue> ViewRevenues { get; set; }

        public DbSet<Destination.Models.destinationTest.VoiceMail> VoiceMails { get; set; }

        public DbSet<Destination.Models.destinationTest.VonageTsheet> VonageTsheets { get; set; }

        public DbSet<Destination.Models.destinationTest.VrboErrorLogForBookingRequest> VrboErrorLogForBookingRequests { get; set; }

        public DbSet<Destination.Models.destinationTest.Vrboaudit> Vrboaudits { get; set; }

        public DbSet<Destination.Models.destinationTest.Vrboimage> Vrboimages { get; set; }

        public DbSet<Destination.Models.destinationTest.VrboImage1> VrboImage1S { get; set; }

        public DbSet<Destination.Models.destinationTest.VrboimageDetail> VrboimageDetails { get; set; }

        public DbSet<Destination.Models.destinationTest.VrboImageDetailBackup> VrboImageDetailBackups { get; set; }

        public DbSet<Destination.Models.destinationTest.VrboProperty> VrboProperties { get; set; }

        public DbSet<Destination.Models.destinationTest.VwCleanedStatusCheckOutToday> VwCleanedStatusCheckOutTodays { get; set; }

        public DbSet<Destination.Models.destinationTest.VwCurrentlyOccupied> VwCurrentlyOccupieds { get; set; }

        public DbSet<Destination.Models.destinationTest.VwFutureBooking> VwFutureBookings { get; set; }

        public DbSet<Destination.Models.destinationTest.VwGetCommMax> VwGetCommMaxes { get; set; }

        public DbSet<Destination.Models.destinationTest.VwGetMinuteDifference> VwGetMinuteDifferences { get; set; }

        public DbSet<Destination.Models.destinationTest.VwGetTrackedUser> VwGetTrackedUsers { get; set; }

        public DbSet<Destination.Models.destinationTest.VwGetAirbnbDepositsInfo> VwGetAirbnbDepositsInfos { get; set; }

        public DbSet<Destination.Models.destinationTest.VwGetAllPropertyStatus> VwGetAllPropertyStatuses { get; set; }

        public DbSet<Destination.Models.destinationTest.VwGetClosestBookingWithCleaningStatus> VwGetClosestBookingWithCleaningStatuses { get; set; }

        public DbSet<Destination.Models.destinationTest.VwGetclosestwithCleaner> VwGetclosestwithCleaners { get; set; }

        public DbSet<Destination.Models.destinationTest.VwGetclosestwithDate> VwGetclosestwithDates { get; set; }

        public DbSet<Destination.Models.destinationTest.VwGetCommMax1> VwGetCommMaxes1 { get; set; }

        public DbSet<Destination.Models.destinationTest.VwGetDoorCodeLog> VwGetDoorCodeLogs { get; set; }

        public DbSet<Destination.Models.destinationTest.VwGetInquiryDatesForBookingsDashboardQuery> VwGetInquiryDatesForBookingsDashboardQueries { get; set; }

        public DbSet<Destination.Models.destinationTest.VwGetInspectionDateMgtForAllActiveProp> VwGetInspectionDateMgtForAllActiveProps { get; set; }

        public DbSet<Destination.Models.destinationTest.VwGetlast3MonthsTotal> VwGetlast3MonthsTotals { get; set; }

        public DbSet<Destination.Models.destinationTest.VwGetlast3MonthsTotalPy> VwGetlast3MonthsTotalPies { get; set; }

        public DbSet<Destination.Models.destinationTest.VwGetlast6MonthsTotal> VwGetlast6MonthsTotals { get; set; }

        public DbSet<Destination.Models.destinationTest.VwGetlast6MonthsTotalPy> VwGetlast6MonthsTotalPies { get; set; }

        public DbSet<Destination.Models.destinationTest.VwGetLastCleanedDateForAllActiveProp> VwGetLastCleanedDateForAllActiveProps { get; set; }

        public DbSet<Destination.Models.destinationTest.VwGetLastCleaner> VwGetLastCleaners { get; set; }

        public DbSet<Destination.Models.destinationTest.VwGetLastDateCompletedFromExpense> VwGetLastDateCompletedFromExpenses { get; set; }

        public DbSet<Destination.Models.destinationTest.VwGetLastInspectedDateForAllActiveProp> VwGetLastInspectedDateForAllActiveProps { get; set; }

        public DbSet<Destination.Models.destinationTest.VwGetLastRateChanged> VwGetLastRateChangeds { get; set; }

        public DbSet<Destination.Models.destinationTest.VwGetlastyearTotal> VwGetlastyearTotals { get; set; }

        public DbSet<Destination.Models.destinationTest.VwGetlastyearTotalPy> VwGetlastyearTotalPies { get; set; }

        public DbSet<Destination.Models.destinationTest.VwGetNetSum> VwGetNetSums { get; set; }

        public DbSet<Destination.Models.destinationTest.VwGetNextBooking> VwGetNextBookings { get; set; }

        public DbSet<Destination.Models.destinationTest.VwGetNextOwnerBooking> VwGetNextOwnerBookings { get; set; }

        public DbSet<Destination.Models.destinationTest.VwGetPropClosestDatewithCleaner> VwGetPropClosestDatewithCleaners { get; set; }

        public DbSet<Destination.Models.destinationTest.VwGetPropertiesWithoutSpace> VwGetPropertiesWithoutSpaces { get; set; }

        public DbSet<Destination.Models.destinationTest.VwGetPropertyExpense> VwGetPropertyExpenses { get; set; }

        public DbSet<Destination.Models.destinationTest.VwGetPropertyStatus> VwGetPropertyStatuses { get; set; }

        public DbSet<Destination.Models.destinationTest.VwGetPropertyStatusOnlyMaintenanceDept> VwGetPropertyStatusOnlyMaintenanceDepts { get; set; }

        public DbSet<Destination.Models.destinationTest.VwGetPropListWithControlLog> VwGetPropListWithControlLogs { get; set; }

        public DbSet<Destination.Models.destinationTest.VwGetPropReviewCount> VwGetPropReviewCounts { get; set; }

        public DbSet<Destination.Models.destinationTest.VwGetPrpertiesHotOpen> VwGetPrpertiesHotOpens { get; set; }

        public DbSet<Destination.Models.destinationTest.VwGetSnapshotTotal> VwGetSnapshotTotals { get; set; }

        public DbSet<Destination.Models.destinationTest.VwGetSnapshotTotalPy> VwGetSnapshotTotalPies { get; set; }

        public DbSet<Destination.Models.destinationTest.VwGetTotalBkngsForBookingsDashboardQuery> VwGetTotalBkngsForBookingsDashboardQueries { get; set; }

        public DbSet<Destination.Models.destinationTest.VwGetTotalExpense> VwGetTotalExpenses { get; set; }

        public DbSet<Destination.Models.destinationTest.VwGetTotalExpensesOnlyMaintenanceDept> VwGetTotalExpensesOnlyMaintenanceDepts { get; set; }

        public DbSet<Destination.Models.destinationTest.VwGetTotalExpensesFiltered> VwGetTotalExpensesFiltereds { get; set; }

        public DbSet<Destination.Models.destinationTest.VwGetTotalInquiriesForBookingsDashboardQuery> VwGetTotalInquiriesForBookingsDashboardQueries { get; set; }

        public DbSet<Destination.Models.destinationTest.VwGetTrackedUser1> VwGetTrackedUsers1 { get; set; }

        public DbSet<Destination.Models.destinationTest.VwGetUniqueTenant> VwGetUniqueTenants { get; set; }

        public DbSet<Destination.Models.destinationTest.VwGetWorkingBooking> VwGetWorkingBookings { get; set; }

        public DbSet<Destination.Models.destinationTest.VwGetYearWiseTotal> VwGetYearWiseTotals { get; set; }

        public DbSet<Destination.Models.destinationTest.VwLastBookedOn> VwLastBookedOns { get; set; }

        public DbSet<Destination.Models.destinationTest.VwLastDateChangedOfLockBox> VwLastDateChangedOfLockBoxes { get; set; }

        public DbSet<Destination.Models.destinationTest.VwLastDoorCodeChangedPerProperty> VwLastDoorCodeChangedPerProperties { get; set; }

        public DbSet<Destination.Models.destinationTest.VwLastRecordedOwnerCommunication> VwLastRecordedOwnerCommunications { get; set; }

        public DbSet<Destination.Models.destinationTest.VwMaintenanceNextDateFrom> VwMaintenanceNextDateFroms { get; set; }

        public DbSet<Destination.Models.destinationTest.VwNetPayment> VwNetPayments { get; set; }

        public DbSet<Destination.Models.destinationTest.VwPaymentSummary> VwPaymentSummaries { get; set; }

        public DbSet<Destination.Models.destinationTest.VwPropertyOccupiedStatus> VwPropertyOccupiedStatuses { get; set; }

        public DbSet<Destination.Models.destinationTest.VwRptGetLastCleaned> VwRptGetLastCleaneds { get; set; }

        public DbSet<Destination.Models.destinationTest.VwSpringCleaning> VwSpringCleanings { get; set; }

        public DbSet<Destination.Models.destinationTest.VwSumPropertyExpense> VwSumPropertyExpenses { get; set; }

        public DbSet<Destination.Models.destinationTest.VwTenantCount> VwTenantCounts { get; set; }

        public DbSet<Destination.Models.destinationTest.VwUnbalanced> VwUnbalanceds { get; set; }

        public DbSet<Destination.Models.destinationTest.Warrranty> Warrranties { get; set; }

        public DbSet<Destination.Models.destinationTest.WebPageTemplate> WebPageTemplates { get; set; }

        public DbSet<Destination.Models.destinationTest.RdzVwGet2024Booking> RdzVwGet2024Bookings { get; set; }

        protected override void ConfigureConventions(ModelConfigurationBuilder configurationBuilder)
        {
            configurationBuilder.Conventions.Add(_ => new BlankTriggerAddingConvention());
        }
    }
}