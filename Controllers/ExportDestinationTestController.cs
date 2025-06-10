//using System;
//using System.Linq;
//using Microsoft.AspNetCore.Mvc;
//using Microsoft.EntityFrameworkCore;
//using System.Threading.Tasks;

//using Destination.Data;

//namespace Destination.Controllers
//{
//    public partial class ExportdestinationTestController : ExportController
//    {
//        private readonly destinationTestContext context;
//        private readonly destinationTestService service;

//        public ExportdestinationTestController(destinationTestContext context, destinationTestService service)
//        {
//            this.service = service;
//            this.context = context;
//        }

//        [HttpGet("/export/destinationTest/affiliatebookings/csv")]
//        [HttpGet("/export/destinationTest/affiliatebookings/csv(fileName='{fileName}')")]
//        public async Task<FileStreamResult> ExportAffiliateBookingsToCSV(string fileName = null)
//        {
//            return ToCSV(ApplyQuery(await service.GetAffiliateBookings(), Request.Query, false), fileName);
//        }

//        [HttpGet("/export/destinationTest/affiliatebookings/excel")]
//        [HttpGet("/export/destinationTest/affiliatebookings/excel(fileName='{fileName}')")]
//        public async Task<FileStreamResult> ExportAffiliateBookingsToExcel(string fileName = null)
//        {
//            return ToExcel(ApplyQuery(await service.GetAffiliateBookings(), Request.Query, false), fileName);
//        }

//        [HttpGet("/export/destinationTest/affiliatecollaborations/csv")]
//        [HttpGet("/export/destinationTest/affiliatecollaborations/csv(fileName='{fileName}')")]
//        public async Task<FileStreamResult> ExportAffiliateCollaborationsToCSV(string fileName = null)
//        {
//            return ToCSV(ApplyQuery(await service.GetAffiliateCollaborations(), Request.Query, false), fileName);
//        }

//        [HttpGet("/export/destinationTest/affiliatecollaborations/excel")]
//        [HttpGet("/export/destinationTest/affiliatecollaborations/excel(fileName='{fileName}')")]
//        public async Task<FileStreamResult> ExportAffiliateCollaborationsToExcel(string fileName = null)
//        {
//            return ToExcel(ApplyQuery(await service.GetAffiliateCollaborations(), Request.Query, false), fileName);
//        }

//        [HttpGet("/export/destinationTest/affiliatecommissions/csv")]
//        [HttpGet("/export/destinationTest/affiliatecommissions/csv(fileName='{fileName}')")]
//        public async Task<FileStreamResult> ExportAffiliateCommissionsToCSV(string fileName = null)
//        {
//            return ToCSV(ApplyQuery(await service.GetAffiliateCommissions(), Request.Query, false), fileName);
//        }

//        [HttpGet("/export/destinationTest/affiliatecommissions/excel")]
//        [HttpGet("/export/destinationTest/affiliatecommissions/excel(fileName='{fileName}')")]
//        public async Task<FileStreamResult> ExportAffiliateCommissionsToExcel(string fileName = null)
//        {
//            return ToExcel(ApplyQuery(await service.GetAffiliateCommissions(), Request.Query, false), fileName);
//        }

//        [HttpGet("/export/destinationTest/affiliates/csv")]
//        [HttpGet("/export/destinationTest/affiliates/csv(fileName='{fileName}')")]
//        public async Task<FileStreamResult> ExportAffiliatesToCSV(string fileName = null)
//        {
//            return ToCSV(ApplyQuery(await service.GetAffiliates(), Request.Query, false), fileName);
//        }

//        [HttpGet("/export/destinationTest/affiliates/excel")]
//        [HttpGet("/export/destinationTest/affiliates/excel(fileName='{fileName}')")]
//        public async Task<FileStreamResult> ExportAffiliatesToExcel(string fileName = null)
//        {
//            return ToExcel(ApplyQuery(await service.GetAffiliates(), Request.Query, false), fileName);
//        }

//        [HttpGet("/export/destinationTest/affiliatescommunications/csv")]
//        [HttpGet("/export/destinationTest/affiliatescommunications/csv(fileName='{fileName}')")]
//        public async Task<FileStreamResult> ExportAffiliatesCommunicationsToCSV(string fileName = null)
//        {
//            return ToCSV(ApplyQuery(await service.GetAffiliatesCommunications(), Request.Query, false), fileName);
//        }

//        [HttpGet("/export/destinationTest/affiliatescommunications/excel")]
//        [HttpGet("/export/destinationTest/affiliatescommunications/excel(fileName='{fileName}')")]
//        public async Task<FileStreamResult> ExportAffiliatesCommunicationsToExcel(string fileName = null)
//        {
//            return ToExcel(ApplyQuery(await service.GetAffiliatesCommunications(), Request.Query, false), fileName);
//        }

//        [HttpGet("/export/destinationTest/affiliatesdata/csv")]
//        [HttpGet("/export/destinationTest/affiliatesdata/csv(fileName='{fileName}')")]
//        public async Task<FileStreamResult> ExportAffiliatesDataToCSV(string fileName = null)
//        {
//            return ToCSV(ApplyQuery(await service.GetAffiliatesData(), Request.Query, false), fileName);
//        }

//        [HttpGet("/export/destinationTest/affiliatesdata/excel")]
//        [HttpGet("/export/destinationTest/affiliatesdata/excel(fileName='{fileName}')")]
//        public async Task<FileStreamResult> ExportAffiliatesDataToExcel(string fileName = null)
//        {
//            return ToExcel(ApplyQuery(await service.GetAffiliatesData(), Request.Query, false), fileName);
//        }

//        [HttpGet("/export/destinationTest/affiliatespropertyviewhistories/csv")]
//        [HttpGet("/export/destinationTest/affiliatespropertyviewhistories/csv(fileName='{fileName}')")]
//        public async Task<FileStreamResult> ExportAffiliatesPropertyViewHistoriesToCSV(string fileName = null)
//        {
//            return ToCSV(ApplyQuery(await service.GetAffiliatesPropertyViewHistories(), Request.Query, false), fileName);
//        }

//        [HttpGet("/export/destinationTest/affiliatespropertyviewhistories/excel")]
//        [HttpGet("/export/destinationTest/affiliatespropertyviewhistories/excel(fileName='{fileName}')")]
//        public async Task<FileStreamResult> ExportAffiliatesPropertyViewHistoriesToExcel(string fileName = null)
//        {
//            return ToExcel(ApplyQuery(await service.GetAffiliatesPropertyViewHistories(), Request.Query, false), fileName);
//        }

//        [HttpGet("/export/destinationTest/affiliatestypes/csv")]
//        [HttpGet("/export/destinationTest/affiliatestypes/csv(fileName='{fileName}')")]
//        public async Task<FileStreamResult> ExportAffiliatesTypesToCSV(string fileName = null)
//        {
//            return ToCSV(ApplyQuery(await service.GetAffiliatesTypes(), Request.Query, false), fileName);
//        }

//        [HttpGet("/export/destinationTest/affiliatestypes/excel")]
//        [HttpGet("/export/destinationTest/affiliatestypes/excel(fileName='{fileName}')")]
//        public async Task<FileStreamResult> ExportAffiliatesTypesToExcel(string fileName = null)
//        {
//            return ToExcel(ApplyQuery(await service.GetAffiliatesTypes(), Request.Query, false), fileName);
//        }

//        [HttpGet("/export/destinationTest/agents/csv")]
//        [HttpGet("/export/destinationTest/agents/csv(fileName='{fileName}')")]
//        public async Task<FileStreamResult> ExportAgentsToCSV(string fileName = null)
//        {
//            return ToCSV(ApplyQuery(await service.GetAgents(), Request.Query, false), fileName);
//        }

//        [HttpGet("/export/destinationTest/agents/excel")]
//        [HttpGet("/export/destinationTest/agents/excel(fileName='{fileName}')")]
//        public async Task<FileStreamResult> ExportAgentsToExcel(string fileName = null)
//        {
//            return ToExcel(ApplyQuery(await service.GetAgents(), Request.Query, false), fileName);
//        }

//        [HttpGet("/export/destinationTest/agentstats/csv")]
//        [HttpGet("/export/destinationTest/agentstats/csv(fileName='{fileName}')")]
//        public async Task<FileStreamResult> ExportAgentstatsToCSV(string fileName = null)
//        {
//            return ToCSV(ApplyQuery(await service.GetAgentstats(), Request.Query, false), fileName);
//        }

//        [HttpGet("/export/destinationTest/agentstats/excel")]
//        [HttpGet("/export/destinationTest/agentstats/excel(fileName='{fileName}')")]
//        public async Task<FileStreamResult> ExportAgentstatsToExcel(string fileName = null)
//        {
//            return ToExcel(ApplyQuery(await service.GetAgentstats(), Request.Query, false), fileName);
//        }

//        [HttpGet("/export/destinationTest/agentstatuses/csv")]
//        [HttpGet("/export/destinationTest/agentstatuses/csv(fileName='{fileName}')")]
//        public async Task<FileStreamResult> ExportAgentStatusesToCSV(string fileName = null)
//        {
//            return null;
//                //ToCSV(ApplyQuery(await service.GetAgentStatuses(), Request.Query, false), fileName);
//        }

//        [HttpGet("/export/destinationTest/agentstatuses/excel")]
//        [HttpGet("/export/destinationTest/agentstatuses/excel(fileName='{fileName}')")]
//        public async Task<FileStreamResult> ExportAgentStatusesToExcel(string fileName = null)
//        {
//            return null;
//                //ToExcel(ApplyQuery(await service.GetAgentStatuses(), Request.Query, false), fileName);
//        }

//        [HttpGet("/export/destinationTest/agreementcontents/csv")]
//        [HttpGet("/export/destinationTest/agreementcontents/csv(fileName='{fileName}')")]
//        public async Task<FileStreamResult> ExportAgreementContentsToCSV(string fileName = null)
//        {
//            return ToCSV(ApplyQuery(await service.GetAgreementContents(), Request.Query, false), fileName);
//        }

//        [HttpGet("/export/destinationTest/agreementcontents/excel")]
//        [HttpGet("/export/destinationTest/agreementcontents/excel(fileName='{fileName}')")]
//        public async Task<FileStreamResult> ExportAgreementContentsToExcel(string fileName = null)
//        {
//            return ToExcel(ApplyQuery(await service.GetAgreementContents(), Request.Query, false), fileName);
//        }

//        [HttpGet("/export/destinationTest/agreementhistories/csv")]
//        [HttpGet("/export/destinationTest/agreementhistories/csv(fileName='{fileName}')")]
//        public async Task<FileStreamResult> ExportAgreementHistoriesToCSV(string fileName = null)
//        {
//            return ToCSV(ApplyQuery(await service.GetAgreementHistories(), Request.Query, false), fileName);
//        }

//        [HttpGet("/export/destinationTest/agreementhistories/excel")]
//        [HttpGet("/export/destinationTest/agreementhistories/excel(fileName='{fileName}')")]
//        public async Task<FileStreamResult> ExportAgreementHistoriesToExcel(string fileName = null)
//        {
//            return ToExcel(ApplyQuery(await service.GetAgreementHistories(), Request.Query, false), fileName);
//        }

//        [HttpGet("/export/destinationTest/airbnbapiautosynccontents/csv")]
//        [HttpGet("/export/destinationTest/airbnbapiautosynccontents/csv(fileName='{fileName}')")]
//        public async Task<FileStreamResult> ExportAirbnbApiAutoSyncContentsToCSV(string fileName = null)
//        {
//            return ToCSV(ApplyQuery(await service.GetAirbnbApiAutoSyncContents(), Request.Query, false), fileName);
//        }

//        [HttpGet("/export/destinationTest/airbnbapiautosynccontents/excel")]
//        [HttpGet("/export/destinationTest/airbnbapiautosynccontents/excel(fileName='{fileName}')")]
//        public async Task<FileStreamResult> ExportAirbnbApiAutoSyncContentsToExcel(string fileName = null)
//        {
//            return ToExcel(ApplyQuery(await service.GetAirbnbApiAutoSyncContents(), Request.Query, false), fileName);
//        }

//        [HttpGet("/export/destinationTest/airbnbapicredentials/csv")]
//        [HttpGet("/export/destinationTest/airbnbapicredentials/csv(fileName='{fileName}')")]
//        public async Task<FileStreamResult> ExportAirbnbApicredentialsToCSV(string fileName = null)
//        {
//            return ToCSV(ApplyQuery(await service.GetAirbnbApicredentials(), Request.Query, false), fileName);
//        }

//        [HttpGet("/export/destinationTest/airbnbapicredentials/excel")]
//        [HttpGet("/export/destinationTest/airbnbapicredentials/excel(fileName='{fileName}')")]
//        public async Task<FileStreamResult> ExportAirbnbApicredentialsToExcel(string fileName = null)
//        {
//            return ToExcel(ApplyQuery(await service.GetAirbnbApicredentials(), Request.Query, false), fileName);
//        }

//        [HttpGet("/export/destinationTest/airbnbapireservationsjsons/csv")]
//        [HttpGet("/export/destinationTest/airbnbapireservationsjsons/csv(fileName='{fileName}')")]
//        public async Task<FileStreamResult> ExportAirbnbApireservationsJsonsToCSV(string fileName = null)
//        {
//            return ToCSV(ApplyQuery(await service.GetAirbnbApireservationsJsons(), Request.Query, false), fileName);
//        }

//        [HttpGet("/export/destinationTest/airbnbapireservationsjsons/excel")]
//        [HttpGet("/export/destinationTest/airbnbapireservationsjsons/excel(fileName='{fileName}')")]
//        public async Task<FileStreamResult> ExportAirbnbApireservationsJsonsToExcel(string fileName = null)
//        {
//            return ToExcel(ApplyQuery(await service.GetAirbnbApireservationsJsons(), Request.Query, false), fileName);
//        }

//        [HttpGet("/export/destinationTest/airbnbexports/csv")]
//        [HttpGet("/export/destinationTest/airbnbexports/csv(fileName='{fileName}')")]
//        public async Task<FileStreamResult> ExportAirBnbExportsToCSV(string fileName = null)
//        {
//            return ToCSV(ApplyQuery(await service.GetAirBnbExports(), Request.Query, false), fileName);
//        }

//        [HttpGet("/export/destinationTest/airbnbexports/excel")]
//        [HttpGet("/export/destinationTest/airbnbexports/excel(fileName='{fileName}')")]
//        public async Task<FileStreamResult> ExportAirBnbExportsToExcel(string fileName = null)
//        {
//            return ToExcel(ApplyQuery(await service.GetAirBnbExports(), Request.Query, false), fileName);
//        }

//        [HttpGet("/export/destinationTest/airbnbicalsupdatetrackings/csv")]
//        [HttpGet("/export/destinationTest/airbnbicalsupdatetrackings/csv(fileName='{fileName}')")]
//        public async Task<FileStreamResult> ExportAirbnbIcalsUpdateTrackingsToCSV(string fileName = null)
//        {
//            return ToCSV(ApplyQuery(await service.GetAirbnbIcalsUpdateTrackings(), Request.Query, false), fileName);
//        }

//        [HttpGet("/export/destinationTest/airbnbicalsupdatetrackings/excel")]
//        [HttpGet("/export/destinationTest/airbnbicalsupdatetrackings/excel(fileName='{fileName}')")]
//        public async Task<FileStreamResult> ExportAirbnbIcalsUpdateTrackingsToExcel(string fileName = null)
//        {
//            return ToExcel(ApplyQuery(await service.GetAirbnbIcalsUpdateTrackings(), Request.Query, false), fileName);
//        }

//        [HttpGet("/export/destinationTest/airbnbmessages/csv")]
//        [HttpGet("/export/destinationTest/airbnbmessages/csv(fileName='{fileName}')")]
//        public async Task<FileStreamResult> ExportAirbnbMessagesToCSV(string fileName = null)
//        {
//            return ToCSV(ApplyQuery(await service.GetAirbnbMessages(), Request.Query, false), fileName);
//        }

//        [HttpGet("/export/destinationTest/airbnbmessages/excel")]
//        [HttpGet("/export/destinationTest/airbnbmessages/excel(fileName='{fileName}')")]
//        public async Task<FileStreamResult> ExportAirbnbMessagesToExcel(string fileName = null)
//        {
//            return ToExcel(ApplyQuery(await service.GetAirbnbMessages(), Request.Query, false), fileName);
//        }

//        [HttpGet("/export/destinationTest/airbnbsendmessages/csv")]
//        [HttpGet("/export/destinationTest/airbnbsendmessages/csv(fileName='{fileName}')")]
//        public async Task<FileStreamResult> ExportAirbnbSendMessagesToCSV(string fileName = null)
//        {
//            return ToCSV(ApplyQuery(await service.GetAirbnbSendMessages(), Request.Query, false), fileName);
//        }

//        [HttpGet("/export/destinationTest/airbnbsendmessages/excel")]
//        [HttpGet("/export/destinationTest/airbnbsendmessages/excel(fileName='{fileName}')")]
//        public async Task<FileStreamResult> ExportAirbnbSendMessagesToExcel(string fileName = null)
//        {
//            return ToExcel(ApplyQuery(await service.GetAirbnbSendMessages(), Request.Query, false), fileName);
//        }

//        [HttpGet("/export/destinationTest/airbnbuploadedphotos/csv")]
//        [HttpGet("/export/destinationTest/airbnbuploadedphotos/csv(fileName='{fileName}')")]
//        public async Task<FileStreamResult> ExportAirbnbUploadedPhotosToCSV(string fileName = null)
//        {
//            return ToCSV(ApplyQuery(await service.GetAirbnbUploadedPhotos(), Request.Query, false), fileName);
//        }

//        [HttpGet("/export/destinationTest/airbnbuploadedphotos/excel")]
//        [HttpGet("/export/destinationTest/airbnbuploadedphotos/excel(fileName='{fileName}')")]
//        public async Task<FileStreamResult> ExportAirbnbUploadedPhotosToExcel(string fileName = null)
//        {
//            return ToExcel(ApplyQuery(await service.GetAirbnbUploadedPhotos(), Request.Query, false), fileName);
//        }

//        [HttpGet("/export/destinationTest/annuals/csv")]
//        [HttpGet("/export/destinationTest/annuals/csv(fileName='{fileName}')")]
//        public async Task<FileStreamResult> ExportAnnualsToCSV(string fileName = null)
//        {
//            return ToCSV(ApplyQuery(await service.GetAnnuals(), Request.Query, false), fileName);
//        }

//        [HttpGet("/export/destinationTest/annuals/excel")]
//        [HttpGet("/export/destinationTest/annuals/excel(fileName='{fileName}')")]
//        public async Task<FileStreamResult> ExportAnnualsToExcel(string fileName = null)
//        {
//            return ToExcel(ApplyQuery(await service.GetAnnuals(), Request.Query, false), fileName);
//        }

//        [HttpGet("/export/destinationTest/annualsurveys/csv")]
//        [HttpGet("/export/destinationTest/annualsurveys/csv(fileName='{fileName}')")]
//        public async Task<FileStreamResult> ExportAnnualSurveysToCSV(string fileName = null)
//        {
//            return ToCSV(ApplyQuery(await service.GetAnnualSurveys(), Request.Query, false), fileName);
//        }

//        [HttpGet("/export/destinationTest/annualsurveys/excel")]
//        [HttpGet("/export/destinationTest/annualsurveys/excel(fileName='{fileName}')")]
//        public async Task<FileStreamResult> ExportAnnualSurveysToExcel(string fileName = null)
//        {
//            return ToExcel(ApplyQuery(await service.GetAnnualSurveys(), Request.Query, false), fileName);
//        }

//        [HttpGet("/export/destinationTest/annualtypes/csv")]
//        [HttpGet("/export/destinationTest/annualtypes/csv(fileName='{fileName}')")]
//        public async Task<FileStreamResult> ExportAnnualTypesToCSV(string fileName = null)
//        {
//            return ToCSV(ApplyQuery(await service.GetAnnualTypes(), Request.Query, false), fileName);
//        }

//        [HttpGet("/export/destinationTest/annualtypes/excel")]
//        [HttpGet("/export/destinationTest/annualtypes/excel(fileName='{fileName}')")]
//        public async Task<FileStreamResult> ExportAnnualTypesToExcel(string fileName = null)
//        {
//            return ToExcel(ApplyQuery(await service.GetAnnualTypes(), Request.Query, false), fileName);
//        }

//        [HttpGet("/export/destinationTest/appliedpromocodes/csv")]
//        [HttpGet("/export/destinationTest/appliedpromocodes/csv(fileName='{fileName}')")]
//        public async Task<FileStreamResult> ExportAppliedPromoCodesToCSV(string fileName = null)
//        {
//            return ToCSV(ApplyQuery(await service.GetAppliedPromoCodes(), Request.Query, false), fileName);
//        }

//        [HttpGet("/export/destinationTest/appliedpromocodes/excel")]
//        [HttpGet("/export/destinationTest/appliedpromocodes/excel(fileName='{fileName}')")]
//        public async Task<FileStreamResult> ExportAppliedPromoCodesToExcel(string fileName = null)
//        {
//            return ToExcel(ApplyQuery(await service.GetAppliedPromoCodes(), Request.Query, false), fileName);
//        }

//        [HttpGet("/export/destinationTest/autosmspageshitperdays/csv")]
//        [HttpGet("/export/destinationTest/autosmspageshitperdays/csv(fileName='{fileName}')")]
//        public async Task<FileStreamResult> ExportAutoSmspagesHitPerDaysToCSV(string fileName = null)
//        {
//            return ToCSV(ApplyQuery(await service.GetAutoSmspagesHitPerDays(), Request.Query, false), fileName);
//        }

//        [HttpGet("/export/destinationTest/autosmspageshitperdays/excel")]
//        [HttpGet("/export/destinationTest/autosmspageshitperdays/excel(fileName='{fileName}')")]
//        public async Task<FileStreamResult> ExportAutoSmspagesHitPerDaysToExcel(string fileName = null)
//        {
//            return ToExcel(ApplyQuery(await service.GetAutoSmspagesHitPerDays(), Request.Query, false), fileName);
//        }

//        [HttpGet("/export/destinationTest/bedcounts/csv")]
//        [HttpGet("/export/destinationTest/bedcounts/csv(fileName='{fileName}')")]
//        public async Task<FileStreamResult> ExportBedcountsToCSV(string fileName = null)
//        {
//            return ToCSV(ApplyQuery(await service.GetBedcounts(), Request.Query, false), fileName);
//        }

//        [HttpGet("/export/destinationTest/bedcounts/excel")]
//        [HttpGet("/export/destinationTest/bedcounts/excel(fileName='{fileName}')")]
//        public async Task<FileStreamResult> ExportBedcountsToExcel(string fileName = null)
//        {
//            return ToExcel(ApplyQuery(await service.GetBedcounts(), Request.Query, false), fileName);
//        }

//        [HttpGet("/export/destinationTest/bookingstatuses/csv")]
//        [HttpGet("/export/destinationTest/bookingstatuses/csv(fileName='{fileName}')")]
//        public async Task<FileStreamResult> ExportBookingStatusesToCSV(string fileName = null)
//        {
//            return ToCSV(ApplyQuery(await service.GetBookingStatuses(), Request.Query, false), fileName);
//        }

//        [HttpGet("/export/destinationTest/bookingstatuses/excel")]
//        [HttpGet("/export/destinationTest/bookingstatuses/excel(fileName='{fileName}')")]
//        public async Task<FileStreamResult> ExportBookingStatusesToExcel(string fileName = null)
//        {
//            return ToExcel(ApplyQuery(await service.GetBookingStatuses(), Request.Query, false), fileName);
//        }

//        [HttpGet("/export/destinationTest/bookingstatus1s/csv")]
//        [HttpGet("/export/destinationTest/bookingstatus1s/csv(fileName='{fileName}')")]
//        public async Task<FileStreamResult> ExportBookingStatus1SToCSV(string fileName = null)
//        {
//            return ToCSV(ApplyQuery(await service.GetBookingStatus1S(), Request.Query, false), fileName);
//        }

//        [HttpGet("/export/destinationTest/bookingstatus1s/excel")]
//        [HttpGet("/export/destinationTest/bookingstatus1s/excel(fileName='{fileName}')")]
//        public async Task<FileStreamResult> ExportBookingStatus1SToExcel(string fileName = null)
//        {
//            return ToExcel(ApplyQuery(await service.GetBookingStatus1S(), Request.Query, false), fileName);
//        }

//        [HttpGet("/export/destinationTest/bookingaddownerreports/csv")]
//        [HttpGet("/export/destinationTest/bookingaddownerreports/csv(fileName='{fileName}')")]
//        public async Task<FileStreamResult> ExportBookingAddOwnerReportsToCSV(string fileName = null)
//        {
//            return ToCSV(ApplyQuery(await service.GetBookingAddOwnerReports(), Request.Query, false), fileName);
//        }

//        [HttpGet("/export/destinationTest/bookingaddownerreports/excel")]
//        [HttpGet("/export/destinationTest/bookingaddownerreports/excel(fileName='{fileName}')")]
//        public async Task<FileStreamResult> ExportBookingAddOwnerReportsToExcel(string fileName = null)
//        {
//            return ToExcel(ApplyQuery(await service.GetBookingAddOwnerReports(), Request.Query, false), fileName);
//        }

//        [HttpGet("/export/destinationTest/bookingdamages/csv")]
//        [HttpGet("/export/destinationTest/bookingdamages/csv(fileName='{fileName}')")]
//        public async Task<FileStreamResult> ExportBookingdamagesToCSV(string fileName = null)
//        {
//            return ToCSV(ApplyQuery(await service.GetBookingdamages(), Request.Query, false), fileName);
//        }

//        [HttpGet("/export/destinationTest/bookingdamages/excel")]
//        [HttpGet("/export/destinationTest/bookingdamages/excel(fileName='{fileName}')")]
//        public async Task<FileStreamResult> ExportBookingdamagesToExcel(string fileName = null)
//        {
//            return ToExcel(ApplyQuery(await service.GetBookingdamages(), Request.Query, false), fileName);
//        }

//        [HttpGet("/export/destinationTest/bookingemailsettings/csv")]
//        [HttpGet("/export/destinationTest/bookingemailsettings/csv(fileName='{fileName}')")]
//        public async Task<FileStreamResult> ExportBookingEmailSettingsToCSV(string fileName = null)
//        {
//            return ToCSV(ApplyQuery(await service.GetBookingEmailSettings(), Request.Query, false), fileName);
//        }

//        [HttpGet("/export/destinationTest/bookingemailsettings/excel")]
//        [HttpGet("/export/destinationTest/bookingemailsettings/excel(fileName='{fileName}')")]
//        public async Task<FileStreamResult> ExportBookingEmailSettingsToExcel(string fileName = null)
//        {
//            return ToExcel(ApplyQuery(await service.GetBookingEmailSettings(), Request.Query, false), fileName);
//        }

//        [HttpGet("/export/destinationTest/bookinghistories/csv")]
//        [HttpGet("/export/destinationTest/bookinghistories/csv(fileName='{fileName}')")]
//        public async Task<FileStreamResult> ExportBookingHistoriesToCSV(string fileName = null)
//        {
//            return ToCSV(ApplyQuery(await service.GetBookingHistories(), Request.Query, false), fileName);
//        }

//        [HttpGet("/export/destinationTest/bookinghistories/excel")]
//        [HttpGet("/export/destinationTest/bookinghistories/excel(fileName='{fileName}')")]
//        public async Task<FileStreamResult> ExportBookingHistoriesToExcel(string fileName = null)
//        {
//            return ToExcel(ApplyQuery(await service.GetBookingHistories(), Request.Query, false), fileName);
//        }

//        [HttpGet("/export/destinationTest/bookingquotes/csv")]
//        [HttpGet("/export/destinationTest/bookingquotes/csv(fileName='{fileName}')")]
//        public async Task<FileStreamResult> ExportBookingQuotesToCSV(string fileName = null)
//        {
//            return ToCSV(ApplyQuery(await service.GetBookingQuotes(), Request.Query, false), fileName);
//        }

//        [HttpGet("/export/destinationTest/bookingquotes/excel")]
//        [HttpGet("/export/destinationTest/bookingquotes/excel(fileName='{fileName}')")]
//        public async Task<FileStreamResult> ExportBookingQuotesToExcel(string fileName = null)
//        {
//            return ToExcel(ApplyQuery(await service.GetBookingQuotes(), Request.Query, false), fileName);
//        }

//        [HttpGet("/export/destinationTest/bookings/csv")]
//        [HttpGet("/export/destinationTest/bookings/csv(fileName='{fileName}')")]
//        public async Task<FileStreamResult> ExportBookingsToCSV(string fileName = null)
//        {
//            return ToCSV(ApplyQuery(await service.GetBookings(), Request.Query, false), fileName);
//        }

//        [HttpGet("/export/destinationTest/bookings/excel")]
//        [HttpGet("/export/destinationTest/bookings/excel(fileName='{fileName}')")]
//        public async Task<FileStreamResult> ExportBookingsToExcel(string fileName = null)
//        {
//            return ToExcel(ApplyQuery(await service.GetBookings(), Request.Query, false), fileName);
//        }

//        [HttpGet("/export/destinationTest/bookingsowners/csv")]
//        [HttpGet("/export/destinationTest/bookingsowners/csv(fileName='{fileName}')")]
//        public async Task<FileStreamResult> ExportBookingsOwnersToCSV(string fileName = null)
//        {
//            return ToCSV(ApplyQuery(await service.GetBookingsOwners(), Request.Query, false), fileName);
//        }

//        [HttpGet("/export/destinationTest/bookingsowners/excel")]
//        [HttpGet("/export/destinationTest/bookingsowners/excel(fileName='{fileName}')")]
//        public async Task<FileStreamResult> ExportBookingsOwnersToExcel(string fileName = null)
//        {
//            return ToExcel(ApplyQuery(await service.GetBookingsOwners(), Request.Query, false), fileName);
//        }

//        [HttpGet("/export/destinationTest/bookingsvisiteds/csv")]
//        [HttpGet("/export/destinationTest/bookingsvisiteds/csv(fileName='{fileName}')")]
//        public async Task<FileStreamResult> ExportBookingsVisitedsToCSV(string fileName = null)
//        {
//            return ToCSV(ApplyQuery(await service.GetBookingsVisiteds(), Request.Query, false), fileName);
//        }

//        [HttpGet("/export/destinationTest/bookingsvisiteds/excel")]
//        [HttpGet("/export/destinationTest/bookingsvisiteds/excel(fileName='{fileName}')")]
//        public async Task<FileStreamResult> ExportBookingsVisitedsToExcel(string fileName = null)
//        {
//            return ToExcel(ApplyQuery(await service.GetBookingsVisiteds(), Request.Query, false), fileName);
//        }

//        [HttpGet("/export/destinationTest/bookingscodes/csv")]
//        [HttpGet("/export/destinationTest/bookingscodes/csv(fileName='{fileName}')")]
//        public async Task<FileStreamResult> ExportBookingsCodesToCSV(string fileName = null)
//        {
//            return ToCSV(ApplyQuery(await service.GetBookingsCodes(), Request.Query, false), fileName);
//        }

//        [HttpGet("/export/destinationTest/bookingscodes/excel")]
//        [HttpGet("/export/destinationTest/bookingscodes/excel(fileName='{fileName}')")]
//        public async Task<FileStreamResult> ExportBookingsCodesToExcel(string fileName = null)
//        {
//            return ToExcel(ApplyQuery(await service.GetBookingsCodes(), Request.Query, false), fileName);
//        }

//        [HttpGet("/export/destinationTest/bookingslargegroups/csv")]
//        [HttpGet("/export/destinationTest/bookingslargegroups/csv(fileName='{fileName}')")]
//        public async Task<FileStreamResult> ExportBookingsLargeGroupsToCSV(string fileName = null)
//        {
//            return ToCSV(ApplyQuery(await service.GetBookingsLargeGroups(), Request.Query, false), fileName);
//        }

//        [HttpGet("/export/destinationTest/bookingslargegroups/excel")]
//        [HttpGet("/export/destinationTest/bookingslargegroups/excel(fileName='{fileName}')")]
//        public async Task<FileStreamResult> ExportBookingsLargeGroupsToExcel(string fileName = null)
//        {
//            return ToExcel(ApplyQuery(await service.GetBookingsLargeGroups(), Request.Query, false), fileName);
//        }

//        [HttpGet("/export/destinationTest/bookingslogics/csv")]
//        [HttpGet("/export/destinationTest/bookingslogics/csv(fileName='{fileName}')")]
//        public async Task<FileStreamResult> ExportBookingsLogicsToCSV(string fileName = null)
//        {
//            return ToCSV(ApplyQuery(await service.GetBookingsLogics(), Request.Query, false), fileName);
//        }

//        [HttpGet("/export/destinationTest/bookingslogics/excel")]
//        [HttpGet("/export/destinationTest/bookingslogics/excel(fileName='{fileName}')")]
//        public async Task<FileStreamResult> ExportBookingsLogicsToExcel(string fileName = null)
//        {
//            return ToExcel(ApplyQuery(await service.GetBookingsLogics(), Request.Query, false), fileName);
//        }

//        [HttpGet("/export/destinationTest/bookingslogic2s/csv")]
//        [HttpGet("/export/destinationTest/bookingslogic2s/csv(fileName='{fileName}')")]
//        public async Task<FileStreamResult> ExportBookingsLogic2SToCSV(string fileName = null)
//        {
//            return ToCSV(ApplyQuery(await service.GetBookingsLogic2S(), Request.Query, false), fileName);
//        }

//        [HttpGet("/export/destinationTest/bookingslogic2s/excel")]
//        [HttpGet("/export/destinationTest/bookingslogic2s/excel(fileName='{fileName}')")]
//        public async Task<FileStreamResult> ExportBookingsLogic2SToExcel(string fileName = null)
//        {
//            return ToExcel(ApplyQuery(await service.GetBookingsLogic2S(), Request.Query, false), fileName);
//        }

//        [HttpGet("/export/destinationTest/bookingslogicvrbos/csv")]
//        [HttpGet("/export/destinationTest/bookingslogicvrbos/csv(fileName='{fileName}')")]
//        public async Task<FileStreamResult> ExportBookingsLogicVrbosToCSV(string fileName = null)
//        {
//            return ToCSV(ApplyQuery(await service.GetBookingsLogicVrbos(), Request.Query, false), fileName);
//        }

//        [HttpGet("/export/destinationTest/bookingslogicvrbos/excel")]
//        [HttpGet("/export/destinationTest/bookingslogicvrbos/excel(fileName='{fileName}')")]
//        public async Task<FileStreamResult> ExportBookingsLogicVrbosToExcel(string fileName = null)
//        {
//            return ToExcel(ApplyQuery(await service.GetBookingsLogicVrbos(), Request.Query, false), fileName);
//        }

//        [HttpGet("/export/destinationTest/bookingsoriginalpubrates/csv")]
//        [HttpGet("/export/destinationTest/bookingsoriginalpubrates/csv(fileName='{fileName}')")]
//        public async Task<FileStreamResult> ExportBookingsOriginalPubRatesToCSV(string fileName = null)
//        {
//            return ToCSV(ApplyQuery(await service.GetBookingsOriginalPubRates(), Request.Query, false), fileName);
//        }

//        [HttpGet("/export/destinationTest/bookingsoriginalpubrates/excel")]
//        [HttpGet("/export/destinationTest/bookingsoriginalpubrates/excel(fileName='{fileName}')")]
//        public async Task<FileStreamResult> ExportBookingsOriginalPubRatesToExcel(string fileName = null)
//        {
//            return ToExcel(ApplyQuery(await service.GetBookingsOriginalPubRates(), Request.Query, false), fileName);
//        }

//        [HttpGet("/export/destinationTest/brokers/csv")]
//        [HttpGet("/export/destinationTest/brokers/csv(fileName='{fileName}')")]
//        public async Task<FileStreamResult> ExportBrokersToCSV(string fileName = null)
//        {
//            return ToCSV(ApplyQuery(await service.GetBrokers(), Request.Query, false), fileName);
//        }

//        [HttpGet("/export/destinationTest/brokers/excel")]
//        [HttpGet("/export/destinationTest/brokers/excel(fileName='{fileName}')")]
//        public async Task<FileStreamResult> ExportBrokersToExcel(string fileName = null)
//        {
//            return ToExcel(ApplyQuery(await service.GetBrokers(), Request.Query, false), fileName);
//        }

//        [HttpGet("/export/destinationTest/bulksmstests/csv")]
//        [HttpGet("/export/destinationTest/bulksmstests/csv(fileName='{fileName}')")]
//        public async Task<FileStreamResult> ExportBulkSmstestsToCSV(string fileName = null)
//        {
//            return ToCSV(ApplyQuery(await service.GetBulkSmstests(), Request.Query, false), fileName);
//        }

//        [HttpGet("/export/destinationTest/bulksmstests/excel")]
//        [HttpGet("/export/destinationTest/bulksmstests/excel(fileName='{fileName}')")]
//        public async Task<FileStreamResult> ExportBulkSmstestsToExcel(string fileName = null)
//        {
//            return ToExcel(ApplyQuery(await service.GetBulkSmstests(), Request.Query, false), fileName);
//        }

//        [HttpGet("/export/destinationTest/bulksmstest1s/csv")]
//        [HttpGet("/export/destinationTest/bulksmstest1s/csv(fileName='{fileName}')")]
//        public async Task<FileStreamResult> ExportBulkSmstest1SToCSV(string fileName = null)
//        {
//            return ToCSV(ApplyQuery(await service.GetBulkSmstest1S(), Request.Query, false), fileName);
//        }

//        [HttpGet("/export/destinationTest/bulksmstest1s/excel")]
//        [HttpGet("/export/destinationTest/bulksmstest1s/excel(fileName='{fileName}')")]
//        public async Task<FileStreamResult> ExportBulkSmstest1SToExcel(string fileName = null)
//        {
//            return ToExcel(ApplyQuery(await service.GetBulkSmstest1S(), Request.Query, false), fileName);
//        }

//        [HttpGet("/export/destinationTest/calenderfilebookings/csv")]
//        [HttpGet("/export/destinationTest/calenderfilebookings/csv(fileName='{fileName}')")]
//        public async Task<FileStreamResult> ExportCalenderFileBookingsToCSV(string fileName = null)
//        {
//            return ToCSV(ApplyQuery(await service.GetCalenderFileBookings(), Request.Query, false), fileName);
//        }

//        [HttpGet("/export/destinationTest/calenderfilebookings/excel")]
//        [HttpGet("/export/destinationTest/calenderfilebookings/excel(fileName='{fileName}')")]
//        public async Task<FileStreamResult> ExportCalenderFileBookingsToExcel(string fileName = null)
//        {
//            return ToExcel(ApplyQuery(await service.GetCalenderFileBookings(), Request.Query, false), fileName);
//        }

//        [HttpGet("/export/destinationTest/campaigns/csv")]
//        [HttpGet("/export/destinationTest/campaigns/csv(fileName='{fileName}')")]
//        public async Task<FileStreamResult> ExportCampaignsToCSV(string fileName = null)
//        {
//            return ToCSV(ApplyQuery(await service.GetCampaigns(), Request.Query, false), fileName);
//        }

//        [HttpGet("/export/destinationTest/campaigns/excel")]
//        [HttpGet("/export/destinationTest/campaigns/excel(fileName='{fileName}')")]
//        public async Task<FileStreamResult> ExportCampaignsToExcel(string fileName = null)
//        {
//            return ToExcel(ApplyQuery(await service.GetCampaigns(), Request.Query, false), fileName);
//        }

//        [HttpGet("/export/destinationTest/channels/csv")]
//        [HttpGet("/export/destinationTest/channels/csv(fileName='{fileName}')")]
//        public async Task<FileStreamResult> ExportChannelsToCSV(string fileName = null)
//        {
//            return ToCSV(ApplyQuery(await service.GetChannels(), Request.Query, false), fileName);
//        }

//        [HttpGet("/export/destinationTest/channels/excel")]
//        [HttpGet("/export/destinationTest/channels/excel(fileName='{fileName}')")]
//        public async Task<FileStreamResult> ExportChannelsToExcel(string fileName = null)
//        {
//            return ToExcel(ApplyQuery(await service.GetChannels(), Request.Query, false), fileName);
//        }

//        [HttpGet("/export/destinationTest/channelbus/csv")]
//        [HttpGet("/export/destinationTest/channelbus/csv(fileName='{fileName}')")]
//        public async Task<FileStreamResult> ExportChannelBusToCSV(string fileName = null)
//        {
//            return ToCSV(ApplyQuery(await service.GetChannelBus(), Request.Query, false), fileName);
//        }

//        [HttpGet("/export/destinationTest/channelbus/excel")]
//        [HttpGet("/export/destinationTest/channelbus/excel(fileName='{fileName}')")]
//        public async Task<FileStreamResult> ExportChannelBusToExcel(string fileName = null)
//        {
//            return ToExcel(ApplyQuery(await service.GetChannelBus(), Request.Query, false), fileName);
//        }

//        [HttpGet("/export/destinationTest/channelpartials/csv")]
//        [HttpGet("/export/destinationTest/channelpartials/csv(fileName='{fileName}')")]
//        public async Task<FileStreamResult> ExportChannelPartialsToCSV(string fileName = null)
//        {
//            return ToCSV(ApplyQuery(await service.GetChannelPartials(), Request.Query, false), fileName);
//        }

//        [HttpGet("/export/destinationTest/channelpartials/excel")]
//        [HttpGet("/export/destinationTest/channelpartials/excel(fileName='{fileName}')")]
//        public async Task<FileStreamResult> ExportChannelPartialsToExcel(string fileName = null)
//        {
//            return ToExcel(ApplyQuery(await service.GetChannelPartials(), Request.Query, false), fileName);
//        }

//        [HttpGet("/export/destinationTest/channelpartnerhits/csv")]
//        [HttpGet("/export/destinationTest/channelpartnerhits/csv(fileName='{fileName}')")]
//        public async Task<FileStreamResult> ExportChannelPartnerHitsToCSV(string fileName = null)
//        {
//            return ToCSV(ApplyQuery(await service.GetChannelPartnerHits(), Request.Query, false), fileName);
//        }

//        [HttpGet("/export/destinationTest/channelpartnerhits/excel")]
//        [HttpGet("/export/destinationTest/channelpartnerhits/excel(fileName='{fileName}')")]
//        public async Task<FileStreamResult> ExportChannelPartnerHitsToExcel(string fileName = null)
//        {
//            return ToExcel(ApplyQuery(await service.GetChannelPartnerHits(), Request.Query, false), fileName);
//        }

//        [HttpGet("/export/destinationTest/channelvariances/csv")]
//        [HttpGet("/export/destinationTest/channelvariances/csv(fileName='{fileName}')")]
//        public async Task<FileStreamResult> ExportChannelVariancesToCSV(string fileName = null)
//        {
//            return ToCSV(ApplyQuery(await service.GetChannelVariances(), Request.Query, false), fileName);
//        }

//        [HttpGet("/export/destinationTest/channelvariances/excel")]
//        [HttpGet("/export/destinationTest/channelvariances/excel(fileName='{fileName}')")]
//        public async Task<FileStreamResult> ExportChannelVariancesToExcel(string fileName = null)
//        {
//            return ToExcel(ApplyQuery(await service.GetChannelVariances(), Request.Query, false), fileName);
//        }

//        [HttpGet("/export/destinationTest/chatbookings/csv")]
//        [HttpGet("/export/destinationTest/chatbookings/csv(fileName='{fileName}')")]
//        public async Task<FileStreamResult> ExportChatbookingsToCSV(string fileName = null)
//        {
//            return ToCSV(ApplyQuery(await service.GetChatbookings(), Request.Query, false), fileName);
//        }

//        [HttpGet("/export/destinationTest/chatbookings/excel")]
//        [HttpGet("/export/destinationTest/chatbookings/excel(fileName='{fileName}')")]
//        public async Task<FileStreamResult> ExportChatbookingsToExcel(string fileName = null)
//        {
//            return ToExcel(ApplyQuery(await service.GetChatbookings(), Request.Query, false), fileName);
//        }

//        [HttpGet("/export/destinationTest/chatbotkeywordmasters/csv")]
//        [HttpGet("/export/destinationTest/chatbotkeywordmasters/csv(fileName='{fileName}')")]
//        public async Task<FileStreamResult> ExportChatBotKeywordMastersToCSV(string fileName = null)
//        {
//            return ToCSV(ApplyQuery(await service.GetChatBotKeywordMasters(), Request.Query, false), fileName);
//        }

//        [HttpGet("/export/destinationTest/chatbotkeywordmasters/excel")]
//        [HttpGet("/export/destinationTest/chatbotkeywordmasters/excel(fileName='{fileName}')")]
//        public async Task<FileStreamResult> ExportChatBotKeywordMastersToExcel(string fileName = null)
//        {
//            return ToExcel(ApplyQuery(await service.GetChatBotKeywordMasters(), Request.Query, false), fileName);
//        }

//        [HttpGet("/export/destinationTest/chatbotmenumasters/csv")]
//        [HttpGet("/export/destinationTest/chatbotmenumasters/csv(fileName='{fileName}')")]
//        public async Task<FileStreamResult> ExportChatBotMenuMastersToCSV(string fileName = null)
//        {
//            return ToCSV(ApplyQuery(await service.GetChatBotMenuMasters(), Request.Query, false), fileName);
//        }

//        [HttpGet("/export/destinationTest/chatbotmenumasters/excel")]
//        [HttpGet("/export/destinationTest/chatbotmenumasters/excel(fileName='{fileName}')")]
//        public async Task<FileStreamResult> ExportChatBotMenuMastersToExcel(string fileName = null)
//        {
//            return ToExcel(ApplyQuery(await service.GetChatBotMenuMasters(), Request.Query, false), fileName);
//        }

//        [HttpGet("/export/destinationTest/checkincheckoutsettings/csv")]
//        [HttpGet("/export/destinationTest/checkincheckoutsettings/csv(fileName='{fileName}')")]
//        public async Task<FileStreamResult> ExportCheckInCheckOutSettingsToCSV(string fileName = null)
//        {
//            return ToCSV(ApplyQuery(await service.GetCheckInCheckOutSettings(), Request.Query, false), fileName);
//        }

//        [HttpGet("/export/destinationTest/checkincheckoutsettings/excel")]
//        [HttpGet("/export/destinationTest/checkincheckoutsettings/excel(fileName='{fileName}')")]
//        public async Task<FileStreamResult> ExportCheckInCheckOutSettingsToExcel(string fileName = null)
//        {
//            return ToExcel(ApplyQuery(await service.GetCheckInCheckOutSettings(), Request.Query, false), fileName);
//        }

//        [HttpGet("/export/destinationTest/checkinlogs/csv")]
//        [HttpGet("/export/destinationTest/checkinlogs/csv(fileName='{fileName}')")]
//        public async Task<FileStreamResult> ExportCheckInLogsToCSV(string fileName = null)
//        {
//            return ToCSV(ApplyQuery(await service.GetCheckInLogs(), Request.Query, false), fileName);
//        }

//        [HttpGet("/export/destinationTest/checkinlogs/excel")]
//        [HttpGet("/export/destinationTest/checkinlogs/excel(fileName='{fileName}')")]
//        public async Task<FileStreamResult> ExportCheckInLogsToExcel(string fileName = null)
//        {
//            return ToExcel(ApplyQuery(await service.GetCheckInLogs(), Request.Query, false), fileName);
//        }

//        [HttpGet("/export/destinationTest/cleanerauditedmsgs/csv")]
//        [HttpGet("/export/destinationTest/cleanerauditedmsgs/csv(fileName='{fileName}')")]
//        public async Task<FileStreamResult> ExportCleanerAuditedMsgsToCSV(string fileName = null)
//        {
//            return ToCSV(ApplyQuery(await service.GetCleanerAuditedMsgs(), Request.Query, false), fileName);
//        }

//        [HttpGet("/export/destinationTest/cleanerauditedmsgs/excel")]
//        [HttpGet("/export/destinationTest/cleanerauditedmsgs/excel(fileName='{fileName}')")]
//        public async Task<FileStreamResult> ExportCleanerAuditedMsgsToExcel(string fileName = null)
//        {
//            return ToExcel(ApplyQuery(await service.GetCleanerAuditedMsgs(), Request.Query, false), fileName);
//        }

//        [HttpGet("/export/destinationTest/cleanergroups/csv")]
//        [HttpGet("/export/destinationTest/cleanergroups/csv(fileName='{fileName}')")]
//        public async Task<FileStreamResult> ExportCleanerGroupsToCSV(string fileName = null)
//        {
//            return ToCSV(ApplyQuery(await service.GetCleanerGroups(), Request.Query, false), fileName);
//        }

//        [HttpGet("/export/destinationTest/cleanergroups/excel")]
//        [HttpGet("/export/destinationTest/cleanergroups/excel(fileName='{fileName}')")]
//        public async Task<FileStreamResult> ExportCleanerGroupsToExcel(string fileName = null)
//        {
//            return ToExcel(ApplyQuery(await service.GetCleanerGroups(), Request.Query, false), fileName);
//        }

//        [HttpGet("/export/destinationTest/cleanerinvoicematcheddata/csv")]
//        [HttpGet("/export/destinationTest/cleanerinvoicematcheddata/csv(fileName='{fileName}')")]
//        public async Task<FileStreamResult> ExportCleanerInvoiceMatchedDataToCSV(string fileName = null)
//        {
//            return ToCSV(ApplyQuery(await service.GetCleanerInvoiceMatchedData(), Request.Query, false), fileName);
//        }

//        [HttpGet("/export/destinationTest/cleanerinvoicematcheddata/excel")]
//        [HttpGet("/export/destinationTest/cleanerinvoicematcheddata/excel(fileName='{fileName}')")]
//        public async Task<FileStreamResult> ExportCleanerInvoiceMatchedDataToExcel(string fileName = null)
//        {
//            return ToExcel(ApplyQuery(await service.GetCleanerInvoiceMatchedData(), Request.Query, false), fileName);
//        }

//        [HttpGet("/export/destinationTest/cleanernos/csv")]
//        [HttpGet("/export/destinationTest/cleanernos/csv(fileName='{fileName}')")]
//        public async Task<FileStreamResult> ExportCleanerNosToCSV(string fileName = null)
//        {
//            return ToCSV(ApplyQuery(await service.GetCleanerNos(), Request.Query, false), fileName);
//        }

//        [HttpGet("/export/destinationTest/cleanernos/excel")]
//        [HttpGet("/export/destinationTest/cleanernos/excel(fileName='{fileName}')")]
//        public async Task<FileStreamResult> ExportCleanerNosToExcel(string fileName = null)
//        {
//            return ToExcel(ApplyQuery(await service.GetCleanerNos(), Request.Query, false), fileName);
//        }

//        [HttpGet("/export/destinationTest/cleaningpayrolextrataskdetails/csv")]
//        [HttpGet("/export/destinationTest/cleaningpayrolextrataskdetails/csv(fileName='{fileName}')")]
//        public async Task<FileStreamResult> ExportCleaningPayrolExtraTaskDetailsToCSV(string fileName = null)
//        {
//            return ToCSV(ApplyQuery(await service.GetCleaningPayrolExtraTaskDetails(), Request.Query, false), fileName);
//        }

//        [HttpGet("/export/destinationTest/cleaningpayrolextrataskdetails/excel")]
//        [HttpGet("/export/destinationTest/cleaningpayrolextrataskdetails/excel(fileName='{fileName}')")]
//        public async Task<FileStreamResult> ExportCleaningPayrolExtraTaskDetailsToExcel(string fileName = null)
//        {
//            return ToExcel(ApplyQuery(await service.GetCleaningPayrolExtraTaskDetails(), Request.Query, false), fileName);
//        }

//        [HttpGet("/export/destinationTest/cleaningvariances/csv")]
//        [HttpGet("/export/destinationTest/cleaningvariances/csv(fileName='{fileName}')")]
//        public async Task<FileStreamResult> ExportCleaningVariancesToCSV(string fileName = null)
//        {
//            return ToCSV(ApplyQuery(await service.GetCleaningVariances(), Request.Query, false), fileName);
//        }

//        [HttpGet("/export/destinationTest/cleaningvariances/excel")]
//        [HttpGet("/export/destinationTest/cleaningvariances/excel(fileName='{fileName}')")]
//        public async Task<FileStreamResult> ExportCleaningVariancesToExcel(string fileName = null)
//        {
//            return ToExcel(ApplyQuery(await service.GetCleaningVariances(), Request.Query, false), fileName);
//        }

//        [HttpGet("/export/destinationTest/commcodes/csv")]
//        [HttpGet("/export/destinationTest/commcodes/csv(fileName='{fileName}')")]
//        public async Task<FileStreamResult> ExportCommCodesToCSV(string fileName = null)
//        {
//            return ToCSV(ApplyQuery(await service.GetCommCodes(), Request.Query, false), fileName);
//        }

//        [HttpGet("/export/destinationTest/commcodes/excel")]
//        [HttpGet("/export/destinationTest/commcodes/excel(fileName='{fileName}')")]
//        public async Task<FileStreamResult> ExportCommCodesToExcel(string fileName = null)
//        {
//            return ToExcel(ApplyQuery(await service.GetCommCodes(), Request.Query, false), fileName);
//        }

//        [HttpGet("/export/destinationTest/communications/csv")]
//        [HttpGet("/export/destinationTest/communications/csv(fileName='{fileName}')")]
//        public async Task<FileStreamResult> ExportCommunicationsToCSV(string fileName = null)
//        {
//            return ToCSV(ApplyQuery(await service.GetCommunications(), Request.Query, false), fileName);
//        }

//        [HttpGet("/export/destinationTest/communications/excel")]
//        [HttpGet("/export/destinationTest/communications/excel(fileName='{fileName}')")]
//        public async Task<FileStreamResult> ExportCommunicationsToExcel(string fileName = null)
//        {
//            return ToExcel(ApplyQuery(await service.GetCommunications(), Request.Query, false), fileName);
//        }

//        [HttpGet("/export/destinationTest/companyhistories/csv")]
//        [HttpGet("/export/destinationTest/companyhistories/csv(fileName='{fileName}')")]
//        public async Task<FileStreamResult> ExportCompanyHistoriesToCSV(string fileName = null)
//        {
//            return ToCSV(ApplyQuery(await service.GetCompanyHistories(), Request.Query, false), fileName);
//        }

//        [HttpGet("/export/destinationTest/companyhistories/excel")]
//        [HttpGet("/export/destinationTest/companyhistories/excel(fileName='{fileName}')")]
//        public async Task<FileStreamResult> ExportCompanyHistoriesToExcel(string fileName = null)
//        {
//            return ToExcel(ApplyQuery(await service.GetCompanyHistories(), Request.Query, false), fileName);
//        }

//        [HttpGet("/export/destinationTest/contracttables/csv")]
//        [HttpGet("/export/destinationTest/contracttables/csv(fileName='{fileName}')")]
//        public async Task<FileStreamResult> ExportContractTablesToCSV(string fileName = null)
//        {
//            return ToCSV(ApplyQuery(await service.GetContractTables(), Request.Query, false), fileName);
//        }

//        [HttpGet("/export/destinationTest/contracttables/excel")]
//        [HttpGet("/export/destinationTest/contracttables/excel(fileName='{fileName}')")]
//        public async Task<FileStreamResult> ExportContractTablesToExcel(string fileName = null)
//        {
//            return ToExcel(ApplyQuery(await service.GetContractTables(), Request.Query, false), fileName);
//        }

//        [HttpGet("/export/destinationTest/controllists/csv")]
//        [HttpGet("/export/destinationTest/controllists/csv(fileName='{fileName}')")]
//        public async Task<FileStreamResult> ExportControllistsToCSV(string fileName = null)
//        {
//            return ToCSV(ApplyQuery(await service.GetControllists(), Request.Query, false), fileName);
//        }

//        [HttpGet("/export/destinationTest/controllists/excel")]
//        [HttpGet("/export/destinationTest/controllists/excel(fileName='{fileName}')")]
//        public async Task<FileStreamResult> ExportControllistsToExcel(string fileName = null)
//        {
//            return ToExcel(ApplyQuery(await service.GetControllists(), Request.Query, false), fileName);
//        }

//        [HttpGet("/export/destinationTest/controllogs/csv")]
//        [HttpGet("/export/destinationTest/controllogs/csv(fileName='{fileName}')")]
//        public async Task<FileStreamResult> ExportControllogsToCSV(string fileName = null)
//        {
//            return ToCSV(ApplyQuery(await service.GetControllogs(), Request.Query, false), fileName);
//        }

//        [HttpGet("/export/destinationTest/controllogs/excel")]
//        [HttpGet("/export/destinationTest/controllogs/excel(fileName='{fileName}')")]
//        public async Task<FileStreamResult> ExportControllogsToExcel(string fileName = null)
//        {
//            return ToExcel(ApplyQuery(await service.GetControllogs(), Request.Query, false), fileName);
//        }

//        [HttpGet("/export/destinationTest/coronaannualdata/csv")]
//        [HttpGet("/export/destinationTest/coronaannualdata/csv(fileName='{fileName}')")]
//        public async Task<FileStreamResult> ExportCoronaAnnualDataToCSV(string fileName = null)
//        {
//            return ToCSV(ApplyQuery(await service.GetCoronaAnnualData(), Request.Query, false), fileName);
//        }

//        [HttpGet("/export/destinationTest/coronaannualdata/excel")]
//        [HttpGet("/export/destinationTest/coronaannualdata/excel(fileName='{fileName}')")]
//        public async Task<FileStreamResult> ExportCoronaAnnualDataToExcel(string fileName = null)
//        {
//            return ToExcel(ApplyQuery(await service.GetCoronaAnnualData(), Request.Query, false), fileName);
//        }

//        [HttpGet("/export/destinationTest/creditrequests/csv")]
//        [HttpGet("/export/destinationTest/creditrequests/csv(fileName='{fileName}')")]
//        public async Task<FileStreamResult> ExportCreditRequestsToCSV(string fileName = null)
//        {
//            return ToCSV(ApplyQuery(await service.GetCreditRequests(), Request.Query, false), fileName);
//        }

//        [HttpGet("/export/destinationTest/creditrequests/excel")]
//        [HttpGet("/export/destinationTest/creditrequests/excel(fileName='{fileName}')")]
//        public async Task<FileStreamResult> ExportCreditRequestsToExcel(string fileName = null)
//        {
//            return ToExcel(ApplyQuery(await service.GetCreditRequests(), Request.Query, false), fileName);
//        }

//        [HttpGet("/export/destinationTest/creditrequesttypes/csv")]
//        [HttpGet("/export/destinationTest/creditrequesttypes/csv(fileName='{fileName}')")]
//        public async Task<FileStreamResult> ExportCreditRequestTypesToCSV(string fileName = null)
//        {
//            return ToCSV(ApplyQuery(await service.GetCreditRequestTypes(), Request.Query, false), fileName);
//        }

//        [HttpGet("/export/destinationTest/creditrequesttypes/excel")]
//        [HttpGet("/export/destinationTest/creditrequesttypes/excel(fileName='{fileName}')")]
//        public async Task<FileStreamResult> ExportCreditRequestTypesToExcel(string fileName = null)
//        {
//            return ToExcel(ApplyQuery(await service.GetCreditRequestTypes(), Request.Query, false), fileName);
//        }

//        [HttpGet("/export/destinationTest/criticaltaskwarnings/csv")]
//        [HttpGet("/export/destinationTest/criticaltaskwarnings/csv(fileName='{fileName}')")]
//        public async Task<FileStreamResult> ExportCriticalTaskWarningsToCSV(string fileName = null)
//        {
//            return ToCSV(ApplyQuery(await service.GetCriticalTaskWarnings(), Request.Query, false), fileName);
//        }

//        [HttpGet("/export/destinationTest/criticaltaskwarnings/excel")]
//        [HttpGet("/export/destinationTest/criticaltaskwarnings/excel(fileName='{fileName}')")]
//        public async Task<FileStreamResult> ExportCriticalTaskWarningsToExcel(string fileName = null)
//        {
//            return ToExcel(ApplyQuery(await service.GetCriticalTaskWarnings(), Request.Query, false), fileName);
//        }

//        [HttpGet("/export/destinationTest/currentdiscounts/csv")]
//        [HttpGet("/export/destinationTest/currentdiscounts/csv(fileName='{fileName}')")]
//        public async Task<FileStreamResult> ExportCurrentdiscountsToCSV(string fileName = null)
//        {
//            return ToCSV(ApplyQuery(await service.GetCurrentdiscounts(), Request.Query, false), fileName);
//        }

//        [HttpGet("/export/destinationTest/currentdiscounts/excel")]
//        [HttpGet("/export/destinationTest/currentdiscounts/excel(fileName='{fileName}')")]
//        public async Task<FileStreamResult> ExportCurrentdiscountsToExcel(string fileName = null)
//        {
//            return ToExcel(ApplyQuery(await service.GetCurrentdiscounts(), Request.Query, false), fileName);
//        }

//        [HttpGet("/export/destinationTest/currentdiscountshistories/csv")]
//        [HttpGet("/export/destinationTest/currentdiscountshistories/csv(fileName='{fileName}')")]
//        public async Task<FileStreamResult> ExportCurrentDiscountsHistoriesToCSV(string fileName = null)
//        {
//            return ToCSV(ApplyQuery(await service.GetCurrentDiscountsHistories(), Request.Query, false), fileName);
//        }

//        [HttpGet("/export/destinationTest/currentdiscountshistories/excel")]
//        [HttpGet("/export/destinationTest/currentdiscountshistories/excel(fileName='{fileName}')")]
//        public async Task<FileStreamResult> ExportCurrentDiscountsHistoriesToExcel(string fileName = null)
//        {
//            return ToExcel(ApplyQuery(await service.GetCurrentDiscountsHistories(), Request.Query, false), fileName);
//        }

//        [HttpGet("/export/destinationTest/dailyprocessedminnights/csv")]
//        [HttpGet("/export/destinationTest/dailyprocessedminnights/csv(fileName='{fileName}')")]
//        public async Task<FileStreamResult> ExportDailyProcessedMinNightsToCSV(string fileName = null)
//        {
//            return ToCSV(ApplyQuery(await service.GetDailyProcessedMinNights(), Request.Query, false), fileName);
//        }

//        [HttpGet("/export/destinationTest/dailyprocessedminnights/excel")]
//        [HttpGet("/export/destinationTest/dailyprocessedminnights/excel(fileName='{fileName}')")]
//        public async Task<FileStreamResult> ExportDailyProcessedMinNightsToExcel(string fileName = null)
//        {
//            return ToExcel(ApplyQuery(await service.GetDailyProcessedMinNights(), Request.Query, false), fileName);
//        }

//        [HttpGet("/export/destinationTest/dailyratesbasedonpropertyrates/csv")]
//        [HttpGet("/export/destinationTest/dailyratesbasedonpropertyrates/csv(fileName='{fileName}')")]
//        public async Task<FileStreamResult> ExportDailyRatesBasedOnPropertyRatesToCSV(string fileName = null)
//        {
//            return ToCSV(ApplyQuery(await service.GetDailyRatesBasedOnPropertyRates(), Request.Query, false), fileName);
//        }

//        [HttpGet("/export/destinationTest/dailyratesbasedonpropertyrates/excel")]
//        [HttpGet("/export/destinationTest/dailyratesbasedonpropertyrates/excel(fileName='{fileName}')")]
//        public async Task<FileStreamResult> ExportDailyRatesBasedOnPropertyRatesToExcel(string fileName = null)
//        {
//            return ToExcel(ApplyQuery(await service.GetDailyRatesBasedOnPropertyRates(), Request.Query, false), fileName);
//        }

//        [HttpGet("/export/destinationTest/dailystats/csv")]
//        [HttpGet("/export/destinationTest/dailystats/csv(fileName='{fileName}')")]
//        public async Task<FileStreamResult> ExportDailyStatsToCSV(string fileName = null)
//        {
//            return ToCSV(ApplyQuery(await service.GetDailyStats(), Request.Query, false), fileName);
//        }

//        [HttpGet("/export/destinationTest/dailystats/excel")]
//        [HttpGet("/export/destinationTest/dailystats/excel(fileName='{fileName}')")]
//        public async Task<FileStreamResult> ExportDailyStatsToExcel(string fileName = null)
//        {
//            return ToExcel(ApplyQuery(await service.GetDailyStats(), Request.Query, false), fileName);
//        }

//        [HttpGet("/export/destinationTest/deletedgapholderbookings/csv")]
//        [HttpGet("/export/destinationTest/deletedgapholderbookings/csv(fileName='{fileName}')")]
//        public async Task<FileStreamResult> ExportDeletedGapHolderBookingsToCSV(string fileName = null)
//        {
//            return ToCSV(ApplyQuery(await service.GetDeletedGapHolderBookings(), Request.Query, false), fileName);
//        }

//        [HttpGet("/export/destinationTest/deletedgapholderbookings/excel")]
//        [HttpGet("/export/destinationTest/deletedgapholderbookings/excel(fileName='{fileName}')")]
//        public async Task<FileStreamResult> ExportDeletedGapHolderBookingsToExcel(string fileName = null)
//        {
//            return ToExcel(ApplyQuery(await service.GetDeletedGapHolderBookings(), Request.Query, false), fileName);
//        }

//        [HttpGet("/export/destinationTest/depositholdlogs/csv")]
//        [HttpGet("/export/destinationTest/depositholdlogs/csv(fileName='{fileName}')")]
//        public async Task<FileStreamResult> ExportDepositHoldLogsToCSV(string fileName = null)
//        {
//            return ToCSV(ApplyQuery(await service.GetDepositHoldLogs(), Request.Query, false), fileName);
//        }

//        [HttpGet("/export/destinationTest/depositholdlogs/excel")]
//        [HttpGet("/export/destinationTest/depositholdlogs/excel(fileName='{fileName}')")]
//        public async Task<FileStreamResult> ExportDepositHoldLogsToExcel(string fileName = null)
//        {
//            return ToExcel(ApplyQuery(await service.GetDepositHoldLogs(), Request.Query, false), fileName);
//        }

//        [HttpGet("/export/destinationTest/discounts/csv")]
//        [HttpGet("/export/destinationTest/discounts/csv(fileName='{fileName}')")]
//        public async Task<FileStreamResult> ExportDiscountsToCSV(string fileName = null)
//        {
//            return ToCSV(ApplyQuery(await service.GetDiscounts(), Request.Query, false), fileName);
//        }

//        [HttpGet("/export/destinationTest/discounts/excel")]
//        [HttpGet("/export/destinationTest/discounts/excel(fileName='{fileName}')")]
//        public async Task<FileStreamResult> ExportDiscountsToExcel(string fileName = null)
//        {
//            return ToExcel(ApplyQuery(await service.GetDiscounts(), Request.Query, false), fileName);
//        }

//        [HttpGet("/export/destinationTest/donotrents/csv")]
//        [HttpGet("/export/destinationTest/donotrents/csv(fileName='{fileName}')")]
//        public async Task<FileStreamResult> ExportDoNotRentsToCSV(string fileName = null)
//        {
//            return ToCSV(ApplyQuery(await service.GetDoNotRents(), Request.Query, false), fileName);
//        }

//        [HttpGet("/export/destinationTest/donotrents/excel")]
//        [HttpGet("/export/destinationTest/donotrents/excel(fileName='{fileName}')")]
//        public async Task<FileStreamResult> ExportDoNotRentsToExcel(string fileName = null)
//        {
//            return ToExcel(ApplyQuery(await service.GetDoNotRents(), Request.Query, false), fileName);
//        }

//        [HttpGet("/export/destinationTest/doorcodelogs/csv")]
//        [HttpGet("/export/destinationTest/doorcodelogs/csv(fileName='{fileName}')")]
//        public async Task<FileStreamResult> ExportDoorCodeLogsToCSV(string fileName = null)
//        {
//            return ToCSV(ApplyQuery(await service.GetDoorCodeLogs(), Request.Query, false), fileName);
//        }

//        [HttpGet("/export/destinationTest/doorcodelogs/excel")]
//        [HttpGet("/export/destinationTest/doorcodelogs/excel(fileName='{fileName}')")]
//        public async Task<FileStreamResult> ExportDoorCodeLogsToExcel(string fileName = null)
//        {
//            return ToExcel(ApplyQuery(await service.GetDoorCodeLogs(), Request.Query, false), fileName);
//        }

//        [HttpGet("/export/destinationTest/emailremovelists/csv")]
//        [HttpGet("/export/destinationTest/emailremovelists/csv(fileName='{fileName}')")]
//        public async Task<FileStreamResult> ExportEmailRemoveListsToCSV(string fileName = null)
//        {
//            return ToCSV(ApplyQuery(await service.GetEmailRemoveLists(), Request.Query, false), fileName);
//        }

//        [HttpGet("/export/destinationTest/emailremovelists/excel")]
//        [HttpGet("/export/destinationTest/emailremovelists/excel(fileName='{fileName}')")]
//        public async Task<FileStreamResult> ExportEmailRemoveListsToExcel(string fileName = null)
//        {
//            return ToExcel(ApplyQuery(await service.GetEmailRemoveLists(), Request.Query, false), fileName);
//        }

//        [HttpGet("/export/destinationTest/emailremovelist1s/csv")]
//        [HttpGet("/export/destinationTest/emailremovelist1s/csv(fileName='{fileName}')")]
//        public async Task<FileStreamResult> ExportEmailRemoveList1SToCSV(string fileName = null)
//        {
//            return ToCSV(ApplyQuery(await service.GetEmailRemoveList1S(), Request.Query, false), fileName);
//        }

//        [HttpGet("/export/destinationTest/emailremovelist1s/excel")]
//        [HttpGet("/export/destinationTest/emailremovelist1s/excel(fileName='{fileName}')")]
//        public async Task<FileStreamResult> ExportEmailRemoveList1SToExcel(string fileName = null)
//        {
//            return ToExcel(ApplyQuery(await service.GetEmailRemoveList1S(), Request.Query, false), fileName);
//        }

//        [HttpGet("/export/destinationTest/emails/csv")]
//        [HttpGet("/export/destinationTest/emails/csv(fileName='{fileName}')")]
//        public async Task<FileStreamResult> ExportEmailsToCSV(string fileName = null)
//        {
//            return ToCSV(ApplyQuery(await service.GetEmails(), Request.Query, false), fileName);
//        }

//        [HttpGet("/export/destinationTest/emails/excel")]
//        [HttpGet("/export/destinationTest/emails/excel(fileName='{fileName}')")]
//        public async Task<FileStreamResult> ExportEmailsToExcel(string fileName = null)
//        {
//            return ToExcel(ApplyQuery(await service.GetEmails(), Request.Query, false), fileName);
//        }

//        [HttpGet("/export/destinationTest/eventdates/csv")]
//        [HttpGet("/export/destinationTest/eventdates/csv(fileName='{fileName}')")]
//        public async Task<FileStreamResult> ExportEventDatesToCSV(string fileName = null)
//        {
//            return ToCSV(ApplyQuery(await service.GetEventDates(), Request.Query, false), fileName);
//        }

//        [HttpGet("/export/destinationTest/eventdates/excel")]
//        [HttpGet("/export/destinationTest/eventdates/excel(fileName='{fileName}')")]
//        public async Task<FileStreamResult> ExportEventDatesToExcel(string fileName = null)
//        {
//            return ToExcel(ApplyQuery(await service.GetEventDates(), Request.Query, false), fileName);
//        }

//        [HttpGet("/export/destinationTest/favorites/csv")]
//        [HttpGet("/export/destinationTest/favorites/csv(fileName='{fileName}')")]
//        public async Task<FileStreamResult> ExportFavoritesToCSV(string fileName = null)
//        {
//            return ToCSV(ApplyQuery(await service.GetFavorites(), Request.Query, false), fileName);
//        }

//        [HttpGet("/export/destinationTest/favorites/excel")]
//        [HttpGet("/export/destinationTest/favorites/excel(fileName='{fileName}')")]
//        public async Task<FileStreamResult> ExportFavoritesToExcel(string fileName = null)
//        {
//            return ToExcel(ApplyQuery(await service.GetFavorites(), Request.Query, false), fileName);
//        }

//        [HttpGet("/export/destinationTest/filterdataforbulksmsmails/csv")]
//        [HttpGet("/export/destinationTest/filterdataforbulksmsmails/csv(fileName='{fileName}')")]
//        public async Task<FileStreamResult> ExportFilterDataForBulkSmsMailsToCSV(string fileName = null)
//        {
//            return ToCSV(ApplyQuery(await service.GetFilterDataForBulkSmsMails(), Request.Query, false), fileName);
//        }

//        [HttpGet("/export/destinationTest/filterdataforbulksmsmails/excel")]
//        [HttpGet("/export/destinationTest/filterdataforbulksmsmails/excel(fileName='{fileName}')")]
//        public async Task<FileStreamResult> ExportFilterDataForBulkSmsMailsToExcel(string fileName = null)
//        {
//            return ToExcel(ApplyQuery(await service.GetFilterDataForBulkSmsMails(), Request.Query, false), fileName);
//        }

//        [HttpGet("/export/destinationTest/finaldata/csv")]
//        [HttpGet("/export/destinationTest/finaldata/csv(fileName='{fileName}')")]
//        public async Task<FileStreamResult> ExportFinalDataToCSV(string fileName = null)
//        {
//            return ToCSV(ApplyQuery(await service.GetFinalData(), Request.Query, false), fileName);
//        }

//        [HttpGet("/export/destinationTest/finaldata/excel")]
//        [HttpGet("/export/destinationTest/finaldata/excel(fileName='{fileName}')")]
//        public async Task<FileStreamResult> ExportFinalDataToExcel(string fileName = null)
//        {
//            return ToExcel(ApplyQuery(await service.GetFinalData(), Request.Query, false), fileName);
//        }

//        [HttpGet("/export/destinationTest/forecasts/csv")]
//        [HttpGet("/export/destinationTest/forecasts/csv(fileName='{fileName}')")]
//        public async Task<FileStreamResult> ExportForecastsToCSV(string fileName = null)
//        {
//            return ToCSV(ApplyQuery(await service.GetForecasts(), Request.Query, false), fileName);
//        }

//        [HttpGet("/export/destinationTest/forecasts/excel")]
//        [HttpGet("/export/destinationTest/forecasts/excel(fileName='{fileName}')")]
//        public async Task<FileStreamResult> ExportForecastsToExcel(string fileName = null)
//        {
//            return ToExcel(ApplyQuery(await service.GetForecasts(), Request.Query, false), fileName);
//        }

//        [HttpGet("/export/destinationTest/googleuserskeywords/csv")]
//        [HttpGet("/export/destinationTest/googleuserskeywords/csv(fileName='{fileName}')")]
//        public async Task<FileStreamResult> ExportGoogleUsersKeywordsToCSV(string fileName = null)
//        {
//            return ToCSV(ApplyQuery(await service.GetGoogleUsersKeywords(), Request.Query, false), fileName);
//        }

//        [HttpGet("/export/destinationTest/googleuserskeywords/excel")]
//        [HttpGet("/export/destinationTest/googleuserskeywords/excel(fileName='{fileName}')")]
//        public async Task<FileStreamResult> ExportGoogleUsersKeywordsToExcel(string fileName = null)
//        {
//            return ToExcel(ApplyQuery(await service.GetGoogleUsersKeywords(), Request.Query, false), fileName);
//        }

//        [HttpGet("/export/destinationTest/guestcodecalls/csv")]
//        [HttpGet("/export/destinationTest/guestcodecalls/csv(fileName='{fileName}')")]
//        public async Task<FileStreamResult> ExportGuestCodeCallsToCSV(string fileName = null)
//        {
//            return ToCSV(ApplyQuery(await service.GetGuestCodeCalls(), Request.Query, false), fileName);
//        }

//        [HttpGet("/export/destinationTest/guestcodecalls/excel")]
//        [HttpGet("/export/destinationTest/guestcodecalls/excel(fileName='{fileName}')")]
//        public async Task<FileStreamResult> ExportGuestCodeCallsToExcel(string fileName = null)
//        {
//            return ToExcel(ApplyQuery(await service.GetGuestCodeCalls(), Request.Query, false), fileName);
//        }

//        [HttpGet("/export/destinationTest/hothomes/csv")]
//        [HttpGet("/export/destinationTest/hothomes/csv(fileName='{fileName}')")]
//        public async Task<FileStreamResult> ExportHotHomesToCSV(string fileName = null)
//        {
//            return ToCSV(ApplyQuery(await service.GetHotHomes(), Request.Query, false), fileName);
//        }

//        [HttpGet("/export/destinationTest/hothomes/excel")]
//        [HttpGet("/export/destinationTest/hothomes/excel(fileName='{fileName}')")]
//        public async Task<FileStreamResult> ExportHotHomesToExcel(string fileName = null)
//        {
//            return ToExcel(ApplyQuery(await service.GetHotHomes(), Request.Query, false), fileName);
//        }

//        [HttpGet("/export/destinationTest/houserules/csv")]
//        [HttpGet("/export/destinationTest/houserules/csv(fileName='{fileName}')")]
//        public async Task<FileStreamResult> ExportHouseRulesToCSV(string fileName = null)
//        {
//            return ToCSV(ApplyQuery(await service.GetHouseRules(), Request.Query, false), fileName);
//        }

//        [HttpGet("/export/destinationTest/houserules/excel")]
//        [HttpGet("/export/destinationTest/houserules/excel(fileName='{fileName}')")]
//        public async Task<FileStreamResult> ExportHouseRulesToExcel(string fileName = null)
//        {
//            return ToExcel(ApplyQuery(await service.GetHouseRules(), Request.Query, false), fileName);
//        }

//        [HttpGet("/export/destinationTest/inntopiacalllogs/csv")]
//        [HttpGet("/export/destinationTest/inntopiacalllogs/csv(fileName='{fileName}')")]
//        public async Task<FileStreamResult> ExportInntopiaCallLogsToCSV(string fileName = null)
//        {
//            return ToCSV(ApplyQuery(await service.GetInntopiaCallLogs(), Request.Query, false), fileName);
//        }

//        [HttpGet("/export/destinationTest/inntopiacalllogs/excel")]
//        [HttpGet("/export/destinationTest/inntopiacalllogs/excel(fileName='{fileName}')")]
//        public async Task<FileStreamResult> ExportInntopiaCallLogsToExcel(string fileName = null)
//        {
//            return ToExcel(ApplyQuery(await service.GetInntopiaCallLogs(), Request.Query, false), fileName);
//        }

//        [HttpGet("/export/destinationTest/inntopiapushtimelogs/csv")]
//        [HttpGet("/export/destinationTest/inntopiapushtimelogs/csv(fileName='{fileName}')")]
//        public async Task<FileStreamResult> ExportInntopiaPushTimeLogsToCSV(string fileName = null)
//        {
//            return ToCSV(ApplyQuery(await service.GetInntopiaPushTimeLogs(), Request.Query, false), fileName);
//        }

//        [HttpGet("/export/destinationTest/inntopiapushtimelogs/excel")]
//        [HttpGet("/export/destinationTest/inntopiapushtimelogs/excel(fileName='{fileName}')")]
//        public async Task<FileStreamResult> ExportInntopiaPushTimeLogsToExcel(string fileName = null)
//        {
//            return ToExcel(ApplyQuery(await service.GetInntopiaPushTimeLogs(), Request.Query, false), fileName);
//        }

//        [HttpGet("/export/destinationTest/inntopiaaudits/csv")]
//        [HttpGet("/export/destinationTest/inntopiaaudits/csv(fileName='{fileName}')")]
//        public async Task<FileStreamResult> ExportInntopiaAuditsToCSV(string fileName = null)
//        {
//            return ToCSV(ApplyQuery(await service.GetInntopiaAudits(), Request.Query, false), fileName);
//        }

//        [HttpGet("/export/destinationTest/inntopiaaudits/excel")]
//        [HttpGet("/export/destinationTest/inntopiaaudits/excel(fileName='{fileName}')")]
//        public async Task<FileStreamResult> ExportInntopiaAuditsToExcel(string fileName = null)
//        {
//            return ToExcel(ApplyQuery(await service.GetInntopiaAudits(), Request.Query, false), fileName);
//        }

//        [HttpGet("/export/destinationTest/inntopiabookings/csv")]
//        [HttpGet("/export/destinationTest/inntopiabookings/csv(fileName='{fileName}')")]
//        public async Task<FileStreamResult> ExportInntopiaBookingsToCSV(string fileName = null)
//        {
//            return ToCSV(ApplyQuery(await service.GetInntopiaBookings(), Request.Query, false), fileName);
//        }

//        [HttpGet("/export/destinationTest/inntopiabookings/excel")]
//        [HttpGet("/export/destinationTest/inntopiabookings/excel(fileName='{fileName}')")]
//        public async Task<FileStreamResult> ExportInntopiaBookingsToExcel(string fileName = null)
//        {
//            return ToExcel(ApplyQuery(await service.GetInntopiaBookings(), Request.Query, false), fileName);
//        }

//        [HttpGet("/export/destinationTest/inquirynas/csv")]
//        [HttpGet("/export/destinationTest/inquirynas/csv(fileName='{fileName}')")]
//        public async Task<FileStreamResult> ExportInquiryNasToCSV(string fileName = null)
//        {
//            return ToCSV(ApplyQuery(await service.GetInquiryNas(), Request.Query, false), fileName);
//        }

//        [HttpGet("/export/destinationTest/inquirynas/excel")]
//        [HttpGet("/export/destinationTest/inquirynas/excel(fileName='{fileName}')")]
//        public async Task<FileStreamResult> ExportInquiryNasToExcel(string fileName = null)
//        {
//            return ToExcel(ApplyQuery(await service.GetInquiryNas(), Request.Query, false), fileName);
//        }

//        [HttpGet("/export/destinationTest/inspectionplans/csv")]
//        [HttpGet("/export/destinationTest/inspectionplans/csv(fileName='{fileName}')")]
//        public async Task<FileStreamResult> ExportInspectionPlansToCSV(string fileName = null)
//        {
//            return ToCSV(ApplyQuery(await service.GetInspectionPlans(), Request.Query, false), fileName);
//        }

//        [HttpGet("/export/destinationTest/inspectionplans/excel")]
//        [HttpGet("/export/destinationTest/inspectionplans/excel(fileName='{fileName}')")]
//        public async Task<FileStreamResult> ExportInspectionPlansToExcel(string fileName = null)
//        {
//            return ToExcel(ApplyQuery(await service.GetInspectionPlans(), Request.Query, false), fileName);
//        }

//        [HttpGet("/export/destinationTest/instructions/csv")]
//        [HttpGet("/export/destinationTest/instructions/csv(fileName='{fileName}')")]
//        public async Task<FileStreamResult> ExportInstructionsToCSV(string fileName = null)
//        {
//            return ToCSV(ApplyQuery(await service.GetInstructions(), Request.Query, false), fileName);
//        }

//        [HttpGet("/export/destinationTest/instructions/excel")]
//        [HttpGet("/export/destinationTest/instructions/excel(fileName='{fileName}')")]
//        public async Task<FileStreamResult> ExportInstructionsToExcel(string fileName = null)
//        {
//            return ToExcel(ApplyQuery(await service.GetInstructions(), Request.Query, false), fileName);
//        }

//        [HttpGet("/export/destinationTest/instructionagents/csv")]
//        [HttpGet("/export/destinationTest/instructionagents/csv(fileName='{fileName}')")]
//        public async Task<FileStreamResult> ExportInstructionAgentsToCSV(string fileName = null)
//        {
//            return ToCSV(ApplyQuery(await service.GetInstructionAgents(), Request.Query, false), fileName);
//        }

//        [HttpGet("/export/destinationTest/instructionagents/excel")]
//        [HttpGet("/export/destinationTest/instructionagents/excel(fileName='{fileName}')")]
//        public async Task<FileStreamResult> ExportInstructionAgentsToExcel(string fileName = null)
//        {
//            return ToExcel(ApplyQuery(await service.GetInstructionAgents(), Request.Query, false), fileName);
//        }

//        [HttpGet("/export/destinationTest/landingpages/csv")]
//        [HttpGet("/export/destinationTest/landingpages/csv(fileName='{fileName}')")]
//        public async Task<FileStreamResult> ExportLandingPagesToCSV(string fileName = null)
//        {
//            return ToCSV(ApplyQuery(await service.GetLandingPages(), Request.Query, false), fileName);
//        }

//        [HttpGet("/export/destinationTest/landingpages/excel")]
//        [HttpGet("/export/destinationTest/landingpages/excel(fileName='{fileName}')")]
//        public async Task<FileStreamResult> ExportLandingPagesToExcel(string fileName = null)
//        {
//            return ToExcel(ApplyQuery(await service.GetLandingPages(), Request.Query, false), fileName);
//        }

//        [HttpGet("/export/destinationTest/largegroupbookings/csv")]
//        [HttpGet("/export/destinationTest/largegroupbookings/csv(fileName='{fileName}')")]
//        public async Task<FileStreamResult> ExportLargeGroupBookingsToCSV(string fileName = null)
//        {
//            return ToCSV(ApplyQuery(await service.GetLargeGroupBookings(), Request.Query, false), fileName);
//        }

//        [HttpGet("/export/destinationTest/largegroupbookings/excel")]
//        [HttpGet("/export/destinationTest/largegroupbookings/excel(fileName='{fileName}')")]
//        public async Task<FileStreamResult> ExportLargeGroupBookingsToExcel(string fileName = null)
//        {
//            return ToExcel(ApplyQuery(await service.GetLargeGroupBookings(), Request.Query, false), fileName);
//        }

//        [HttpGet("/export/destinationTest/laundryrates/csv")]
//        [HttpGet("/export/destinationTest/laundryrates/csv(fileName='{fileName}')")]
//        public async Task<FileStreamResult> ExportLaundryRatesToCSV(string fileName = null)
//        {
//            return ToCSV(ApplyQuery(await service.GetLaundryRates(), Request.Query, false), fileName);
//        }

//        [HttpGet("/export/destinationTest/laundryrates/excel")]
//        [HttpGet("/export/destinationTest/laundryrates/excel(fileName='{fileName}')")]
//        public async Task<FileStreamResult> ExportLaundryRatesToExcel(string fileName = null)
//        {
//            return ToExcel(ApplyQuery(await service.GetLaundryRates(), Request.Query, false), fileName);
//        }

//        [HttpGet("/export/destinationTest/logeditpropertydescriptions/csv")]
//        [HttpGet("/export/destinationTest/logeditpropertydescriptions/csv(fileName='{fileName}')")]
//        public async Task<FileStreamResult> ExportLogEditPropertyDescriptionsToCSV(string fileName = null)
//        {
//            return ToCSV(ApplyQuery(await service.GetLogEditPropertyDescriptions(), Request.Query, false), fileName);
//        }

//        [HttpGet("/export/destinationTest/logeditpropertydescriptions/excel")]
//        [HttpGet("/export/destinationTest/logeditpropertydescriptions/excel(fileName='{fileName}')")]
//        public async Task<FileStreamResult> ExportLogEditPropertyDescriptionsToExcel(string fileName = null)
//        {
//            return ToExcel(ApplyQuery(await service.GetLogEditPropertyDescriptions(), Request.Query, false), fileName);
//        }

//        [HttpGet("/export/destinationTest/logdoorcodes2020s/csv")]
//        [HttpGet("/export/destinationTest/logdoorcodes2020s/csv(fileName='{fileName}')")]
//        public async Task<FileStreamResult> ExportLogDoorCodes2020SToCSV(string fileName = null)
//        {
//            return ToCSV(ApplyQuery(await service.GetLogDoorCodes2020S(), Request.Query, false), fileName);
//        }

//        [HttpGet("/export/destinationTest/logdoorcodes2020s/excel")]
//        [HttpGet("/export/destinationTest/logdoorcodes2020s/excel(fileName='{fileName}')")]
//        public async Task<FileStreamResult> ExportLogDoorCodes2020SToExcel(string fileName = null)
//        {
//            return ToExcel(ApplyQuery(await service.GetLogDoorCodes2020S(), Request.Query, false), fileName);
//        }

//        [HttpGet("/export/destinationTest/maintenanceactions/csv")]
//        [HttpGet("/export/destinationTest/maintenanceactions/csv(fileName='{fileName}')")]
//        public async Task<FileStreamResult> ExportMaintenanceActionsToCSV(string fileName = null)
//        {
//            return ToCSV(ApplyQuery(await service.GetMaintenanceActions(), Request.Query, false), fileName);
//        }

//        [HttpGet("/export/destinationTest/maintenanceactions/excel")]
//        [HttpGet("/export/destinationTest/maintenanceactions/excel(fileName='{fileName}')")]
//        public async Task<FileStreamResult> ExportMaintenanceActionsToExcel(string fileName = null)
//        {
//            return ToExcel(ApplyQuery(await service.GetMaintenanceActions(), Request.Query, false), fileName);
//        }

//        [HttpGet("/export/destinationTest/marketingreviews/csv")]
//        [HttpGet("/export/destinationTest/marketingreviews/csv(fileName='{fileName}')")]
//        public async Task<FileStreamResult> ExportMarketingReviewsToCSV(string fileName = null)
//        {
//            return ToCSV(ApplyQuery(await service.GetMarketingReviews(), Request.Query, false), fileName);
//        }

//        [HttpGet("/export/destinationTest/marketingreviews/excel")]
//        [HttpGet("/export/destinationTest/marketingreviews/excel(fileName='{fileName}')")]
//        public async Task<FileStreamResult> ExportMarketingReviewsToExcel(string fileName = null)
//        {
//            return ToExcel(ApplyQuery(await service.GetMarketingReviews(), Request.Query, false), fileName);
//        }

//        [HttpGet("/export/destinationTest/media/csv")]
//        [HttpGet("/export/destinationTest/media/csv(fileName='{fileName}')")]
//        public async Task<FileStreamResult> ExportMediaToCSV(string fileName = null)
//        {
//            return ToCSV(ApplyQuery(await service.GetMedia(), Request.Query, false), fileName);
//        }

//        [HttpGet("/export/destinationTest/media/excel")]
//        [HttpGet("/export/destinationTest/media/excel(fileName='{fileName}')")]
//        public async Task<FileStreamResult> ExportMediaToExcel(string fileName = null)
//        {
//            return ToExcel(ApplyQuery(await service.GetMedia(), Request.Query, false), fileName);
//        }

//        [HttpGet("/export/destinationTest/menumanagements/csv")]
//        [HttpGet("/export/destinationTest/menumanagements/csv(fileName='{fileName}')")]
//        public async Task<FileStreamResult> ExportMenuManagementsToCSV(string fileName = null)
//        {
//            return ToCSV(ApplyQuery(await service.GetMenuManagements(), Request.Query, false), fileName);
//        }

//        [HttpGet("/export/destinationTest/menumanagements/excel")]
//        [HttpGet("/export/destinationTest/menumanagements/excel(fileName='{fileName}')")]
//        public async Task<FileStreamResult> ExportMenuManagementsToExcel(string fileName = null)
//        {
//            return ToExcel(ApplyQuery(await service.GetMenuManagements(), Request.Query, false), fileName);
//        }

//        [HttpGet("/export/destinationTest/menumasters/csv")]
//        [HttpGet("/export/destinationTest/menumasters/csv(fileName='{fileName}')")]
//        public async Task<FileStreamResult> ExportMenuMastersToCSV(string fileName = null)
//        {
//            return ToCSV(ApplyQuery(await service.GetMenuMasters(), Request.Query, false), fileName);
//        }

//        [HttpGet("/export/destinationTest/menumasters/excel")]
//        [HttpGet("/export/destinationTest/menumasters/excel(fileName='{fileName}')")]
//        public async Task<FileStreamResult> ExportMenuMastersToExcel(string fileName = null)
//        {
//            return ToExcel(ApplyQuery(await service.GetMenuMasters(), Request.Query, false), fileName);
//        }

//        [HttpGet("/export/destinationTest/morecontents/csv")]
//        [HttpGet("/export/destinationTest/morecontents/csv(fileName='{fileName}')")]
//        public async Task<FileStreamResult> ExportMoreContentsToCSV(string fileName = null)
//        {
//            return ToCSV(ApplyQuery(await service.GetMoreContents(), Request.Query, false), fileName);
//        }

//        [HttpGet("/export/destinationTest/morecontents/excel")]
//        [HttpGet("/export/destinationTest/morecontents/excel(fileName='{fileName}')")]
//        public async Task<FileStreamResult> ExportMoreContentsToExcel(string fileName = null)
//        {
//            return ToExcel(ApplyQuery(await service.GetMoreContents(), Request.Query, false), fileName);
//        }

//        [HttpGet("/export/destinationTest/neighborhoods/csv")]
//        [HttpGet("/export/destinationTest/neighborhoods/csv(fileName='{fileName}')")]
//        public async Task<FileStreamResult> ExportNeighborhoodsToCSV(string fileName = null)
//        {
//            return ToCSV(ApplyQuery(await service.GetNeighborhoods(), Request.Query, false), fileName);
//        }

//        [HttpGet("/export/destinationTest/neighborhoods/excel")]
//        [HttpGet("/export/destinationTest/neighborhoods/excel(fileName='{fileName}')")]
//        public async Task<FileStreamResult> ExportNeighborhoodsToExcel(string fileName = null)
//        {
//            return ToExcel(ApplyQuery(await service.GetNeighborhoods(), Request.Query, false), fileName);
//        }

//        [HttpGet("/export/destinationTest/nowords/csv")]
//        [HttpGet("/export/destinationTest/nowords/csv(fileName='{fileName}')")]
//        public async Task<FileStreamResult> ExportNoWordsToCSV(string fileName = null)
//        {
//            return ToCSV(ApplyQuery(await service.GetNoWords(), Request.Query, false), fileName);
//        }

//        [HttpGet("/export/destinationTest/nowords/excel")]
//        [HttpGet("/export/destinationTest/nowords/excel(fileName='{fileName}')")]
//        public async Task<FileStreamResult> ExportNoWordsToExcel(string fileName = null)
//        {
//            return ToExcel(ApplyQuery(await service.GetNoWords(), Request.Query, false), fileName);
//        }

//        [HttpGet("/export/destinationTest/offhourslistforsmsroutines/csv")]
//        [HttpGet("/export/destinationTest/offhourslistforsmsroutines/csv(fileName='{fileName}')")]
//        public async Task<FileStreamResult> ExportOffhoursListForSmsroutinesToCSV(string fileName = null)
//        {
//            return ToCSV(ApplyQuery(await service.GetOffhoursListForSmsroutines(), Request.Query, false), fileName);
//        }

//        [HttpGet("/export/destinationTest/offhourslistforsmsroutines/excel")]
//        [HttpGet("/export/destinationTest/offhourslistforsmsroutines/excel(fileName='{fileName}')")]
//        public async Task<FileStreamResult> ExportOffhoursListForSmsroutinesToExcel(string fileName = null)
//        {
//            return ToExcel(ApplyQuery(await service.GetOffhoursListForSmsroutines(), Request.Query, false), fileName);
//        }

//        [HttpGet("/export/destinationTest/olarkzapiers/csv")]
//        [HttpGet("/export/destinationTest/olarkzapiers/csv(fileName='{fileName}')")]
//        public async Task<FileStreamResult> ExportOlarkZapiersToCSV(string fileName = null)
//        {
//            return ToCSV(ApplyQuery(await service.GetOlarkZapiers(), Request.Query, false), fileName);
//        }

//        [HttpGet("/export/destinationTest/olarkzapiers/excel")]
//        [HttpGet("/export/destinationTest/olarkzapiers/excel(fileName='{fileName}')")]
//        public async Task<FileStreamResult> ExportOlarkZapiersToExcel(string fileName = null)
//        {
//            return ToExcel(ApplyQuery(await service.GetOlarkZapiers(), Request.Query, false), fileName);
//        }

//        [HttpGet("/export/destinationTest/olarkzapiernews/csv")]
//        [HttpGet("/export/destinationTest/olarkzapiernews/csv(fileName='{fileName}')")]
//        public async Task<FileStreamResult> ExportOlarkZapierNewsToCSV(string fileName = null)
//        {
//            return ToCSV(ApplyQuery(await service.GetOlarkZapierNews(), Request.Query, false), fileName);
//        }

//        [HttpGet("/export/destinationTest/olarkzapiernews/excel")]
//        [HttpGet("/export/destinationTest/olarkzapiernews/excel(fileName='{fileName}')")]
//        public async Task<FileStreamResult> ExportOlarkZapierNewsToExcel(string fileName = null)
//        {
//            return ToExcel(ApplyQuery(await service.GetOlarkZapierNews(), Request.Query, false), fileName);
//        }

//        [HttpGet("/export/destinationTest/opinionstagesurveyleadsrepors/csv")]
//        [HttpGet("/export/destinationTest/opinionstagesurveyleadsrepors/csv(fileName='{fileName}')")]
//        public async Task<FileStreamResult> ExportOpinionStageSurveyLeadsReporsToCSV(string fileName = null)
//        {
//            return ToCSV(ApplyQuery(await service.GetOpinionStageSurveyLeadsRepors(), Request.Query, false), fileName);
//        }

//        [HttpGet("/export/destinationTest/opinionstagesurveyleadsrepors/excel")]
//        [HttpGet("/export/destinationTest/opinionstagesurveyleadsrepors/excel(fileName='{fileName}')")]
//        public async Task<FileStreamResult> ExportOpinionStageSurveyLeadsReporsToExcel(string fileName = null)
//        {
//            return ToExcel(ApplyQuery(await service.GetOpinionStageSurveyLeadsRepors(), Request.Query, false), fileName);
//        }

//        [HttpGet("/export/destinationTest/ownercommunications/csv")]
//        [HttpGet("/export/destinationTest/ownercommunications/csv(fileName='{fileName}')")]
//        public async Task<FileStreamResult> ExportOwnerCommunicationsToCSV(string fileName = null)
//        {
//            return ToCSV(ApplyQuery(await service.GetOwnerCommunications(), Request.Query, false), fileName);
//        }

//        [HttpGet("/export/destinationTest/ownercommunications/excel")]
//        [HttpGet("/export/destinationTest/ownercommunications/excel(fileName='{fileName}')")]
//        public async Task<FileStreamResult> ExportOwnerCommunicationsToExcel(string fileName = null)
//        {
//            return ToExcel(ApplyQuery(await service.GetOwnerCommunications(), Request.Query, false), fileName);
//        }

//        [HttpGet("/export/destinationTest/ownerupdates/csv")]
//        [HttpGet("/export/destinationTest/ownerupdates/csv(fileName='{fileName}')")]
//        public async Task<FileStreamResult> ExportOwnerUpdatesToCSV(string fileName = null)
//        {
//            return ToCSV(ApplyQuery(await service.GetOwnerUpdates(), Request.Query, false), fileName);
//        }

//        [HttpGet("/export/destinationTest/ownerupdates/excel")]
//        [HttpGet("/export/destinationTest/ownerupdates/excel(fileName='{fileName}')")]
//        public async Task<FileStreamResult> ExportOwnerUpdatesToExcel(string fileName = null)
//        {
//            return ToExcel(ApplyQuery(await service.GetOwnerUpdates(), Request.Query, false), fileName);
//        }

//        [HttpGet("/export/destinationTest/pageemailrecipients/csv")]
//        [HttpGet("/export/destinationTest/pageemailrecipients/csv(fileName='{fileName}')")]
//        public async Task<FileStreamResult> ExportPageEmailRecipientsToCSV(string fileName = null)
//        {
//            return ToCSV(ApplyQuery(await service.GetPageEmailRecipients(), Request.Query, false), fileName);
//        }

//        [HttpGet("/export/destinationTest/pageemailrecipients/excel")]
//        [HttpGet("/export/destinationTest/pageemailrecipients/excel(fileName='{fileName}')")]
//        public async Task<FileStreamResult> ExportPageEmailRecipientsToExcel(string fileName = null)
//        {
//            return ToExcel(ApplyQuery(await service.GetPageEmailRecipients(), Request.Query, false), fileName);
//        }

//        [HttpGet("/export/destinationTest/payments/csv")]
//        [HttpGet("/export/destinationTest/payments/csv(fileName='{fileName}')")]
//        public async Task<FileStreamResult> ExportPaymentsToCSV(string fileName = null)
//        {
//            return ToCSV(ApplyQuery(await service.GetPayments(), Request.Query, false), fileName);
//        }

//        [HttpGet("/export/destinationTest/payments/excel")]
//        [HttpGet("/export/destinationTest/payments/excel(fileName='{fileName}')")]
//        public async Task<FileStreamResult> ExportPaymentsToExcel(string fileName = null)
//        {
//            return ToExcel(ApplyQuery(await service.GetPayments(), Request.Query, false), fileName);
//        }

//        [HttpGet("/export/destinationTest/paymentlogdoublerefundeds/csv")]
//        [HttpGet("/export/destinationTest/paymentlogdoublerefundeds/csv(fileName='{fileName}')")]
//        public async Task<FileStreamResult> ExportPaymentLogDoubleRefundedsToCSV(string fileName = null)
//        {
//            return ToCSV(ApplyQuery(await service.GetPaymentLogDoubleRefundeds(), Request.Query, false), fileName);
//        }

//        [HttpGet("/export/destinationTest/paymentlogdoublerefundeds/excel")]
//        [HttpGet("/export/destinationTest/paymentlogdoublerefundeds/excel(fileName='{fileName}')")]
//        public async Task<FileStreamResult> ExportPaymentLogDoubleRefundedsToExcel(string fileName = null)
//        {
//            return ToExcel(ApplyQuery(await service.GetPaymentLogDoubleRefundeds(), Request.Query, false), fileName);
//        }

//        [HttpGet("/export/destinationTest/performas/csv")]
//        [HttpGet("/export/destinationTest/performas/csv(fileName='{fileName}')")]
//        public async Task<FileStreamResult> ExportPerformasToCSV(string fileName = null)
//        {
//            return ToCSV(ApplyQuery(await service.GetPerformas(), Request.Query, false), fileName);
//        }

//        [HttpGet("/export/destinationTest/performas/excel")]
//        [HttpGet("/export/destinationTest/performas/excel(fileName='{fileName}')")]
//        public async Task<FileStreamResult> ExportPerformasToExcel(string fileName = null)
//        {
//            return ToExcel(ApplyQuery(await service.GetPerformas(), Request.Query, false), fileName);
//        }

//        [HttpGet("/export/destinationTest/performacomps/csv")]
//        [HttpGet("/export/destinationTest/performacomps/csv(fileName='{fileName}')")]
//        public async Task<FileStreamResult> ExportPerformaCompsToCSV(string fileName = null)
//        {
//            return ToCSV(ApplyQuery(await service.GetPerformaComps(), Request.Query, false), fileName);
//        }

//        [HttpGet("/export/destinationTest/performacomps/excel")]
//        [HttpGet("/export/destinationTest/performacomps/excel(fileName='{fileName}')")]
//        public async Task<FileStreamResult> ExportPerformaCompsToExcel(string fileName = null)
//        {
//            return ToExcel(ApplyQuery(await service.GetPerformaComps(), Request.Query, false), fileName);
//        }

//        [HttpGet("/export/destinationTest/permits/csv")]
//        [HttpGet("/export/destinationTest/permits/csv(fileName='{fileName}')")]
//        public async Task<FileStreamResult> ExportPermitsToCSV(string fileName = null)
//        {
//            return ToCSV(ApplyQuery(await service.GetPermits(), Request.Query, false), fileName);
//        }

//        [HttpGet("/export/destinationTest/permits/excel")]
//        [HttpGet("/export/destinationTest/permits/excel(fileName='{fileName}')")]
//        public async Task<FileStreamResult> ExportPermitsToExcel(string fileName = null)
//        {
//            return ToExcel(ApplyQuery(await service.GetPermits(), Request.Query, false), fileName);
//        }

//        [HttpGet("/export/destinationTest/phonecalllogs/csv")]
//        [HttpGet("/export/destinationTest/phonecalllogs/csv(fileName='{fileName}')")]
//        public async Task<FileStreamResult> ExportPhoneCallLogsToCSV(string fileName = null)
//        {
//            return ToCSV(ApplyQuery(await service.GetPhoneCallLogs(), Request.Query, false), fileName);
//        }

//        [HttpGet("/export/destinationTest/phonecalllogs/excel")]
//        [HttpGet("/export/destinationTest/phonecalllogs/excel(fileName='{fileName}')")]
//        public async Task<FileStreamResult> ExportPhoneCallLogsToExcel(string fileName = null)
//        {
//            return ToExcel(ApplyQuery(await service.GetPhoneCallLogs(), Request.Query, false), fileName);
//        }

//        [HttpGet("/export/destinationTest/pinksheetnotes/csv")]
//        [HttpGet("/export/destinationTest/pinksheetnotes/csv(fileName='{fileName}')")]
//        public async Task<FileStreamResult> ExportPinkSheetNotesToCSV(string fileName = null)
//        {
//            return ToCSV(ApplyQuery(await service.GetPinkSheetNotes(), Request.Query, false), fileName);
//        }

//        [HttpGet("/export/destinationTest/pinksheetnotes/excel")]
//        [HttpGet("/export/destinationTest/pinksheetnotes/excel(fileName='{fileName}')")]
//        public async Task<FileStreamResult> ExportPinkSheetNotesToExcel(string fileName = null)
//        {
//            return ToExcel(ApplyQuery(await service.GetPinkSheetNotes(), Request.Query, false), fileName);
//        }

//        [HttpGet("/export/destinationTest/procgetlastbookingdetails/csv")]
//        [HttpGet("/export/destinationTest/procgetlastbookingdetails/csv(fileName='{fileName}')")]
//        public async Task<FileStreamResult> ExportProcGetLastBookingDetailsToCSV(string fileName = null)
//        {
//            return ToCSV(ApplyQuery(await service.GetProcGetLastBookingDetails(), Request.Query, true), fileName);
//        }

//        [HttpGet("/export/destinationTest/procgetlastbookingdetails/excel")]
//        [HttpGet("/export/destinationTest/procgetlastbookingdetails/excel(fileName='{fileName}')")]
//        public async Task<FileStreamResult> ExportProcGetLastBookingDetailsToExcel(string fileName = null)
//        {
//            return ToExcel(ApplyQuery(await service.GetProcGetLastBookingDetails(), Request.Query, true), fileName);
//        }

//        [HttpGet("/export/destinationTest/promocodes/csv")]
//        [HttpGet("/export/destinationTest/promocodes/csv(fileName='{fileName}')")]
//        public async Task<FileStreamResult> ExportPromoCodesToCSV(string fileName = null)
//        {
//            return ToCSV(ApplyQuery(await service.GetPromoCodes(), Request.Query, false), fileName);
//        }

//        [HttpGet("/export/destinationTest/promocodes/excel")]
//        [HttpGet("/export/destinationTest/promocodes/excel(fileName='{fileName}')")]
//        public async Task<FileStreamResult> ExportPromoCodesToExcel(string fileName = null)
//        {
//            return ToExcel(ApplyQuery(await service.GetPromoCodes(), Request.Query, false), fileName);
//        }

//        [HttpGet("/export/destinationTest/promotions/csv")]
//        [HttpGet("/export/destinationTest/promotions/csv(fileName='{fileName}')")]
//        public async Task<FileStreamResult> ExportPromotionsToCSV(string fileName = null)
//        {
//            return ToCSV(ApplyQuery(await service.GetPromotions(), Request.Query, false), fileName);
//        }

//        [HttpGet("/export/destinationTest/promotions/excel")]
//        [HttpGet("/export/destinationTest/promotions/excel(fileName='{fileName}')")]
//        public async Task<FileStreamResult> ExportPromotionsToExcel(string fileName = null)
//        {
//            return ToExcel(ApplyQuery(await service.GetPromotions(), Request.Query, false), fileName);
//        }

//        [HttpGet("/export/destinationTest/properties/csv")]
//        [HttpGet("/export/destinationTest/properties/csv(fileName='{fileName}')")]
//        public async Task<FileStreamResult> ExportPropertiesToCSV(string fileName = null)
//        {
//            return ToCSV(ApplyQuery(await service.GetProperties(), Request.Query, false), fileName);
//        }

//        [HttpGet("/export/destinationTest/properties/excel")]
//        [HttpGet("/export/destinationTest/properties/excel(fileName='{fileName}')")]
//        public async Task<FileStreamResult> ExportPropertiesToExcel(string fileName = null)
//        {
//            return ToExcel(ApplyQuery(await service.GetProperties(), Request.Query, false), fileName);
//        }

//        [HttpGet("/export/destinationTest/propertyactivationdates/csv")]
//        [HttpGet("/export/destinationTest/propertyactivationdates/csv(fileName='{fileName}')")]
//        public async Task<FileStreamResult> ExportPropertyActivationDatesToCSV(string fileName = null)
//        {
//            return ToCSV(ApplyQuery(await service.GetPropertyActivationDates(), Request.Query, false), fileName);
//        }

//        [HttpGet("/export/destinationTest/propertyactivationdates/excel")]
//        [HttpGet("/export/destinationTest/propertyactivationdates/excel(fileName='{fileName}')")]
//        public async Task<FileStreamResult> ExportPropertyActivationDatesToExcel(string fileName = null)
//        {
//            return ToExcel(ApplyQuery(await service.GetPropertyActivationDates(), Request.Query, false), fileName);
//        }

//        [HttpGet("/export/destinationTest/propertybeds/csv")]
//        [HttpGet("/export/destinationTest/propertybeds/csv(fileName='{fileName}')")]
//        public async Task<FileStreamResult> ExportPropertyBedsToCSV(string fileName = null)
//        {
//            return ToCSV(ApplyQuery(await service.GetPropertyBeds(), Request.Query, false), fileName);
//        }

//        [HttpGet("/export/destinationTest/propertybeds/excel")]
//        [HttpGet("/export/destinationTest/propertybeds/excel(fileName='{fileName}')")]
//        public async Task<FileStreamResult> ExportPropertyBedsToExcel(string fileName = null)
//        {
//            return ToExcel(ApplyQuery(await service.GetPropertyBeds(), Request.Query, false), fileName);
//        }

//        [HttpGet("/export/destinationTest/propertycleaners/csv")]
//        [HttpGet("/export/destinationTest/propertycleaners/csv(fileName='{fileName}')")]
//        public async Task<FileStreamResult> ExportPropertyCleanersToCSV(string fileName = null)
//        {
//            return ToCSV(ApplyQuery(await service.GetPropertyCleaners(), Request.Query, false), fileName);
//        }

//        [HttpGet("/export/destinationTest/propertycleaners/excel")]
//        [HttpGet("/export/destinationTest/propertycleaners/excel(fileName='{fileName}')")]
//        public async Task<FileStreamResult> ExportPropertyCleanersToExcel(string fileName = null)
//        {
//            return ToExcel(ApplyQuery(await service.GetPropertyCleaners(), Request.Query, false), fileName);
//        }

//        [HttpGet("/export/destinationTest/propertyconducts/csv")]
//        [HttpGet("/export/destinationTest/propertyconducts/csv(fileName='{fileName}')")]
//        public async Task<FileStreamResult> ExportPropertyConductsToCSV(string fileName = null)
//        {
//            return ToCSV(ApplyQuery(await service.GetPropertyConducts(), Request.Query, false), fileName);
//        }

//        [HttpGet("/export/destinationTest/propertyconducts/excel")]
//        [HttpGet("/export/destinationTest/propertyconducts/excel(fileName='{fileName}')")]
//        public async Task<FileStreamResult> ExportPropertyConductsToExcel(string fileName = null)
//        {
//            return ToExcel(ApplyQuery(await service.GetPropertyConducts(), Request.Query, false), fileName);
//        }

//        [HttpGet("/export/destinationTest/propertycontents/csv")]
//        [HttpGet("/export/destinationTest/propertycontents/csv(fileName='{fileName}')")]
//        public async Task<FileStreamResult> ExportPropertyContentsToCSV(string fileName = null)
//        {
//            return ToCSV(ApplyQuery(await service.GetPropertyContents(), Request.Query, false), fileName);
//        }

//        [HttpGet("/export/destinationTest/propertycontents/excel")]
//        [HttpGet("/export/destinationTest/propertycontents/excel(fileName='{fileName}')")]
//        public async Task<FileStreamResult> ExportPropertyContentsToExcel(string fileName = null)
//        {
//            return ToExcel(ApplyQuery(await service.GetPropertyContents(), Request.Query, false), fileName);
//        }

//        [HttpGet("/export/destinationTest/propertyexpenseblankrecords/csv")]
//        [HttpGet("/export/destinationTest/propertyexpenseblankrecords/csv(fileName='{fileName}')")]
//        public async Task<FileStreamResult> ExportPropertyExpenseBlankRecordsToCSV(string fileName = null)
//        {
//            return ToCSV(ApplyQuery(await service.GetPropertyExpenseBlankRecords(), Request.Query, false), fileName);
//        }

//        [HttpGet("/export/destinationTest/propertyexpenseblankrecords/excel")]
//        [HttpGet("/export/destinationTest/propertyexpenseblankrecords/excel(fileName='{fileName}')")]
//        public async Task<FileStreamResult> ExportPropertyExpenseBlankRecordsToExcel(string fileName = null)
//        {
//            return ToExcel(ApplyQuery(await service.GetPropertyExpenseBlankRecords(), Request.Query, false), fileName);
//        }

//        [HttpGet("/export/destinationTest/propertyexpenses/csv")]
//        [HttpGet("/export/destinationTest/propertyexpenses/csv(fileName='{fileName}')")]
//        public async Task<FileStreamResult> ExportPropertyExpensesToCSV(string fileName = null)
//        {
//            return ToCSV(ApplyQuery(await service.GetPropertyExpenses(), Request.Query, false), fileName);
//        }

//        [HttpGet("/export/destinationTest/propertyexpenses/excel")]
//        [HttpGet("/export/destinationTest/propertyexpenses/excel(fileName='{fileName}')")]
//        public async Task<FileStreamResult> ExportPropertyExpensesToExcel(string fileName = null)
//        {
//            return ToExcel(ApplyQuery(await service.GetPropertyExpenses(), Request.Query, false), fileName);
//        }

//        [HttpGet("/export/destinationTest/propertyexpensesdeleteds/csv")]
//        [HttpGet("/export/destinationTest/propertyexpensesdeleteds/csv(fileName='{fileName}')")]
//        public async Task<FileStreamResult> ExportPropertyExpensesDeletedsToCSV(string fileName = null)
//        {
//            return ToCSV(ApplyQuery(await service.GetPropertyExpensesDeleteds(), Request.Query, false), fileName);
//        }

//        [HttpGet("/export/destinationTest/propertyexpensesdeleteds/excel")]
//        [HttpGet("/export/destinationTest/propertyexpensesdeleteds/excel(fileName='{fileName}')")]
//        public async Task<FileStreamResult> ExportPropertyExpensesDeletedsToExcel(string fileName = null)
//        {
//            return ToExcel(ApplyQuery(await service.GetPropertyExpensesDeleteds(), Request.Query, false), fileName);
//        }

//        [HttpGet("/export/destinationTest/propertyimprovements/csv")]
//        [HttpGet("/export/destinationTest/propertyimprovements/csv(fileName='{fileName}')")]
//        public async Task<FileStreamResult> ExportPropertyImprovementsToCSV(string fileName = null)
//        {
//            return ToCSV(ApplyQuery(await service.GetPropertyImprovements(), Request.Query, false), fileName);
//        }

//        [HttpGet("/export/destinationTest/propertyimprovements/excel")]
//        [HttpGet("/export/destinationTest/propertyimprovements/excel(fileName='{fileName}')")]
//        public async Task<FileStreamResult> ExportPropertyImprovementsToExcel(string fileName = null)
//        {
//            return ToExcel(ApplyQuery(await service.GetPropertyImprovements(), Request.Query, false), fileName);
//        }

//        [HttpGet("/export/destinationTest/propertyimprovementtypes/csv")]
//        [HttpGet("/export/destinationTest/propertyimprovementtypes/csv(fileName='{fileName}')")]
//        public async Task<FileStreamResult> ExportPropertyImprovementTypesToCSV(string fileName = null)
//        {
//            return ToCSV(ApplyQuery(await service.GetPropertyImprovementTypes(), Request.Query, false), fileName);
//        }

//        [HttpGet("/export/destinationTest/propertyimprovementtypes/excel")]
//        [HttpGet("/export/destinationTest/propertyimprovementtypes/excel(fileName='{fileName}')")]
//        public async Task<FileStreamResult> ExportPropertyImprovementTypesToExcel(string fileName = null)
//        {
//            return ToExcel(ApplyQuery(await service.GetPropertyImprovementTypes(), Request.Query, false), fileName);
//        }

//        [HttpGet("/export/destinationTest/propertylastnextbookingdetails/csv")]
//        [HttpGet("/export/destinationTest/propertylastnextbookingdetails/csv(fileName='{fileName}')")]
//        public async Task<FileStreamResult> ExportPropertyLastNextBookingDetailsToCSV(string fileName = null)
//        {
//            return ToCSV(ApplyQuery(await service.GetPropertyLastNextBookingDetails(), Request.Query, false), fileName);
//        }

//        [HttpGet("/export/destinationTest/propertylastnextbookingdetails/excel")]
//        [HttpGet("/export/destinationTest/propertylastnextbookingdetails/excel(fileName='{fileName}')")]
//        public async Task<FileStreamResult> ExportPropertyLastNextBookingDetailsToExcel(string fileName = null)
//        {
//            return ToExcel(ApplyQuery(await service.GetPropertyLastNextBookingDetails(), Request.Query, false), fileName);
//        }

//        [HttpGet("/export/destinationTest/propertymgts/csv")]
//        [HttpGet("/export/destinationTest/propertymgts/csv(fileName='{fileName}')")]
//        public async Task<FileStreamResult> ExportPropertyMgtsToCSV(string fileName = null)
//        {
//            return ToCSV(ApplyQuery(await service.GetPropertyMgts(), Request.Query, false), fileName);
//        }

//        [HttpGet("/export/destinationTest/propertymgts/excel")]
//        [HttpGet("/export/destinationTest/propertymgts/excel(fileName='{fileName}')")]
//        public async Task<FileStreamResult> ExportPropertyMgtsToExcel(string fileName = null)
//        {
//            return ToExcel(ApplyQuery(await service.GetPropertyMgts(), Request.Query, false), fileName);
//        }

//        [HttpGet("/export/destinationTest/propertyneighbors/csv")]
//        [HttpGet("/export/destinationTest/propertyneighbors/csv(fileName='{fileName}')")]
//        public async Task<FileStreamResult> ExportPropertyNeighborsToCSV(string fileName = null)
//        {
//            return ToCSV(ApplyQuery(await service.GetPropertyNeighbors(), Request.Query, false), fileName);
//        }

//        [HttpGet("/export/destinationTest/propertyneighbors/excel")]
//        [HttpGet("/export/destinationTest/propertyneighbors/excel(fileName='{fileName}')")]
//        public async Task<FileStreamResult> ExportPropertyNeighborsToExcel(string fileName = null)
//        {
//            return ToExcel(ApplyQuery(await service.GetPropertyNeighbors(), Request.Query, false), fileName);
//        }

//        [HttpGet("/export/destinationTest/propertyownerinstructions/csv")]
//        [HttpGet("/export/destinationTest/propertyownerinstructions/csv(fileName='{fileName}')")]
//        public async Task<FileStreamResult> ExportPropertyOwnerInstructionsToCSV(string fileName = null)
//        {
//            return ToCSV(ApplyQuery(await service.GetPropertyOwnerInstructions(), Request.Query, false), fileName);
//        }

//        [HttpGet("/export/destinationTest/propertyownerinstructions/excel")]
//        [HttpGet("/export/destinationTest/propertyownerinstructions/excel(fileName='{fileName}')")]
//        public async Task<FileStreamResult> ExportPropertyOwnerInstructionsToExcel(string fileName = null)
//        {
//            return ToExcel(ApplyQuery(await service.GetPropertyOwnerInstructions(), Request.Query, false), fileName);
//        }

//        [HttpGet("/export/destinationTest/propertyrates/csv")]
//        [HttpGet("/export/destinationTest/propertyrates/csv(fileName='{fileName}')")]
//        public async Task<FileStreamResult> ExportPropertyRatesToCSV(string fileName = null)
//        {
//            return ToCSV(ApplyQuery(await service.GetPropertyRates(), Request.Query, false), fileName);
//        }

//        [HttpGet("/export/destinationTest/propertyrates/excel")]
//        [HttpGet("/export/destinationTest/propertyrates/excel(fileName='{fileName}')")]
//        public async Task<FileStreamResult> ExportPropertyRatesToExcel(string fileName = null)
//        {
//            return ToExcel(ApplyQuery(await service.GetPropertyRates(), Request.Query, false), fileName);
//        }

//        [HttpGet("/export/destinationTest/propertyratesairbnbs/csv")]
//        [HttpGet("/export/destinationTest/propertyratesairbnbs/csv(fileName='{fileName}')")]
//        public async Task<FileStreamResult> ExportPropertyRatesAirbnbsToCSV(string fileName = null)
//        {
//            return ToCSV(ApplyQuery(await service.GetPropertyRatesAirbnbs(), Request.Query, false), fileName);
//        }

//        [HttpGet("/export/destinationTest/propertyratesairbnbs/excel")]
//        [HttpGet("/export/destinationTest/propertyratesairbnbs/excel(fileName='{fileName}')")]
//        public async Task<FileStreamResult> ExportPropertyRatesAirbnbsToExcel(string fileName = null)
//        {
//            return ToExcel(ApplyQuery(await service.GetPropertyRatesAirbnbs(), Request.Query, false), fileName);
//        }

//        [HttpGet("/export/destinationTest/propertyratesbases/csv")]
//        [HttpGet("/export/destinationTest/propertyratesbases/csv(fileName='{fileName}')")]
//        public async Task<FileStreamResult> ExportPropertyRatesBasesToCSV(string fileName = null)
//        {
//            return ToCSV(ApplyQuery(await service.GetPropertyRatesBases(), Request.Query, false), fileName);
//        }

//        [HttpGet("/export/destinationTest/propertyratesbases/excel")]
//        [HttpGet("/export/destinationTest/propertyratesbases/excel(fileName='{fileName}')")]
//        public async Task<FileStreamResult> ExportPropertyRatesBasesToExcel(string fileName = null)
//        {
//            return ToExcel(ApplyQuery(await service.GetPropertyRatesBases(), Request.Query, false), fileName);
//        }

//        [HttpGet("/export/destinationTest/propertyratesbbs/csv")]
//        [HttpGet("/export/destinationTest/propertyratesbbs/csv(fileName='{fileName}')")]
//        public async Task<FileStreamResult> ExportPropertyRatesBbsToCSV(string fileName = null)
//        {
//            return ToCSV(ApplyQuery(await service.GetPropertyRatesBbs(), Request.Query, false), fileName);
//        }

//        [HttpGet("/export/destinationTest/propertyratesbbs/excel")]
//        [HttpGet("/export/destinationTest/propertyratesbbs/excel(fileName='{fileName}')")]
//        public async Task<FileStreamResult> ExportPropertyRatesBbsToExcel(string fileName = null)
//        {
//            return ToExcel(ApplyQuery(await service.GetPropertyRatesBbs(), Request.Query, false), fileName);
//        }

//        [HttpGet("/export/destinationTest/propertyratestrackings/csv")]
//        [HttpGet("/export/destinationTest/propertyratestrackings/csv(fileName='{fileName}')")]
//        public async Task<FileStreamResult> ExportPropertyRatesTrackingsToCSV(string fileName = null)
//        {
//            return ToCSV(ApplyQuery(await service.GetPropertyRatesTrackings(), Request.Query, false), fileName);
//        }

//        [HttpGet("/export/destinationTest/propertyratestrackings/excel")]
//        [HttpGet("/export/destinationTest/propertyratestrackings/excel(fileName='{fileName}')")]
//        public async Task<FileStreamResult> ExportPropertyRatesTrackingsToExcel(string fileName = null)
//        {
//            return ToExcel(ApplyQuery(await service.GetPropertyRatesTrackings(), Request.Query, false), fileName);
//        }

//        [HttpGet("/export/destinationTest/propertyratesvrbos/csv")]
//        [HttpGet("/export/destinationTest/propertyratesvrbos/csv(fileName='{fileName}')")]
//        public async Task<FileStreamResult> ExportPropertyRatesVrbosToCSV(string fileName = null)
//        {
//            return ToCSV(ApplyQuery(await service.GetPropertyRatesVrbos(), Request.Query, false), fileName);
//        }

//        [HttpGet("/export/destinationTest/propertyratesvrbos/excel")]
//        [HttpGet("/export/destinationTest/propertyratesvrbos/excel(fileName='{fileName}')")]
//        public async Task<FileStreamResult> ExportPropertyRatesVrbosToExcel(string fileName = null)
//        {
//            return ToExcel(ApplyQuery(await service.GetPropertyRatesVrbos(), Request.Query, false), fileName);
//        }

//        [HttpGet("/export/destinationTest/propertysources/csv")]
//        [HttpGet("/export/destinationTest/propertysources/csv(fileName='{fileName}')")]
//        public async Task<FileStreamResult> ExportPropertySourcesToCSV(string fileName = null)
//        {
//            return ToCSV(ApplyQuery(await service.GetPropertySources(), Request.Query, false), fileName);
//        }

//        [HttpGet("/export/destinationTest/propertysources/excel")]
//        [HttpGet("/export/destinationTest/propertysources/excel(fileName='{fileName}')")]
//        public async Task<FileStreamResult> ExportPropertySourcesToExcel(string fileName = null)
//        {
//            return ToExcel(ApplyQuery(await service.GetPropertySources(), Request.Query, false), fileName);
//        }

//        [HttpGet("/export/destinationTest/propertytypes/csv")]
//        [HttpGet("/export/destinationTest/propertytypes/csv(fileName='{fileName}')")]
//        public async Task<FileStreamResult> ExportPropertyTypesToCSV(string fileName = null)
//        {
//            return ToCSV(ApplyQuery(await service.GetPropertyTypes(), Request.Query, false), fileName);
//        }

//        [HttpGet("/export/destinationTest/propertytypes/excel")]
//        [HttpGet("/export/destinationTest/propertytypes/excel(fileName='{fileName}')")]
//        public async Task<FileStreamResult> ExportPropertyTypesToExcel(string fileName = null)
//        {
//            return ToExcel(ApplyQuery(await service.GetPropertyTypes(), Request.Query, false), fileName);
//        }

//        [HttpGet("/export/destinationTest/propertywarnings/csv")]
//        [HttpGet("/export/destinationTest/propertywarnings/csv(fileName='{fileName}')")]
//        public async Task<FileStreamResult> ExportPropertyWarningsToCSV(string fileName = null)
//        {
//            return ToCSV(ApplyQuery(await service.GetPropertyWarnings(), Request.Query, false), fileName);
//        }

//        [HttpGet("/export/destinationTest/propertywarnings/excel")]
//        [HttpGet("/export/destinationTest/propertywarnings/excel(fileName='{fileName}')")]
//        public async Task<FileStreamResult> ExportPropertyWarningsToExcel(string fileName = null)
//        {
//            return ToExcel(ApplyQuery(await service.GetPropertyWarnings(), Request.Query, false), fileName);
//        }

//        [HttpGet("/export/destinationTest/propertyannuallogs/csv")]
//        [HttpGet("/export/destinationTest/propertyannuallogs/csv(fileName='{fileName}')")]
//        public async Task<FileStreamResult> ExportPropertyAnnualLogsToCSV(string fileName = null)
//        {
//            return ToCSV(ApplyQuery(await service.GetPropertyAnnualLogs(), Request.Query, false), fileName);
//        }

//        [HttpGet("/export/destinationTest/propertyannuallogs/excel")]
//        [HttpGet("/export/destinationTest/propertyannuallogs/excel(fileName='{fileName}')")]
//        public async Task<FileStreamResult> ExportPropertyAnnualLogsToExcel(string fileName = null)
//        {
//            return ToExcel(ApplyQuery(await service.GetPropertyAnnualLogs(), Request.Query, false), fileName);
//        }

//        [HttpGet("/export/destinationTest/propertybacktobackbookingsrestricts/csv")]
//        [HttpGet("/export/destinationTest/propertybacktobackbookingsrestricts/csv(fileName='{fileName}')")]
//        public async Task<FileStreamResult> ExportPropertyBackToBackBookingsRestrictsToCSV(string fileName = null)
//        {
//            return ToCSV(ApplyQuery(await service.GetPropertyBackToBackBookingsRestricts(), Request.Query, false), fileName);
//        }

//        [HttpGet("/export/destinationTest/propertybacktobackbookingsrestricts/excel")]
//        [HttpGet("/export/destinationTest/propertybacktobackbookingsrestricts/excel(fileName='{fileName}')")]
//        public async Task<FileStreamResult> ExportPropertyBackToBackBookingsRestrictsToExcel(string fileName = null)
//        {
//            return ToExcel(ApplyQuery(await service.GetPropertyBackToBackBookingsRestricts(), Request.Query, false), fileName);
//        }

//        [HttpGet("/export/destinationTest/propertycontenttypes/csv")]
//        [HttpGet("/export/destinationTest/propertycontenttypes/csv(fileName='{fileName}')")]
//        public async Task<FileStreamResult> ExportPropertycontenttypesToCSV(string fileName = null)
//        {
//            return ToCSV(ApplyQuery(await service.GetPropertycontenttypes(), Request.Query, false), fileName);
//        }

//        [HttpGet("/export/destinationTest/propertycontenttypes/excel")]
//        [HttpGet("/export/destinationTest/propertycontenttypes/excel(fileName='{fileName}')")]
//        public async Task<FileStreamResult> ExportPropertycontenttypesToExcel(string fileName = null)
//        {
//            return ToExcel(ApplyQuery(await service.GetPropertycontenttypes(), Request.Query, false), fileName);
//        }

//        [HttpGet("/export/destinationTest/propertydeposits/csv")]
//        [HttpGet("/export/destinationTest/propertydeposits/csv(fileName='{fileName}')")]
//        public async Task<FileStreamResult> ExportPropertyDepositsToCSV(string fileName = null)
//        {
//            return ToCSV(ApplyQuery(await service.GetPropertyDeposits(), Request.Query, false), fileName);
//        }

//        [HttpGet("/export/destinationTest/propertydeposits/excel")]
//        [HttpGet("/export/destinationTest/propertydeposits/excel(fileName='{fileName}')")]
//        public async Task<FileStreamResult> ExportPropertyDepositsToExcel(string fileName = null)
//        {
//            return ToExcel(ApplyQuery(await service.GetPropertyDeposits(), Request.Query, false), fileName);
//        }

//        [HttpGet("/export/destinationTest/propertyfulltimes/csv")]
//        [HttpGet("/export/destinationTest/propertyfulltimes/csv(fileName='{fileName}')")]
//        public async Task<FileStreamResult> ExportPropertyFulltimesToCSV(string fileName = null)
//        {
//            return ToCSV(ApplyQuery(await service.GetPropertyFulltimes(), Request.Query, false), fileName);
//        }

//        [HttpGet("/export/destinationTest/propertyfulltimes/excel")]
//        [HttpGet("/export/destinationTest/propertyfulltimes/excel(fileName='{fileName}')")]
//        public async Task<FileStreamResult> ExportPropertyFulltimesToExcel(string fileName = null)
//        {
//            return ToExcel(ApplyQuery(await service.GetPropertyFulltimes(), Request.Query, false), fileName);
//        }

//        [HttpGet("/export/destinationTest/propertyinsurances/csv")]
//        [HttpGet("/export/destinationTest/propertyinsurances/csv(fileName='{fileName}')")]
//        public async Task<FileStreamResult> ExportPropertyInsurancesToCSV(string fileName = null)
//        {
//            return ToCSV(ApplyQuery(await service.GetPropertyInsurances(), Request.Query, false), fileName);
//        }

//        [HttpGet("/export/destinationTest/propertyinsurances/excel")]
//        [HttpGet("/export/destinationTest/propertyinsurances/excel(fileName='{fileName}')")]
//        public async Task<FileStreamResult> ExportPropertyInsurancesToExcel(string fileName = null)
//        {
//            return ToExcel(ApplyQuery(await service.GetPropertyInsurances(), Request.Query, false), fileName);
//        }

//        [HttpGet("/export/destinationTest/propertyinsurancecities/csv")]
//        [HttpGet("/export/destinationTest/propertyinsurancecities/csv(fileName='{fileName}')")]
//        public async Task<FileStreamResult> ExportPropertyInsuranceCitiesToCSV(string fileName = null)
//        {
//            return ToCSV(ApplyQuery(await service.GetPropertyInsuranceCities(), Request.Query, false), fileName);
//        }

//        [HttpGet("/export/destinationTest/propertyinsurancecities/excel")]
//        [HttpGet("/export/destinationTest/propertyinsurancecities/excel(fileName='{fileName}')")]
//        public async Task<FileStreamResult> ExportPropertyInsuranceCitiesToExcel(string fileName = null)
//        {
//            return ToExcel(ApplyQuery(await service.GetPropertyInsuranceCities(), Request.Query, false), fileName);
//        }

//        [HttpGet("/export/destinationTest/propertyinsurancecounties/csv")]
//        [HttpGet("/export/destinationTest/propertyinsurancecounties/csv(fileName='{fileName}')")]
//        public async Task<FileStreamResult> ExportPropertyInsuranceCountiesToCSV(string fileName = null)
//        {
//            return ToCSV(ApplyQuery(await service.GetPropertyInsuranceCounties(), Request.Query, false), fileName);
//        }

//        [HttpGet("/export/destinationTest/propertyinsurancecounties/excel")]
//        [HttpGet("/export/destinationTest/propertyinsurancecounties/excel(fileName='{fileName}')")]
//        public async Task<FileStreamResult> ExportPropertyInsuranceCountiesToExcel(string fileName = null)
//        {
//            return ToExcel(ApplyQuery(await service.GetPropertyInsuranceCounties(), Request.Query, false), fileName);
//        }

//        [HttpGet("/export/destinationTest/propertyratesdailies/csv")]
//        [HttpGet("/export/destinationTest/propertyratesdailies/csv(fileName='{fileName}')")]
//        public async Task<FileStreamResult> ExportPropertyRatesDailiesToCSV(string fileName = null)
//        {
//            return ToCSV(ApplyQuery(await service.GetPropertyRatesDailies(), Request.Query, false), fileName);
//        }

//        [HttpGet("/export/destinationTest/propertyratesdailies/excel")]
//        [HttpGet("/export/destinationTest/propertyratesdailies/excel(fileName='{fileName}')")]
//        public async Task<FileStreamResult> ExportPropertyRatesDailiesToExcel(string fileName = null)
//        {
//            return ToExcel(ApplyQuery(await service.GetPropertyRatesDailies(), Request.Query, false), fileName);
//        }

//        [HttpGet("/export/destinationTest/propertyratesdailysingleprops/csv")]
//        [HttpGet("/export/destinationTest/propertyratesdailysingleprops/csv(fileName='{fileName}')")]
//        public async Task<FileStreamResult> ExportPropertyRatesDailySinglePropsToCSV(string fileName = null)
//        {
//            return ToCSV(ApplyQuery(await service.GetPropertyRatesDailySingleProps(), Request.Query, false), fileName);
//        }

//        [HttpGet("/export/destinationTest/propertyratesdailysingleprops/excel")]
//        [HttpGet("/export/destinationTest/propertyratesdailysingleprops/excel(fileName='{fileName}')")]
//        public async Task<FileStreamResult> ExportPropertyRatesDailySinglePropsToExcel(string fileName = null)
//        {
//            return ToExcel(ApplyQuery(await service.GetPropertyRatesDailySingleProps(), Request.Query, false), fileName);
//        }

//        [HttpGet("/export/destinationTest/propertyratesdailytemps/csv")]
//        [HttpGet("/export/destinationTest/propertyratesdailytemps/csv(fileName='{fileName}')")]
//        public async Task<FileStreamResult> ExportPropertyRatesDailyTempsToCSV(string fileName = null)
//        {
//            return ToCSV(ApplyQuery(await service.GetPropertyRatesDailyTemps(), Request.Query, false), fileName);
//        }

//        [HttpGet("/export/destinationTest/propertyratesdailytemps/excel")]
//        [HttpGet("/export/destinationTest/propertyratesdailytemps/excel(fileName='{fileName}')")]
//        public async Task<FileStreamResult> ExportPropertyRatesDailyTempsToExcel(string fileName = null)
//        {
//            return ToExcel(ApplyQuery(await service.GetPropertyRatesDailyTemps(), Request.Query, false), fileName);
//        }

//        [HttpGet("/export/destinationTest/propertyratesdailyminrates/csv")]
//        [HttpGet("/export/destinationTest/propertyratesdailyminrates/csv(fileName='{fileName}')")]
//        public async Task<FileStreamResult> ExportPropertyRatesDailyMinRatesToCSV(string fileName = null)
//        {
//            return ToCSV(ApplyQuery(await service.GetPropertyRatesDailyMinRates(), Request.Query, false), fileName);
//        }

//        [HttpGet("/export/destinationTest/propertyratesdailyminrates/excel")]
//        [HttpGet("/export/destinationTest/propertyratesdailyminrates/excel(fileName='{fileName}')")]
//        public async Task<FileStreamResult> ExportPropertyRatesDailyMinRatesToExcel(string fileName = null)
//        {
//            return ToExcel(ApplyQuery(await service.GetPropertyRatesDailyMinRates(), Request.Query, false), fileName);
//        }

//        [HttpGet("/export/destinationTest/propertyvisitcounts/csv")]
//        [HttpGet("/export/destinationTest/propertyvisitcounts/csv(fileName='{fileName}')")]
//        public async Task<FileStreamResult> ExportPropertyVisitCountsToCSV(string fileName = null)
//        {
//            return ToCSV(ApplyQuery(await service.GetPropertyVisitCounts(), Request.Query, false), fileName);
//        }

//        [HttpGet("/export/destinationTest/propertyvisitcounts/excel")]
//        [HttpGet("/export/destinationTest/propertyvisitcounts/excel(fileName='{fileName}')")]
//        public async Task<FileStreamResult> ExportPropertyVisitCountsToExcel(string fileName = null)
//        {
//            return ToExcel(ApplyQuery(await service.GetPropertyVisitCounts(), Request.Query, false), fileName);
//        }

//        [HttpGet("/export/destinationTest/propertywatchlists/csv")]
//        [HttpGet("/export/destinationTest/propertywatchlists/csv(fileName='{fileName}')")]
//        public async Task<FileStreamResult> ExportPropertyWatchListsToCSV(string fileName = null)
//        {
//            return ToCSV(ApplyQuery(await service.GetPropertyWatchLists(), Request.Query, false), fileName);
//        }

//        [HttpGet("/export/destinationTest/propertywatchlists/excel")]
//        [HttpGet("/export/destinationTest/propertywatchlists/excel(fileName='{fileName}')")]
//        public async Task<FileStreamResult> ExportPropertyWatchListsToExcel(string fileName = null)
//        {
//            return ToExcel(ApplyQuery(await service.GetPropertyWatchLists(), Request.Query, false), fileName);
//        }

//        [HttpGet("/export/destinationTest/propexpmgrs/csv")]
//        [HttpGet("/export/destinationTest/propexpmgrs/csv(fileName='{fileName}')")]
//        public async Task<FileStreamResult> ExportPropExpMgrsToCSV(string fileName = null)
//        {
//            return ToCSV(ApplyQuery(await service.GetPropExpMgrs(), Request.Query, false), fileName);
//        }

//        [HttpGet("/export/destinationTest/propexpmgrs/excel")]
//        [HttpGet("/export/destinationTest/propexpmgrs/excel(fileName='{fileName}')")]
//        public async Task<FileStreamResult> ExportPropExpMgrsToExcel(string fileName = null)
//        {
//            return ToExcel(ApplyQuery(await service.GetPropExpMgrs(), Request.Query, false), fileName);
//        }

//        [HttpGet("/export/destinationTest/ramquestions/csv")]
//        [HttpGet("/export/destinationTest/ramquestions/csv(fileName='{fileName}')")]
//        public async Task<FileStreamResult> ExportRamQuestionsToCSV(string fileName = null)
//        {
//            return ToCSV(ApplyQuery(await service.GetRamQuestions(), Request.Query, false), fileName);
//        }

//        [HttpGet("/export/destinationTest/ramquestions/excel")]
//        [HttpGet("/export/destinationTest/ramquestions/excel(fileName='{fileName}')")]
//        public async Task<FileStreamResult> ExportRamQuestionsToExcel(string fileName = null)
//        {
//            return ToExcel(ApplyQuery(await service.GetRamQuestions(), Request.Query, false), fileName);
//        }

//        [HttpGet("/export/destinationTest/ramtests/csv")]
//        [HttpGet("/export/destinationTest/ramtests/csv(fileName='{fileName}')")]
//        public async Task<FileStreamResult> ExportRamTestsToCSV(string fileName = null)
//        {
//            return ToCSV(ApplyQuery(await service.GetRamTests(), Request.Query, false), fileName);
//        }

//        [HttpGet("/export/destinationTest/ramtests/excel")]
//        [HttpGet("/export/destinationTest/ramtests/excel(fileName='{fileName}')")]
//        public async Task<FileStreamResult> ExportRamTestsToExcel(string fileName = null)
//        {
//            return ToExcel(ApplyQuery(await service.GetRamTests(), Request.Query, false), fileName);
//        }

//        [HttpGet("/export/destinationTest/ramtestresults/csv")]
//        [HttpGet("/export/destinationTest/ramtestresults/csv(fileName='{fileName}')")]
//        public async Task<FileStreamResult> ExportRamTestResultsToCSV(string fileName = null)
//        {
//            return ToCSV(ApplyQuery(await service.GetRamTestResults(), Request.Query, false), fileName);
//        }

//        [HttpGet("/export/destinationTest/ramtestresults/excel")]
//        [HttpGet("/export/destinationTest/ramtestresults/excel(fileName='{fileName}')")]
//        public async Task<FileStreamResult> ExportRamTestResultsToExcel(string fileName = null)
//        {
//            return ToExcel(ApplyQuery(await service.GetRamTestResults(), Request.Query, false), fileName);
//        }

//        [HttpGet("/export/destinationTest/ramtestuserresults/csv")]
//        [HttpGet("/export/destinationTest/ramtestuserresults/csv(fileName='{fileName}')")]
//        public async Task<FileStreamResult> ExportRamTestUserResultsToCSV(string fileName = null)
//        {
//            return ToCSV(ApplyQuery(await service.GetRamTestUserResults(), Request.Query, false), fileName);
//        }

//        [HttpGet("/export/destinationTest/ramtestuserresults/excel")]
//        [HttpGet("/export/destinationTest/ramtestuserresults/excel(fileName='{fileName}')")]
//        public async Task<FileStreamResult> ExportRamTestUserResultsToExcel(string fileName = null)
//        {
//            return ToExcel(ApplyQuery(await service.GetRamTestUserResults(), Request.Query, false), fileName);
//        }

//        [HttpGet("/export/destinationTest/ramtestusers/csv")]
//        [HttpGet("/export/destinationTest/ramtestusers/csv(fileName='{fileName}')")]
//        public async Task<FileStreamResult> ExportRamTestUsersToCSV(string fileName = null)
//        {
//            return ToCSV(ApplyQuery(await service.GetRamTestUsers(), Request.Query, false), fileName);
//        }

//        [HttpGet("/export/destinationTest/ramtestusers/excel")]
//        [HttpGet("/export/destinationTest/ramtestusers/excel(fileName='{fileName}')")]
//        public async Task<FileStreamResult> ExportRamTestUsersToExcel(string fileName = null)
//        {
//            return ToExcel(ApplyQuery(await service.GetRamTestUsers(), Request.Query, false), fileName);
//        }

//        [HttpGet("/export/destinationTest/ratereviews/csv")]
//        [HttpGet("/export/destinationTest/ratereviews/csv(fileName='{fileName}')")]
//        public async Task<FileStreamResult> ExportRateReviewsToCSV(string fileName = null)
//        {
//            return ToCSV(ApplyQuery(await service.GetRateReviews(), Request.Query, false), fileName);
//        }

//        [HttpGet("/export/destinationTest/ratereviews/excel")]
//        [HttpGet("/export/destinationTest/ratereviews/excel(fileName='{fileName}')")]
//        public async Task<FileStreamResult> ExportRateReviewsToExcel(string fileName = null)
//        {
//            return ToExcel(ApplyQuery(await service.GetRateReviews(), Request.Query, false), fileName);
//        }

//        [HttpGet("/export/destinationTest/ratesettings/csv")]
//        [HttpGet("/export/destinationTest/ratesettings/csv(fileName='{fileName}')")]
//        public async Task<FileStreamResult> ExportRateSettingsToCSV(string fileName = null)
//        {
//            return ToCSV(ApplyQuery(await service.GetRateSettings(), Request.Query, false), fileName);
//        }

//        [HttpGet("/export/destinationTest/ratesettings/excel")]
//        [HttpGet("/export/destinationTest/ratesettings/excel(fileName='{fileName}')")]
//        public async Task<FileStreamResult> ExportRateSettingsToExcel(string fileName = null)
//        {
//            return ToExcel(ApplyQuery(await service.GetRateSettings(), Request.Query, false), fileName);
//        }

//        [HttpGet("/export/destinationTest/ratesmins/csv")]
//        [HttpGet("/export/destinationTest/ratesmins/csv(fileName='{fileName}')")]
//        public async Task<FileStreamResult> ExportRatesMinsToCSV(string fileName = null)
//        {
//            return ToCSV(ApplyQuery(await service.GetRatesMins(), Request.Query, false), fileName);
//        }

//        [HttpGet("/export/destinationTest/ratesmins/excel")]
//        [HttpGet("/export/destinationTest/ratesmins/excel(fileName='{fileName}')")]
//        public async Task<FileStreamResult> ExportRatesMinsToExcel(string fileName = null)
//        {
//            return ToExcel(ApplyQuery(await service.GetRatesMins(), Request.Query, false), fileName);
//        }

//        [HttpGet("/export/destinationTest/restrictions/csv")]
//        [HttpGet("/export/destinationTest/restrictions/csv(fileName='{fileName}')")]
//        public async Task<FileStreamResult> ExportRestrictionsToCSV(string fileName = null)
//        {
//            return ToCSV(ApplyQuery(await service.GetRestrictions(), Request.Query, false), fileName);
//        }

//        [HttpGet("/export/destinationTest/restrictions/excel")]
//        [HttpGet("/export/destinationTest/restrictions/excel(fileName='{fileName}')")]
//        public async Task<FileStreamResult> ExportRestrictionsToExcel(string fileName = null)
//        {
//            return ToExcel(ApplyQuery(await service.GetRestrictions(), Request.Query, false), fileName);
//        }

//        [HttpGet("/export/destinationTest/reviewmappings/csv")]
//        [HttpGet("/export/destinationTest/reviewmappings/csv(fileName='{fileName}')")]
//        public async Task<FileStreamResult> ExportReviewMappingsToCSV(string fileName = null)
//        {
//            return ToCSV(ApplyQuery(await service.GetReviewMappings(), Request.Query, false), fileName);
//        }

//        [HttpGet("/export/destinationTest/reviewmappings/excel")]
//        [HttpGet("/export/destinationTest/reviewmappings/excel(fileName='{fileName}')")]
//        public async Task<FileStreamResult> ExportReviewMappingsToExcel(string fileName = null)
//        {
//            return ToExcel(ApplyQuery(await service.GetReviewMappings(), Request.Query, false), fileName);
//        }

//        [HttpGet("/export/destinationTest/reviews/csv")]
//        [HttpGet("/export/destinationTest/reviews/csv(fileName='{fileName}')")]
//        public async Task<FileStreamResult> ExportReviewsToCSV(string fileName = null)
//        {
//            return ToCSV(ApplyQuery(await service.GetReviews(), Request.Query, false), fileName);
//        }

//        [HttpGet("/export/destinationTest/reviews/excel")]
//        [HttpGet("/export/destinationTest/reviews/excel(fileName='{fileName}')")]
//        public async Task<FileStreamResult> ExportReviewsToExcel(string fileName = null)
//        {
//            return ToExcel(ApplyQuery(await service.GetReviews(), Request.Query, false), fileName);
//        }

//        [HttpGet("/export/destinationTest/sample23s/csv")]
//        [HttpGet("/export/destinationTest/sample23s/csv(fileName='{fileName}')")]
//        public async Task<FileStreamResult> ExportSample23SToCSV(string fileName = null)
//        {
//            return ToCSV(ApplyQuery(await service.GetSample23S(), Request.Query, false), fileName);
//        }

//        [HttpGet("/export/destinationTest/sample23s/excel")]
//        [HttpGet("/export/destinationTest/sample23s/excel(fileName='{fileName}')")]
//        public async Task<FileStreamResult> ExportSample23SToExcel(string fileName = null)
//        {
//            return ToExcel(ApplyQuery(await service.GetSample23S(), Request.Query, false), fileName);
//        }

//        [HttpGet("/export/destinationTest/searches/csv")]
//        [HttpGet("/export/destinationTest/searches/csv(fileName='{fileName}')")]
//        public async Task<FileStreamResult> ExportSearchesToCSV(string fileName = null)
//        {
//            return ToCSV(ApplyQuery(await service.GetSearches(), Request.Query, false), fileName);
//        }

//        [HttpGet("/export/destinationTest/searches/excel")]
//        [HttpGet("/export/destinationTest/searches/excel(fileName='{fileName}')")]
//        public async Task<FileStreamResult> ExportSearchesToExcel(string fileName = null)
//        {
//            return ToExcel(ApplyQuery(await service.GetSearches(), Request.Query, false), fileName);
//        }

//        [HttpGet("/export/destinationTest/sendairbnbcheckoutreplies/csv")]
//        [HttpGet("/export/destinationTest/sendairbnbcheckoutreplies/csv(fileName='{fileName}')")]
//        public async Task<FileStreamResult> ExportSendAirbnbCheckOutRepliesToCSV(string fileName = null)
//        {
//            return ToCSV(ApplyQuery(await service.GetSendAirbnbCheckOutReplies(), Request.Query, false), fileName);
//        }

//        [HttpGet("/export/destinationTest/sendairbnbcheckoutreplies/excel")]
//        [HttpGet("/export/destinationTest/sendairbnbcheckoutreplies/excel(fileName='{fileName}')")]
//        public async Task<FileStreamResult> ExportSendAirbnbCheckOutRepliesToExcel(string fileName = null)
//        {
//            return ToExcel(ApplyQuery(await service.GetSendAirbnbCheckOutReplies(), Request.Query, false), fileName);
//        }

//        [HttpGet("/export/destinationTest/sendtoemailfornotificationpages/csv")]
//        [HttpGet("/export/destinationTest/sendtoemailfornotificationpages/csv(fileName='{fileName}')")]
//        public async Task<FileStreamResult> ExportSendToEmailForNotificationPagesToCSV(string fileName = null)
//        {
//            return ToCSV(ApplyQuery(await service.GetSendToEmailForNotificationPages(), Request.Query, false), fileName);
//        }

//        [HttpGet("/export/destinationTest/sendtoemailfornotificationpages/excel")]
//        [HttpGet("/export/destinationTest/sendtoemailfornotificationpages/excel(fileName='{fileName}')")]
//        public async Task<FileStreamResult> ExportSendToEmailForNotificationPagesToExcel(string fileName = null)
//        {
//            return ToExcel(ApplyQuery(await service.GetSendToEmailForNotificationPages(), Request.Query, false), fileName);
//        }

//        [HttpGet("/export/destinationTest/sendtwiliosms/csv")]
//        [HttpGet("/export/destinationTest/sendtwiliosms/csv(fileName='{fileName}')")]
//        public async Task<FileStreamResult> ExportSendTwilioSmsToCSV(string fileName = null)
//        {
//            return ToCSV(ApplyQuery(await service.GetSendTwilioSms(), Request.Query, false), fileName);
//        }

//        [HttpGet("/export/destinationTest/sendtwiliosms/excel")]
//        [HttpGet("/export/destinationTest/sendtwiliosms/excel(fileName='{fileName}')")]
//        public async Task<FileStreamResult> ExportSendTwilioSmsToExcel(string fileName = null)
//        {
//            return ToExcel(ApplyQuery(await service.GetSendTwilioSms(), Request.Query, false), fileName);
//        }

//        [HttpGet("/export/destinationTest/sendtwiliosmsqueues/csv")]
//        [HttpGet("/export/destinationTest/sendtwiliosmsqueues/csv(fileName='{fileName}')")]
//        public async Task<FileStreamResult> ExportSendTwilioSmsQueuesToCSV(string fileName = null)
//        {
//            return ToCSV(ApplyQuery(await service.GetSendTwilioSmsQueues(), Request.Query, false), fileName);
//        }

//        [HttpGet("/export/destinationTest/sendtwiliosmsqueues/excel")]
//        [HttpGet("/export/destinationTest/sendtwiliosmsqueues/excel(fileName='{fileName}')")]
//        public async Task<FileStreamResult> ExportSendTwilioSmsQueuesToExcel(string fileName = null)
//        {
//            return ToExcel(ApplyQuery(await service.GetSendTwilioSmsQueues(), Request.Query, false), fileName);
//        }

//        [HttpGet("/export/destinationTest/settings/csv")]
//        [HttpGet("/export/destinationTest/settings/csv(fileName='{fileName}')")]
//        public async Task<FileStreamResult> ExportSettingsToCSV(string fileName = null)
//        {
//            return ToCSV(ApplyQuery(await service.GetSettings(), Request.Query, false), fileName);
//        }

//        [HttpGet("/export/destinationTest/settings/excel")]
//        [HttpGet("/export/destinationTest/settings/excel(fileName='{fileName}')")]
//        public async Task<FileStreamResult> ExportSettingsToExcel(string fileName = null)
//        {
//            return ToExcel(ApplyQuery(await service.GetSettings(), Request.Query, false), fileName);
//        }

//        [HttpGet("/export/destinationTest/sheet1s/csv")]
//        [HttpGet("/export/destinationTest/sheet1s/csv(fileName='{fileName}')")]
//        public async Task<FileStreamResult> ExportSheet1SToCSV(string fileName = null)
//        {
//            return ToCSV(ApplyQuery(await service.GetSheet1S(), Request.Query, false), fileName);
//        }

//        [HttpGet("/export/destinationTest/sheet1s/excel")]
//        [HttpGet("/export/destinationTest/sheet1s/excel(fileName='{fileName}')")]
//        public async Task<FileStreamResult> ExportSheet1SToExcel(string fileName = null)
//        {
//            return ToExcel(ApplyQuery(await service.GetSheet1S(), Request.Query, false), fileName);
//        }

//        [HttpGet("/export/destinationTest/sheet2s/csv")]
//        [HttpGet("/export/destinationTest/sheet2s/csv(fileName='{fileName}')")]
//        public async Task<FileStreamResult> ExportSheet2SToCSV(string fileName = null)
//        {
//            return ToCSV(ApplyQuery(await service.GetSheet2S(), Request.Query, false), fileName);
//        }

//        [HttpGet("/export/destinationTest/sheet2s/excel")]
//        [HttpGet("/export/destinationTest/sheet2s/excel(fileName='{fileName}')")]
//        public async Task<FileStreamResult> ExportSheet2SToExcel(string fileName = null)
//        {
//            return ToExcel(ApplyQuery(await service.GetSheet2S(), Request.Query, false), fileName);
//        }

//        [HttpGet("/export/destinationTest/smsgroups/csv")]
//        [HttpGet("/export/destinationTest/smsgroups/csv(fileName='{fileName}')")]
//        public async Task<FileStreamResult> ExportSmsgroupsToCSV(string fileName = null)
//        {
//            return ToCSV(ApplyQuery(await service.GetSmsgroups(), Request.Query, false), fileName);
//        }

//        [HttpGet("/export/destinationTest/smsgroups/excel")]
//        [HttpGet("/export/destinationTest/smsgroups/excel(fileName='{fileName}')")]
//        public async Task<FileStreamResult> ExportSmsgroupsToExcel(string fileName = null)
//        {
//            return ToExcel(ApplyQuery(await service.GetSmsgroups(), Request.Query, false), fileName);
//        }

//        [HttpGet("/export/destinationTest/smsmessages/csv")]
//        [HttpGet("/export/destinationTest/smsmessages/csv(fileName='{fileName}')")]
//        public async Task<FileStreamResult> ExportSmsmessagesToCSV(string fileName = null)
//        {
//            return ToCSV(ApplyQuery(await service.GetSmsmessages(), Request.Query, false), fileName);
//        }

//        [HttpGet("/export/destinationTest/smsmessages/excel")]
//        [HttpGet("/export/destinationTest/smsmessages/excel(fileName='{fileName}')")]
//        public async Task<FileStreamResult> ExportSmsmessagesToExcel(string fileName = null)
//        {
//            return ToExcel(ApplyQuery(await service.GetSmsmessages(), Request.Query, false), fileName);
//        }

//        [HttpGet("/export/destinationTest/smsremovelists/csv")]
//        [HttpGet("/export/destinationTest/smsremovelists/csv(fileName='{fileName}')")]
//        public async Task<FileStreamResult> ExportSmsRemoveListsToCSV(string fileName = null)
//        {
//            return ToCSV(ApplyQuery(await service.GetSmsRemoveLists(), Request.Query, false), fileName);
//        }

//        [HttpGet("/export/destinationTest/smsremovelists/excel")]
//        [HttpGet("/export/destinationTest/smsremovelists/excel(fileName='{fileName}')")]
//        public async Task<FileStreamResult> ExportSmsRemoveListsToExcel(string fileName = null)
//        {
//            return ToExcel(ApplyQuery(await service.GetSmsRemoveLists(), Request.Query, false), fileName);
//        }

//        [HttpGet("/export/destinationTest/smstemplateareas/csv")]
//        [HttpGet("/export/destinationTest/smstemplateareas/csv(fileName='{fileName}')")]
//        public async Task<FileStreamResult> ExportSmstemplateAreasToCSV(string fileName = null)
//        {
//            return ToCSV(ApplyQuery(await service.GetSmstemplateAreas(), Request.Query, false), fileName);
//        }

//        [HttpGet("/export/destinationTest/smstemplateareas/excel")]
//        [HttpGet("/export/destinationTest/smstemplateareas/excel(fileName='{fileName}')")]
//        public async Task<FileStreamResult> ExportSmstemplateAreasToExcel(string fileName = null)
//        {
//            return ToExcel(ApplyQuery(await service.GetSmstemplateAreas(), Request.Query, false), fileName);
//        }

//        [HttpGet("/export/destinationTest/smstemplates/csv")]
//        [HttpGet("/export/destinationTest/smstemplates/csv(fileName='{fileName}')")]
//        public async Task<FileStreamResult> ExportSmstemplatesToCSV(string fileName = null)
//        {
//            return ToCSV(ApplyQuery(await service.GetSmstemplates(), Request.Query, false), fileName);
//        }

//        [HttpGet("/export/destinationTest/smstemplates/excel")]
//        [HttpGet("/export/destinationTest/smstemplates/excel(fileName='{fileName}')")]
//        public async Task<FileStreamResult> ExportSmstemplatesToExcel(string fileName = null)
//        {
//            return ToExcel(ApplyQuery(await service.GetSmstemplates(), Request.Query, false), fileName);
//        }

//        [HttpGet("/export/destinationTest/snowremovals/csv")]
//        [HttpGet("/export/destinationTest/snowremovals/csv(fileName='{fileName}')")]
//        public async Task<FileStreamResult> ExportSnowRemovalsToCSV(string fileName = null)
//        {
//            return ToCSV(ApplyQuery(await service.GetSnowRemovals(), Request.Query, false), fileName);
//        }

//        [HttpGet("/export/destinationTest/snowremovals/excel")]
//        [HttpGet("/export/destinationTest/snowremovals/excel(fileName='{fileName}')")]
//        public async Task<FileStreamResult> ExportSnowRemovalsToExcel(string fileName = null)
//        {
//            return ToExcel(ApplyQuery(await service.GetSnowRemovals(), Request.Query, false), fileName);
//        }

//        [HttpGet("/export/destinationTest/spatransactions/csv")]
//        [HttpGet("/export/destinationTest/spatransactions/csv(fileName='{fileName}')")]
//        public async Task<FileStreamResult> ExportSpaTransactionsToCSV(string fileName = null)
//        {
//            return ToCSV(ApplyQuery(await service.GetSpaTransactions(), Request.Query, false), fileName);
//        }

//        [HttpGet("/export/destinationTest/spatransactions/excel")]
//        [HttpGet("/export/destinationTest/spatransactions/excel(fileName='{fileName}')")]
//        public async Task<FileStreamResult> ExportSpaTransactionsToExcel(string fileName = null)
//        {
//            return ToExcel(ApplyQuery(await service.GetSpaTransactions(), Request.Query, false), fileName);
//        }

//        [HttpGet("/export/destinationTest/statuses/csv")]
//        [HttpGet("/export/destinationTest/statuses/csv(fileName='{fileName}')")]
//        public async Task<FileStreamResult> ExportStatusesToCSV(string fileName = null)
//        {
//            return ToCSV(ApplyQuery(await service.GetStatuses(), Request.Query, false), fileName);
//        }

//        [HttpGet("/export/destinationTest/statuses/excel")]
//        [HttpGet("/export/destinationTest/statuses/excel(fileName='{fileName}')")]
//        public async Task<FileStreamResult> ExportStatusesToExcel(string fileName = null)
//        {
//            return ToExcel(ApplyQuery(await service.GetStatuses(), Request.Query, false), fileName);
//        }

//        [HttpGet("/export/destinationTest/systempages/csv")]
//        [HttpGet("/export/destinationTest/systempages/csv(fileName='{fileName}')")]
//        public async Task<FileStreamResult> ExportSystemPagesToCSV(string fileName = null)
//        {
//            return ToCSV(ApplyQuery(await service.GetSystemPages(), Request.Query, false), fileName);
//        }

//        [HttpGet("/export/destinationTest/systempages/excel")]
//        [HttpGet("/export/destinationTest/systempages/excel(fileName='{fileName}')")]
//        public async Task<FileStreamResult> ExportSystemPagesToExcel(string fileName = null)
//        {
//            return ToExcel(ApplyQuery(await service.GetSystemPages(), Request.Query, false), fileName);
//        }

//        [HttpGet("/export/destinationTest/taskdescs/csv")]
//        [HttpGet("/export/destinationTest/taskdescs/csv(fileName='{fileName}')")]
//        public async Task<FileStreamResult> ExportTaskDescsToCSV(string fileName = null)
//        {
//            return ToCSV(ApplyQuery(await service.GetTaskDescs(), Request.Query, false), fileName);
//        }

//        [HttpGet("/export/destinationTest/taskdescs/excel")]
//        [HttpGet("/export/destinationTest/taskdescs/excel(fileName='{fileName}')")]
//        public async Task<FileStreamResult> ExportTaskDescsToExcel(string fileName = null)
//        {
//            return ToExcel(ApplyQuery(await service.GetTaskDescs(), Request.Query, false), fileName);
//        }

//        [HttpGet("/export/destinationTest/tblairbnbexporttemps/csv")]
//        [HttpGet("/export/destinationTest/tblairbnbexporttemps/csv(fileName='{fileName}')")]
//        public async Task<FileStreamResult> ExportTblAirbnbExportTempsToCSV(string fileName = null)
//        {
//            return ToCSV(ApplyQuery(await service.GetTblAirbnbExportTemps(), Request.Query, false), fileName);
//        }

//        [HttpGet("/export/destinationTest/tblairbnbexporttemps/excel")]
//        [HttpGet("/export/destinationTest/tblairbnbexporttemps/excel(fileName='{fileName}')")]
//        public async Task<FileStreamResult> ExportTblAirbnbExportTempsToExcel(string fileName = null)
//        {
//            return ToExcel(ApplyQuery(await service.GetTblAirbnbExportTemps(), Request.Query, false), fileName);
//        }

//        [HttpGet("/export/destinationTest/tblbookingidsformails/csv")]
//        [HttpGet("/export/destinationTest/tblbookingidsformails/csv(fileName='{fileName}')")]
//        public async Task<FileStreamResult> ExportTblBookingIdsForMailsToCSV(string fileName = null)
//        {
//            return ToCSV(ApplyQuery(await service.GetTblBookingIdsForMails(), Request.Query, false), fileName);
//        }

//        [HttpGet("/export/destinationTest/tblbookingidsformails/excel")]
//        [HttpGet("/export/destinationTest/tblbookingidsformails/excel(fileName='{fileName}')")]
//        public async Task<FileStreamResult> ExportTblBookingIdsForMailsToExcel(string fileName = null)
//        {
//            return ToExcel(ApplyQuery(await service.GetTblBookingIdsForMails(), Request.Query, false), fileName);
//        }

//        [HttpGet("/export/destinationTest/tblbookinginterests/csv")]
//        [HttpGet("/export/destinationTest/tblbookinginterests/csv(fileName='{fileName}')")]
//        public async Task<FileStreamResult> ExportTblBookingInterestsToCSV(string fileName = null)
//        {
//            return ToCSV(ApplyQuery(await service.GetTblBookingInterests(), Request.Query, false), fileName);
//        }

//        [HttpGet("/export/destinationTest/tblbookinginterests/excel")]
//        [HttpGet("/export/destinationTest/tblbookinginterests/excel(fileName='{fileName}')")]
//        public async Task<FileStreamResult> ExportTblBookingInterestsToExcel(string fileName = null)
//        {
//            return ToExcel(ApplyQuery(await service.GetTblBookingInterests(), Request.Query, false), fileName);
//        }

//        [HttpGet("/export/destinationTest/tblbulkemaillogs/csv")]
//        [HttpGet("/export/destinationTest/tblbulkemaillogs/csv(fileName='{fileName}')")]
//        public async Task<FileStreamResult> ExportTblBulkEmailLogsToCSV(string fileName = null)
//        {
//            return ToCSV(ApplyQuery(await service.GetTblBulkEmailLogs(), Request.Query, false), fileName);
//        }

//        [HttpGet("/export/destinationTest/tblbulkemaillogs/excel")]
//        [HttpGet("/export/destinationTest/tblbulkemaillogs/excel(fileName='{fileName}')")]
//        public async Task<FileStreamResult> ExportTblBulkEmailLogsToExcel(string fileName = null)
//        {
//            return ToExcel(ApplyQuery(await service.GetTblBulkEmailLogs(), Request.Query, false), fileName);
//        }

//        [HttpGet("/export/destinationTest/tblchksms/csv")]
//        [HttpGet("/export/destinationTest/tblchksms/csv(fileName='{fileName}')")]
//        public async Task<FileStreamResult> ExportTblChkSmsToCSV(string fileName = null)
//        {
//            return ToCSV(ApplyQuery(await service.GetTblChkSms(), Request.Query, false), fileName);
//        }

//        [HttpGet("/export/destinationTest/tblchksms/excel")]
//        [HttpGet("/export/destinationTest/tblchksms/excel(fileName='{fileName}')")]
//        public async Task<FileStreamResult> ExportTblChkSmsToExcel(string fileName = null)
//        {
//            return ToExcel(ApplyQuery(await service.GetTblChkSms(), Request.Query, false), fileName);
//        }

//        [HttpGet("/export/destinationTest/tbldebugs/csv")]
//        [HttpGet("/export/destinationTest/tbldebugs/csv(fileName='{fileName}')")]
//        public async Task<FileStreamResult> ExportTblDebugsToCSV(string fileName = null)
//        {
//            return ToCSV(ApplyQuery(await service.GetTblDebugs(), Request.Query, false), fileName);
//        }

//        [HttpGet("/export/destinationTest/tbldebugs/excel")]
//        [HttpGet("/export/destinationTest/tbldebugs/excel(fileName='{fileName}')")]
//        public async Task<FileStreamResult> ExportTblDebugsToExcel(string fileName = null)
//        {
//            return ToExcel(ApplyQuery(await service.GetTblDebugs(), Request.Query, false), fileName);
//        }

//        [HttpGet("/export/destinationTest/tblhomepageimageslinks/csv")]
//        [HttpGet("/export/destinationTest/tblhomepageimageslinks/csv(fileName='{fileName}')")]
//        public async Task<FileStreamResult> ExportTblHomePageImagesLinksToCSV(string fileName = null)
//        {
//            return ToCSV(ApplyQuery(await service.GetTblHomePageImagesLinks(), Request.Query, false), fileName);
//        }

//        [HttpGet("/export/destinationTest/tblhomepageimageslinks/excel")]
//        [HttpGet("/export/destinationTest/tblhomepageimageslinks/excel(fileName='{fileName}')")]
//        public async Task<FileStreamResult> ExportTblHomePageImagesLinksToExcel(string fileName = null)
//        {
//            return ToExcel(ApplyQuery(await service.GetTblHomePageImagesLinks(), Request.Query, false), fileName);
//        }

//        [HttpGet("/export/destinationTest/tblinterests/csv")]
//        [HttpGet("/export/destinationTest/tblinterests/csv(fileName='{fileName}')")]
//        public async Task<FileStreamResult> ExportTblInterestsToCSV(string fileName = null)
//        {
//            return ToCSV(ApplyQuery(await service.GetTblInterests(), Request.Query, false), fileName);
//        }

//        [HttpGet("/export/destinationTest/tblinterests/excel")]
//        [HttpGet("/export/destinationTest/tblinterests/excel(fileName='{fileName}')")]
//        public async Task<FileStreamResult> ExportTblInterestsToExcel(string fileName = null)
//        {
//            return ToExcel(ApplyQuery(await service.GetTblInterests(), Request.Query, false), fileName);
//        }

//        [HttpGet("/export/destinationTest/tblinterests1/csv")]
//        [HttpGet("/export/destinationTest/tblinterests1/csv(fileName='{fileName}')")]
//        public async Task<FileStreamResult> ExportTblInterests1ToCSV(string fileName = null)
//        {
//            return ToCSV(ApplyQuery(await service.GetTblInterests1(), Request.Query, false), fileName);
//        }

//        [HttpGet("/export/destinationTest/tblinterests1/excel")]
//        [HttpGet("/export/destinationTest/tblinterests1/excel(fileName='{fileName}')")]
//        public async Task<FileStreamResult> ExportTblInterests1ToExcel(string fileName = null)
//        {
//            return ToExcel(ApplyQuery(await service.GetTblInterests1(), Request.Query, false), fileName);
//        }

//        [HttpGet("/export/destinationTest/tblmultidaydiscounts/csv")]
//        [HttpGet("/export/destinationTest/tblmultidaydiscounts/csv(fileName='{fileName}')")]
//        public async Task<FileStreamResult> ExportTblMultiDayDiscountsToCSV(string fileName = null)
//        {
//            return ToCSV(ApplyQuery(await service.GetTblMultiDayDiscounts(), Request.Query, false), fileName);
//        }

//        [HttpGet("/export/destinationTest/tblmultidaydiscounts/excel")]
//        [HttpGet("/export/destinationTest/tblmultidaydiscounts/excel(fileName='{fileName}')")]
//        public async Task<FileStreamResult> ExportTblMultiDayDiscountsToExcel(string fileName = null)
//        {
//            return ToExcel(ApplyQuery(await service.GetTblMultiDayDiscounts(), Request.Query, false), fileName);
//        }

//        [HttpGet("/export/destinationTest/tblnotavtivepropertybookings/csv")]
//        [HttpGet("/export/destinationTest/tblnotavtivepropertybookings/csv(fileName='{fileName}')")]
//        public async Task<FileStreamResult> ExportTblNotAvtivePropertyBookingsToCSV(string fileName = null)
//        {
//            return ToCSV(ApplyQuery(await service.GetTblNotAvtivePropertyBookings(), Request.Query, false), fileName);
//        }

//        [HttpGet("/export/destinationTest/tblnotavtivepropertybookings/excel")]
//        [HttpGet("/export/destinationTest/tblnotavtivepropertybookings/excel(fileName='{fileName}')")]
//        public async Task<FileStreamResult> ExportTblNotAvtivePropertyBookingsToExcel(string fileName = null)
//        {
//            return ToExcel(ApplyQuery(await service.GetTblNotAvtivePropertyBookings(), Request.Query, false), fileName);
//        }

//        [HttpGet("/export/destinationTest/tblnotsendingemails/csv")]
//        [HttpGet("/export/destinationTest/tblnotsendingemails/csv(fileName='{fileName}')")]
//        public async Task<FileStreamResult> ExportTblNotSendingEmailsToCSV(string fileName = null)
//        {
//            return ToCSV(ApplyQuery(await service.GetTblNotSendingEmails(), Request.Query, false), fileName);
//        }

//        [HttpGet("/export/destinationTest/tblnotsendingemails/excel")]
//        [HttpGet("/export/destinationTest/tblnotsendingemails/excel(fileName='{fileName}')")]
//        public async Task<FileStreamResult> ExportTblNotSendingEmailsToExcel(string fileName = null)
//        {
//            return ToExcel(ApplyQuery(await service.GetTblNotSendingEmails(), Request.Query, false), fileName);
//        }

//        [HttpGet("/export/destinationTest/tblpartialcheckins/csv")]
//        [HttpGet("/export/destinationTest/tblpartialcheckins/csv(fileName='{fileName}')")]
//        public async Task<FileStreamResult> ExportTblPartialCheckInsToCSV(string fileName = null)
//        {
//            return ToCSV(ApplyQuery(await service.GetTblPartialCheckIns(), Request.Query, false), fileName);
//        }

//        [HttpGet("/export/destinationTest/tblpartialcheckins/excel")]
//        [HttpGet("/export/destinationTest/tblpartialcheckins/excel(fileName='{fileName}')")]
//        public async Task<FileStreamResult> ExportTblPartialCheckInsToExcel(string fileName = null)
//        {
//            return ToExcel(ApplyQuery(await service.GetTblPartialCheckIns(), Request.Query, false), fileName);
//        }

//        [HttpGet("/export/destinationTest/tblpropertyactiveinactivetrackforflipkeyfeeds/csv")]
//        [HttpGet("/export/destinationTest/tblpropertyactiveinactivetrackforflipkeyfeeds/csv(fileName='{fileName}')")]
//        public async Task<FileStreamResult> ExportTblPropertyActiveInactiveTrackForFlipkeyFeedsToCSV(string fileName = null)
//        {
//            return ToCSV(ApplyQuery(await service.GetTblPropertyActiveInactiveTrackForFlipkeyFeeds(), Request.Query, false), fileName);
//        }

//        [HttpGet("/export/destinationTest/tblpropertyactiveinactivetrackforflipkeyfeeds/excel")]
//        [HttpGet("/export/destinationTest/tblpropertyactiveinactivetrackforflipkeyfeeds/excel(fileName='{fileName}')")]
//        public async Task<FileStreamResult> ExportTblPropertyActiveInactiveTrackForFlipkeyFeedsToExcel(string fileName = null)
//        {
//            return ToExcel(ApplyQuery(await service.GetTblPropertyActiveInactiveTrackForFlipkeyFeeds(), Request.Query, false), fileName);
//        }

//        [HttpGet("/export/destinationTest/tblpropertyimages/csv")]
//        [HttpGet("/export/destinationTest/tblpropertyimages/csv(fileName='{fileName}')")]
//        public async Task<FileStreamResult> ExportTblPropertyImagesToCSV(string fileName = null)
//        {
//            return ToCSV(ApplyQuery(await service.GetTblPropertyImages(), Request.Query, false), fileName);
//        }

//        [HttpGet("/export/destinationTest/tblpropertyimages/excel")]
//        [HttpGet("/export/destinationTest/tblpropertyimages/excel(fileName='{fileName}')")]
//        public async Task<FileStreamResult> ExportTblPropertyImagesToExcel(string fileName = null)
//        {
//            return ToExcel(ApplyQuery(await service.GetTblPropertyImages(), Request.Query, false), fileName);
//        }

//        [HttpGet("/export/destinationTest/tblpropertyratesdailymisseddatesprops/csv")]
//        [HttpGet("/export/destinationTest/tblpropertyratesdailymisseddatesprops/csv(fileName='{fileName}')")]
//        public async Task<FileStreamResult> ExportTblPropertyRatesDailyMissedDatesPropsToCSV(string fileName = null)
//        {
//            return ToCSV(ApplyQuery(await service.GetTblPropertyRatesDailyMissedDatesProps(), Request.Query, false), fileName);
//        }

//        [HttpGet("/export/destinationTest/tblpropertyratesdailymisseddatesprops/excel")]
//        [HttpGet("/export/destinationTest/tblpropertyratesdailymisseddatesprops/excel(fileName='{fileName}')")]
//        public async Task<FileStreamResult> ExportTblPropertyRatesDailyMissedDatesPropsToExcel(string fileName = null)
//        {
//            return ToExcel(ApplyQuery(await service.GetTblPropertyRatesDailyMissedDatesProps(), Request.Query, false), fileName);
//        }

//        [HttpGet("/export/destinationTest/tblratetemps/csv")]
//        [HttpGet("/export/destinationTest/tblratetemps/csv(fileName='{fileName}')")]
//        public async Task<FileStreamResult> ExportTblrateTempsToCSV(string fileName = null)
//        {
//            return ToCSV(ApplyQuery(await service.GetTblrateTemps(), Request.Query, false), fileName);
//        }

//        [HttpGet("/export/destinationTest/tblratetemps/excel")]
//        [HttpGet("/export/destinationTest/tblratetemps/excel(fileName='{fileName}')")]
//        public async Task<FileStreamResult> ExportTblrateTempsToExcel(string fileName = null)
//        {
//            return ToExcel(ApplyQuery(await service.GetTblrateTemps(), Request.Query, false), fileName);
//        }

//        [HttpGet("/export/destinationTest/tblservices/csv")]
//        [HttpGet("/export/destinationTest/tblservices/csv(fileName='{fileName}')")]
//        public async Task<FileStreamResult> ExportTblServicesToCSV(string fileName = null)
//        {
//            return ToCSV(ApplyQuery(await service.GetTblServices(), Request.Query, false), fileName);
//        }

//        [HttpGet("/export/destinationTest/tblservices/excel")]
//        [HttpGet("/export/destinationTest/tblservices/excel(fileName='{fileName}')")]
//        public async Task<FileStreamResult> ExportTblServicesToExcel(string fileName = null)
//        {
//            return ToExcel(ApplyQuery(await service.GetTblServices(), Request.Query, false), fileName);
//        }

//        [HttpGet("/export/destinationTest/tbltrackdailyratesexecutionforproperties/csv")]
//        [HttpGet("/export/destinationTest/tbltrackdailyratesexecutionforproperties/csv(fileName='{fileName}')")]
//        public async Task<FileStreamResult> ExportTblTrackDailyRatesExecutionForPropertiesToCSV(string fileName = null)
//        {
//            return ToCSV(ApplyQuery(await service.GetTblTrackDailyRatesExecutionForProperties(), Request.Query, false), fileName);
//        }

//        [HttpGet("/export/destinationTest/tbltrackdailyratesexecutionforproperties/excel")]
//        [HttpGet("/export/destinationTest/tbltrackdailyratesexecutionforproperties/excel(fileName='{fileName}')")]
//        public async Task<FileStreamResult> ExportTblTrackDailyRatesExecutionForPropertiesToExcel(string fileName = null)
//        {
//            return ToExcel(ApplyQuery(await service.GetTblTrackDailyRatesExecutionForProperties(), Request.Query, false), fileName);
//        }

//        [HttpGet("/export/destinationTest/tbltypemasters/csv")]
//        [HttpGet("/export/destinationTest/tbltypemasters/csv(fileName='{fileName}')")]
//        public async Task<FileStreamResult> ExportTblTypeMastersToCSV(string fileName = null)
//        {
//            return ToCSV(ApplyQuery(await service.GetTblTypeMasters(), Request.Query, false), fileName);
//        }

//        [HttpGet("/export/destinationTest/tbltypemasters/excel")]
//        [HttpGet("/export/destinationTest/tbltypemasters/excel(fileName='{fileName}')")]
//        public async Task<FileStreamResult> ExportTblTypeMastersToExcel(string fileName = null)
//        {
//            return ToExcel(ApplyQuery(await service.GetTblTypeMasters(), Request.Query, false), fileName);
//        }

//        [HttpGet("/export/destinationTest/temp12s/csv")]
//        [HttpGet("/export/destinationTest/temp12s/csv(fileName='{fileName}')")]
//        public async Task<FileStreamResult> ExportTemp12SToCSV(string fileName = null)
//        {
//            return ToCSV(ApplyQuery(await service.GetTemp12S(), Request.Query, false), fileName);
//        }

//        [HttpGet("/export/destinationTest/temp12s/excel")]
//        [HttpGet("/export/destinationTest/temp12s/excel(fileName='{fileName}')")]
//        public async Task<FileStreamResult> ExportTemp12SToExcel(string fileName = null)
//        {
//            return ToExcel(ApplyQuery(await service.GetTemp12S(), Request.Query, false), fileName);
//        }

//        [HttpGet("/export/destinationTest/tempcoms/csv")]
//        [HttpGet("/export/destinationTest/tempcoms/csv(fileName='{fileName}')")]
//        public async Task<FileStreamResult> ExportTempComsToCSV(string fileName = null)
//        {
//            return ToCSV(ApplyQuery(await service.GetTempComs(), Request.Query, false), fileName);
//        }

//        [HttpGet("/export/destinationTest/tempcoms/excel")]
//        [HttpGet("/export/destinationTest/tempcoms/excel(fileName='{fileName}')")]
//        public async Task<FileStreamResult> ExportTempComsToExcel(string fileName = null)
//        {
//            return ToExcel(ApplyQuery(await service.GetTempComs(), Request.Query, false), fileName);
//        }

//        [HttpGet("/export/destinationTest/templatecats/csv")]
//        [HttpGet("/export/destinationTest/templatecats/csv(fileName='{fileName}')")]
//        public async Task<FileStreamResult> ExportTemplateCatsToCSV(string fileName = null)
//        {
//            return ToCSV(ApplyQuery(await service.GetTemplateCats(), Request.Query, false), fileName);
//        }

//        [HttpGet("/export/destinationTest/templatecats/excel")]
//        [HttpGet("/export/destinationTest/templatecats/excel(fileName='{fileName}')")]
//        public async Task<FileStreamResult> ExportTemplateCatsToExcel(string fileName = null)
//        {
//            return ToExcel(ApplyQuery(await service.GetTemplateCats(), Request.Query, false), fileName);
//        }

//        [HttpGet("/export/destinationTest/templates/csv")]
//        [HttpGet("/export/destinationTest/templates/csv(fileName='{fileName}')")]
//        public async Task<FileStreamResult> ExportTemplatesToCSV(string fileName = null)
//        {
//            return ToCSV(ApplyQuery(await service.GetTemplates(), Request.Query, false), fileName);
//        }

//        [HttpGet("/export/destinationTest/templates/excel")]
//        [HttpGet("/export/destinationTest/templates/excel(fileName='{fileName}')")]
//        public async Task<FileStreamResult> ExportTemplatesToExcel(string fileName = null)
//        {
//            return ToExcel(ApplyQuery(await service.GetTemplates(), Request.Query, false), fileName);
//        }

//        [HttpGet("/export/destinationTest/tenants/csv")]
//        [HttpGet("/export/destinationTest/tenants/csv(fileName='{fileName}')")]
//        public async Task<FileStreamResult> ExportTenantsToCSV(string fileName = null)
//        {
//            return ToCSV(ApplyQuery(await service.GetTenants(), Request.Query, false), fileName);
//        }

//        [HttpGet("/export/destinationTest/tenants/excel")]
//        [HttpGet("/export/destinationTest/tenants/excel(fileName='{fileName}')")]
//        public async Task<FileStreamResult> ExportTenantsToExcel(string fileName = null)
//        {
//            return ToExcel(ApplyQuery(await service.GetTenants(), Request.Query, false), fileName);
//        }

//        [HttpGet("/export/destinationTest/tenantcheckinphotos/csv")]
//        [HttpGet("/export/destinationTest/tenantcheckinphotos/csv(fileName='{fileName}')")]
//        public async Task<FileStreamResult> ExportTenantCheckInPhotosToCSV(string fileName = null)
//        {
//            return ToCSV(ApplyQuery(await service.GetTenantCheckInPhotos(), Request.Query, false), fileName);
//        }

//        [HttpGet("/export/destinationTest/tenantcheckinphotos/excel")]
//        [HttpGet("/export/destinationTest/tenantcheckinphotos/excel(fileName='{fileName}')")]
//        public async Task<FileStreamResult> ExportTenantCheckInPhotosToExcel(string fileName = null)
//        {
//            return ToExcel(ApplyQuery(await service.GetTenantCheckInPhotos(), Request.Query, false), fileName);
//        }

//        [HttpGet("/export/destinationTest/tenantinterestdata/csv")]
//        [HttpGet("/export/destinationTest/tenantinterestdata/csv(fileName='{fileName}')")]
//        public async Task<FileStreamResult> ExportTenantInterestDataToCSV(string fileName = null)
//        {
//            return ToCSV(ApplyQuery(await service.GetTenantInterestData(), Request.Query, false), fileName);
//        }

//        [HttpGet("/export/destinationTest/tenantinterestdata/excel")]
//        [HttpGet("/export/destinationTest/tenantinterestdata/excel(fileName='{fileName}')")]
//        public async Task<FileStreamResult> ExportTenantInterestDataToExcel(string fileName = null)
//        {
//            return ToExcel(ApplyQuery(await service.GetTenantInterestData(), Request.Query, false), fileName);
//        }

//        [HttpGet("/export/destinationTest/tenantorderalertemailmessages/csv")]
//        [HttpGet("/export/destinationTest/tenantorderalertemailmessages/csv(fileName='{fileName}')")]
//        public async Task<FileStreamResult> ExportTenantOrderAlertEmailMessagesToCSV(string fileName = null)
//        {
//            return ToCSV(ApplyQuery(await service.GetTenantOrderAlertEmailMessages(), Request.Query, false), fileName);
//        }

//        [HttpGet("/export/destinationTest/tenantorderalertemailmessages/excel")]
//        [HttpGet("/export/destinationTest/tenantorderalertemailmessages/excel(fileName='{fileName}')")]
//        public async Task<FileStreamResult> ExportTenantOrderAlertEmailMessagesToExcel(string fileName = null)
//        {
//            return ToExcel(ApplyQuery(await service.GetTenantOrderAlertEmailMessages(), Request.Query, false), fileName);
//        }

//        [HttpGet("/export/destinationTest/tenantsheets/csv")]
//        [HttpGet("/export/destinationTest/tenantsheets/csv(fileName='{fileName}')")]
//        public async Task<FileStreamResult> ExportTenantSheetsToCSV(string fileName = null)
//        {
//            return ToCSV(ApplyQuery(await service.GetTenantSheets(), Request.Query, false), fileName);
//        }

//        [HttpGet("/export/destinationTest/tenantsheets/excel")]
//        [HttpGet("/export/destinationTest/tenantsheets/excel(fileName='{fileName}')")]
//        public async Task<FileStreamResult> ExportTenantSheetsToExcel(string fileName = null)
//        {
//            return ToExcel(ApplyQuery(await service.GetTenantSheets(), Request.Query, false), fileName);
//        }

//        [HttpGet("/export/destinationTest/tenantwithplusoneincells/csv")]
//        [HttpGet("/export/destinationTest/tenantwithplusoneincells/csv(fileName='{fileName}')")]
//        public async Task<FileStreamResult> ExportTenantWithPlusOneInCellsToCSV(string fileName = null)
//        {
//            return ToCSV(ApplyQuery(await service.GetTenantWithPlusOneInCells(), Request.Query, false), fileName);
//        }

//        [HttpGet("/export/destinationTest/tenantwithplusoneincells/excel")]
//        [HttpGet("/export/destinationTest/tenantwithplusoneincells/excel(fileName='{fileName}')")]
//        public async Task<FileStreamResult> ExportTenantWithPlusOneInCellsToExcel(string fileName = null)
//        {
//            return ToExcel(ApplyQuery(await service.GetTenantWithPlusOneInCells(), Request.Query, false), fileName);
//        }

//        [HttpGet("/export/destinationTest/testtables/csv")]
//        [HttpGet("/export/destinationTest/testtables/csv(fileName='{fileName}')")]
//        public async Task<FileStreamResult> ExportTestTablesToCSV(string fileName = null)
//        {
//            return ToCSV(ApplyQuery(await service.GetTestTables(), Request.Query, false), fileName);
//        }

//        [HttpGet("/export/destinationTest/testtables/excel")]
//        [HttpGet("/export/destinationTest/testtables/excel(fileName='{fileName}')")]
//        public async Task<FileStreamResult> ExportTestTablesToExcel(string fileName = null)
//        {
//            return ToExcel(ApplyQuery(await service.GetTestTables(), Request.Query, false), fileName);
//        }

//        [HttpGet("/export/destinationTest/testtablefordailyroutines/csv")]
//        [HttpGet("/export/destinationTest/testtablefordailyroutines/csv(fileName='{fileName}')")]
//        public async Task<FileStreamResult> ExportTestTableForDailyRoutinesToCSV(string fileName = null)
//        {
//            return ToCSV(ApplyQuery(await service.GetTestTableForDailyRoutines(), Request.Query, false), fileName);
//        }

//        [HttpGet("/export/destinationTest/testtablefordailyroutines/excel")]
//        [HttpGet("/export/destinationTest/testtablefordailyroutines/excel(fileName='{fileName}')")]
//        public async Task<FileStreamResult> ExportTestTableForDailyRoutinesToExcel(string fileName = null)
//        {
//            return ToExcel(ApplyQuery(await service.GetTestTableForDailyRoutines(), Request.Query, false), fileName);
//        }

//        [HttpGet("/export/destinationTest/trackclosedpastbookings/csv")]
//        [HttpGet("/export/destinationTest/trackclosedpastbookings/csv(fileName='{fileName}')")]
//        public async Task<FileStreamResult> ExportTrackClosedPastBookingsToCSV(string fileName = null)
//        {
//            return ToCSV(ApplyQuery(await service.GetTrackClosedPastBookings(), Request.Query, false), fileName);
//        }

//        [HttpGet("/export/destinationTest/trackclosedpastbookings/excel")]
//        [HttpGet("/export/destinationTest/trackclosedpastbookings/excel(fileName='{fileName}')")]
//        public async Task<FileStreamResult> ExportTrackClosedPastBookingsToExcel(string fileName = null)
//        {
//            return ToExcel(ApplyQuery(await service.GetTrackClosedPastBookings(), Request.Query, false), fileName);
//        }

//        [HttpGet("/export/destinationTest/trackedcampaigns/csv")]
//        [HttpGet("/export/destinationTest/trackedcampaigns/csv(fileName='{fileName}')")]
//        public async Task<FileStreamResult> ExportTrackedCampaignsToCSV(string fileName = null)
//        {
//            return ToCSV(ApplyQuery(await service.GetTrackedCampaigns(), Request.Query, false), fileName);
//        }

//        [HttpGet("/export/destinationTest/trackedcampaigns/excel")]
//        [HttpGet("/export/destinationTest/trackedcampaigns/excel(fileName='{fileName}')")]
//        public async Task<FileStreamResult> ExportTrackedCampaignsToExcel(string fileName = null)
//        {
//            return ToExcel(ApplyQuery(await service.GetTrackedCampaigns(), Request.Query, false), fileName);
//        }

//        [HttpGet("/export/destinationTest/trackedusers/csv")]
//        [HttpGet("/export/destinationTest/trackedusers/csv(fileName='{fileName}')")]
//        public async Task<FileStreamResult> ExportTrackedUsersToCSV(string fileName = null)
//        {
//            return ToCSV(ApplyQuery(await service.GetTrackedUsers(), Request.Query, false), fileName);
//        }

//        [HttpGet("/export/destinationTest/trackedusers/excel")]
//        [HttpGet("/export/destinationTest/trackedusers/excel(fileName='{fileName}')")]
//        public async Task<FileStreamResult> ExportTrackedUsersToExcel(string fileName = null)
//        {
//            return ToExcel(ApplyQuery(await service.GetTrackedUsers(), Request.Query, false), fileName);
//        }

//        [HttpGet("/export/destinationTest/trainingscores/csv")]
//        [HttpGet("/export/destinationTest/trainingscores/csv(fileName='{fileName}')")]
//        public async Task<FileStreamResult> ExportTrainingScoresToCSV(string fileName = null)
//        {
//            return ToCSV(ApplyQuery(await service.GetTrainingScores(), Request.Query, false), fileName);
//        }

//        [HttpGet("/export/destinationTest/trainingscores/excel")]
//        [HttpGet("/export/destinationTest/trainingscores/excel(fileName='{fileName}')")]
//        public async Task<FileStreamResult> ExportTrainingScoresToExcel(string fileName = null)
//        {
//            return ToExcel(ApplyQuery(await service.GetTrainingScores(), Request.Query, false), fileName);
//        }

//        [HttpGet("/export/destinationTest/updateratehomes/csv")]
//        [HttpGet("/export/destinationTest/updateratehomes/csv(fileName='{fileName}')")]
//        public async Task<FileStreamResult> ExportUpdateRateHomesToCSV(string fileName = null)
//        {
//            return ToCSV(ApplyQuery(await service.GetUpdateRateHomes(), Request.Query, false), fileName);
//        }

//        [HttpGet("/export/destinationTest/updateratehomes/excel")]
//        [HttpGet("/export/destinationTest/updateratehomes/excel(fileName='{fileName}')")]
//        public async Task<FileStreamResult> ExportUpdateRateHomesToExcel(string fileName = null)
//        {
//            return ToExcel(ApplyQuery(await service.GetUpdateRateHomes(), Request.Query, false), fileName);
//        }

//        [HttpGet("/export/destinationTest/utilities/csv")]
//        [HttpGet("/export/destinationTest/utilities/csv(fileName='{fileName}')")]
//        public async Task<FileStreamResult> ExportUtilitiesToCSV(string fileName = null)
//        {
//            return ToCSV(ApplyQuery(await service.GetUtilities(), Request.Query, false), fileName);
//        }

//        [HttpGet("/export/destinationTest/utilities/excel")]
//        [HttpGet("/export/destinationTest/utilities/excel(fileName='{fileName}')")]
//        public async Task<FileStreamResult> ExportUtilitiesToExcel(string fileName = null)
//        {
//            return ToExcel(ApplyQuery(await service.GetUtilities(), Request.Query, false), fileName);
//        }

//        [HttpGet("/export/destinationTest/uvgetbacktobackcheckinsperdays/csv")]
//        [HttpGet("/export/destinationTest/uvgetbacktobackcheckinsperdays/csv(fileName='{fileName}')")]
//        public async Task<FileStreamResult> ExportUvGetBackToBackCheckInsPerDaysToCSV(string fileName = null)
//        {
//            return ToCSV(ApplyQuery(await service.GetUvGetBackToBackCheckInsPerDays(), Request.Query, true), fileName);
//        }

//        [HttpGet("/export/destinationTest/uvgetbacktobackcheckinsperdays/excel")]
//        [HttpGet("/export/destinationTest/uvgetbacktobackcheckinsperdays/excel(fileName='{fileName}')")]
//        public async Task<FileStreamResult> ExportUvGetBackToBackCheckInsPerDaysToExcel(string fileName = null)
//        {
//            return ToExcel(ApplyQuery(await service.GetUvGetBackToBackCheckInsPerDays(), Request.Query, true), fileName);
//        }

//        [HttpGet("/export/destinationTest/uvgetbookingbacktobackcounts/csv")]
//        [HttpGet("/export/destinationTest/uvgetbookingbacktobackcounts/csv(fileName='{fileName}')")]
//        public async Task<FileStreamResult> ExportUvGetBookingBackToBackCountsToCSV(string fileName = null)
//        {
//            return ToCSV(ApplyQuery(await service.GetUvGetBookingBackToBackCounts(), Request.Query, true), fileName);
//        }

//        [HttpGet("/export/destinationTest/uvgetbookingbacktobackcounts/excel")]
//        [HttpGet("/export/destinationTest/uvgetbookingbacktobackcounts/excel(fileName='{fileName}')")]
//        public async Task<FileStreamResult> ExportUvGetBookingBackToBackCountsToExcel(string fileName = null)
//        {
//            return ToExcel(ApplyQuery(await service.GetUvGetBookingBackToBackCounts(), Request.Query, true), fileName);
//        }

//        [HttpGet("/export/destinationTest/uvgetbookings/csv")]
//        [HttpGet("/export/destinationTest/uvgetbookings/csv(fileName='{fileName}')")]
//        public async Task<FileStreamResult> ExportUvGetBookingsToCSV(string fileName = null)
//        {
//            return ToCSV(ApplyQuery(await service.GetUvGetBookings(), Request.Query, true), fileName);
//        }

//        [HttpGet("/export/destinationTest/uvgetbookings/excel")]
//        [HttpGet("/export/destinationTest/uvgetbookings/excel(fileName='{fileName}')")]
//        public async Task<FileStreamResult> ExportUvGetBookingsToExcel(string fileName = null)
//        {
//            return ToExcel(ApplyQuery(await service.GetUvGetBookings(), Request.Query, true), fileName);
//        }

//        [HttpGet("/export/destinationTest/uvgettotalcheckinsperdays/csv")]
//        [HttpGet("/export/destinationTest/uvgettotalcheckinsperdays/csv(fileName='{fileName}')")]
//        public async Task<FileStreamResult> ExportUvGetTotalCheckInsPerDaysToCSV(string fileName = null)
//        {
//            return ToCSV(ApplyQuery(await service.GetUvGetTotalCheckInsPerDays(), Request.Query, true), fileName);
//        }

//        [HttpGet("/export/destinationTest/uvgettotalcheckinsperdays/excel")]
//        [HttpGet("/export/destinationTest/uvgettotalcheckinsperdays/excel(fileName='{fileName}')")]
//        public async Task<FileStreamResult> ExportUvGetTotalCheckInsPerDaysToExcel(string fileName = null)
//        {
//            return ToExcel(ApplyQuery(await service.GetUvGetTotalCheckInsPerDays(), Request.Query, true), fileName);
//        }

//        [HttpGet("/export/destinationTest/vrecords/csv")]
//        [HttpGet("/export/destinationTest/vrecords/csv(fileName='{fileName}')")]
//        public async Task<FileStreamResult> ExportVRecordsToCSV(string fileName = null)
//        {
//            return ToCSV(ApplyQuery(await service.GetVRecords(), Request.Query, true), fileName);
//        }

//        [HttpGet("/export/destinationTest/vrecords/excel")]
//        [HttpGet("/export/destinationTest/vrecords/excel(fileName='{fileName}')")]
//        public async Task<FileStreamResult> ExportVRecordsToExcel(string fileName = null)
//        {
//            return ToExcel(ApplyQuery(await service.GetVRecords(), Request.Query, true), fileName);
//        }

//        [HttpGet("/export/destinationTest/viewrevenues/csv")]
//        [HttpGet("/export/destinationTest/viewrevenues/csv(fileName='{fileName}')")]
//        public async Task<FileStreamResult> ExportViewRevenuesToCSV(string fileName = null)
//        {
//            return ToCSV(ApplyQuery(await service.GetViewRevenues(), Request.Query, true), fileName);
//        }

//        [HttpGet("/export/destinationTest/viewrevenues/excel")]
//        [HttpGet("/export/destinationTest/viewrevenues/excel(fileName='{fileName}')")]
//        public async Task<FileStreamResult> ExportViewRevenuesToExcel(string fileName = null)
//        {
//            return ToExcel(ApplyQuery(await service.GetViewRevenues(), Request.Query, true), fileName);
//        }

//        [HttpGet("/export/destinationTest/voicemails/csv")]
//        [HttpGet("/export/destinationTest/voicemails/csv(fileName='{fileName}')")]
//        public async Task<FileStreamResult> ExportVoiceMailsToCSV(string fileName = null)
//        {
//            return ToCSV(ApplyQuery(await service.GetVoiceMails(), Request.Query, false), fileName);
//        }

//        [HttpGet("/export/destinationTest/voicemails/excel")]
//        [HttpGet("/export/destinationTest/voicemails/excel(fileName='{fileName}')")]
//        public async Task<FileStreamResult> ExportVoiceMailsToExcel(string fileName = null)
//        {
//            return ToExcel(ApplyQuery(await service.GetVoiceMails(), Request.Query, false), fileName);
//        }

//        [HttpGet("/export/destinationTest/vonagetsheets/csv")]
//        [HttpGet("/export/destinationTest/vonagetsheets/csv(fileName='{fileName}')")]
//        public async Task<FileStreamResult> ExportVonageTsheetsToCSV(string fileName = null)
//        {
//            return ToCSV(ApplyQuery(await service.GetVonageTsheets(), Request.Query, false), fileName);
//        }

//        [HttpGet("/export/destinationTest/vonagetsheets/excel")]
//        [HttpGet("/export/destinationTest/vonagetsheets/excel(fileName='{fileName}')")]
//        public async Task<FileStreamResult> ExportVonageTsheetsToExcel(string fileName = null)
//        {
//            return ToExcel(ApplyQuery(await service.GetVonageTsheets(), Request.Query, false), fileName);
//        }

//        [HttpGet("/export/destinationTest/vrboerrorlogforbookingrequests/csv")]
//        [HttpGet("/export/destinationTest/vrboerrorlogforbookingrequests/csv(fileName='{fileName}')")]
//        public async Task<FileStreamResult> ExportVrboErrorLogForBookingRequestsToCSV(string fileName = null)
//        {
//            return ToCSV(ApplyQuery(await service.GetVrboErrorLogForBookingRequests(), Request.Query, false), fileName);
//        }

//        [HttpGet("/export/destinationTest/vrboerrorlogforbookingrequests/excel")]
//        [HttpGet("/export/destinationTest/vrboerrorlogforbookingrequests/excel(fileName='{fileName}')")]
//        public async Task<FileStreamResult> ExportVrboErrorLogForBookingRequestsToExcel(string fileName = null)
//        {
//            return ToExcel(ApplyQuery(await service.GetVrboErrorLogForBookingRequests(), Request.Query, false), fileName);
//        }

//        [HttpGet("/export/destinationTest/vrboaudits/csv")]
//        [HttpGet("/export/destinationTest/vrboaudits/csv(fileName='{fileName}')")]
//        public async Task<FileStreamResult> ExportVrboauditsToCSV(string fileName = null)
//        {
//            return ToCSV(ApplyQuery(await service.GetVrboaudits(), Request.Query, false), fileName);
//        }

//        [HttpGet("/export/destinationTest/vrboaudits/excel")]
//        [HttpGet("/export/destinationTest/vrboaudits/excel(fileName='{fileName}')")]
//        public async Task<FileStreamResult> ExportVrboauditsToExcel(string fileName = null)
//        {
//            return ToExcel(ApplyQuery(await service.GetVrboaudits(), Request.Query, false), fileName);
//        }

//        [HttpGet("/export/destinationTest/vrboimages/csv")]
//        [HttpGet("/export/destinationTest/vrboimages/csv(fileName='{fileName}')")]
//        public async Task<FileStreamResult> ExportVrboimagesToCSV(string fileName = null)
//        {
//            return ToCSV(ApplyQuery(await service.GetVrboimages(), Request.Query, false), fileName);
//        }

//        [HttpGet("/export/destinationTest/vrboimages/excel")]
//        [HttpGet("/export/destinationTest/vrboimages/excel(fileName='{fileName}')")]
//        public async Task<FileStreamResult> ExportVrboimagesToExcel(string fileName = null)
//        {
//            return ToExcel(ApplyQuery(await service.GetVrboimages(), Request.Query, false), fileName);
//        }

//        [HttpGet("/export/destinationTest/vrboimage1s/csv")]
//        [HttpGet("/export/destinationTest/vrboimage1s/csv(fileName='{fileName}')")]
//        public async Task<FileStreamResult> ExportVrboImage1SToCSV(string fileName = null)
//        {
//            return ToCSV(ApplyQuery(await service.GetVrboImage1S(), Request.Query, false), fileName);
//        }

//        [HttpGet("/export/destinationTest/vrboimage1s/excel")]
//        [HttpGet("/export/destinationTest/vrboimage1s/excel(fileName='{fileName}')")]
//        public async Task<FileStreamResult> ExportVrboImage1SToExcel(string fileName = null)
//        {
//            return ToExcel(ApplyQuery(await service.GetVrboImage1S(), Request.Query, false), fileName);
//        }

//        [HttpGet("/export/destinationTest/vrboimagedetails/csv")]
//        [HttpGet("/export/destinationTest/vrboimagedetails/csv(fileName='{fileName}')")]
//        public async Task<FileStreamResult> ExportVrboimageDetailsToCSV(string fileName = null)
//        {
//            return ToCSV(ApplyQuery(await service.GetVrboimageDetails(), Request.Query, false), fileName);
//        }

//        [HttpGet("/export/destinationTest/vrboimagedetails/excel")]
//        [HttpGet("/export/destinationTest/vrboimagedetails/excel(fileName='{fileName}')")]
//        public async Task<FileStreamResult> ExportVrboimageDetailsToExcel(string fileName = null)
//        {
//            return ToExcel(ApplyQuery(await service.GetVrboimageDetails(), Request.Query, false), fileName);
//        }

//        [HttpGet("/export/destinationTest/vrboimagedetailbackups/csv")]
//        [HttpGet("/export/destinationTest/vrboimagedetailbackups/csv(fileName='{fileName}')")]
//        public async Task<FileStreamResult> ExportVrboImageDetailBackupsToCSV(string fileName = null)
//        {
//            return ToCSV(ApplyQuery(await service.GetVrboImageDetailBackups(), Request.Query, false), fileName);
//        }

//        [HttpGet("/export/destinationTest/vrboimagedetailbackups/excel")]
//        [HttpGet("/export/destinationTest/vrboimagedetailbackups/excel(fileName='{fileName}')")]
//        public async Task<FileStreamResult> ExportVrboImageDetailBackupsToExcel(string fileName = null)
//        {
//            return ToExcel(ApplyQuery(await service.GetVrboImageDetailBackups(), Request.Query, false), fileName);
//        }

//        [HttpGet("/export/destinationTest/vrboproperties/csv")]
//        [HttpGet("/export/destinationTest/vrboproperties/csv(fileName='{fileName}')")]
//        public async Task<FileStreamResult> ExportVrboPropertiesToCSV(string fileName = null)
//        {
//            return ToCSV(ApplyQuery(await service.GetVrboProperties(), Request.Query, false), fileName);
//        }

//        [HttpGet("/export/destinationTest/vrboproperties/excel")]
//        [HttpGet("/export/destinationTest/vrboproperties/excel(fileName='{fileName}')")]
//        public async Task<FileStreamResult> ExportVrboPropertiesToExcel(string fileName = null)
//        {
//            return ToExcel(ApplyQuery(await service.GetVrboProperties(), Request.Query, false), fileName);
//        }

//        [HttpGet("/export/destinationTest/vwcleanedstatuscheckouttodays/csv")]
//        [HttpGet("/export/destinationTest/vwcleanedstatuscheckouttodays/csv(fileName='{fileName}')")]
//        public async Task<FileStreamResult> ExportVwCleanedStatusCheckOutTodaysToCSV(string fileName = null)
//        {
//            return ToCSV(ApplyQuery(await service.GetVwCleanedStatusCheckOutTodays(), Request.Query, true), fileName);
//        }

//        [HttpGet("/export/destinationTest/vwcleanedstatuscheckouttodays/excel")]
//        [HttpGet("/export/destinationTest/vwcleanedstatuscheckouttodays/excel(fileName='{fileName}')")]
//        public async Task<FileStreamResult> ExportVwCleanedStatusCheckOutTodaysToExcel(string fileName = null)
//        {
//            return ToExcel(ApplyQuery(await service.GetVwCleanedStatusCheckOutTodays(), Request.Query, true), fileName);
//        }

//        [HttpGet("/export/destinationTest/vwcurrentlyoccupieds/csv")]
//        [HttpGet("/export/destinationTest/vwcurrentlyoccupieds/csv(fileName='{fileName}')")]
//        public async Task<FileStreamResult> ExportVwCurrentlyOccupiedsToCSV(string fileName = null)
//        {
//            return ToCSV(ApplyQuery(await service.GetVwCurrentlyOccupieds(), Request.Query, true), fileName);
//        }

//        [HttpGet("/export/destinationTest/vwcurrentlyoccupieds/excel")]
//        [HttpGet("/export/destinationTest/vwcurrentlyoccupieds/excel(fileName='{fileName}')")]
//        public async Task<FileStreamResult> ExportVwCurrentlyOccupiedsToExcel(string fileName = null)
//        {
//            return ToExcel(ApplyQuery(await service.GetVwCurrentlyOccupieds(), Request.Query, true), fileName);
//        }

//        [HttpGet("/export/destinationTest/vwfuturebookings/csv")]
//        [HttpGet("/export/destinationTest/vwfuturebookings/csv(fileName='{fileName}')")]
//        public async Task<FileStreamResult> ExportVwFutureBookingsToCSV(string fileName = null)
//        {
//            return ToCSV(ApplyQuery(await service.GetVwFutureBookings(), Request.Query, true), fileName);
//        }

//        [HttpGet("/export/destinationTest/vwfuturebookings/excel")]
//        [HttpGet("/export/destinationTest/vwfuturebookings/excel(fileName='{fileName}')")]
//        public async Task<FileStreamResult> ExportVwFutureBookingsToExcel(string fileName = null)
//        {
//            return ToExcel(ApplyQuery(await service.GetVwFutureBookings(), Request.Query, true), fileName);
//        }

//        [HttpGet("/export/destinationTest/vwgetcommmaxes/csv")]
//        [HttpGet("/export/destinationTest/vwgetcommmaxes/csv(fileName='{fileName}')")]
//        public async Task<FileStreamResult> ExportVwGetCommMaxesToCSV(string fileName = null)
//        {
//            return ToCSV(ApplyQuery(await service.GetVwGetCommMaxes(), Request.Query, true), fileName);
//        }

//        [HttpGet("/export/destinationTest/vwgetcommmaxes/excel")]
//        [HttpGet("/export/destinationTest/vwgetcommmaxes/excel(fileName='{fileName}')")]
//        public async Task<FileStreamResult> ExportVwGetCommMaxesToExcel(string fileName = null)
//        {
//            return ToExcel(ApplyQuery(await service.GetVwGetCommMaxes(), Request.Query, true), fileName);
//        }

//        [HttpGet("/export/destinationTest/vwgetminutedifferences/csv")]
//        [HttpGet("/export/destinationTest/vwgetminutedifferences/csv(fileName='{fileName}')")]
//        public async Task<FileStreamResult> ExportVwGetMinuteDifferencesToCSV(string fileName = null)
//        {
//            return ToCSV(ApplyQuery(await service.GetVwGetMinuteDifferences(), Request.Query, true), fileName);
//        }

//        [HttpGet("/export/destinationTest/vwgetminutedifferences/excel")]
//        [HttpGet("/export/destinationTest/vwgetminutedifferences/excel(fileName='{fileName}')")]
//        public async Task<FileStreamResult> ExportVwGetMinuteDifferencesToExcel(string fileName = null)
//        {
//            return ToExcel(ApplyQuery(await service.GetVwGetMinuteDifferences(), Request.Query, true), fileName);
//        }

//        [HttpGet("/export/destinationTest/vwgettrackedusers/csv")]
//        [HttpGet("/export/destinationTest/vwgettrackedusers/csv(fileName='{fileName}')")]
//        public async Task<FileStreamResult> ExportVwGetTrackedUsersToCSV(string fileName = null)
//        {
//            return ToCSV(ApplyQuery(await service.GetVwGetTrackedUsers(), Request.Query, true), fileName);
//        }

//        [HttpGet("/export/destinationTest/vwgettrackedusers/excel")]
//        [HttpGet("/export/destinationTest/vwgettrackedusers/excel(fileName='{fileName}')")]
//        public async Task<FileStreamResult> ExportVwGetTrackedUsersToExcel(string fileName = null)
//        {
//            return ToExcel(ApplyQuery(await service.GetVwGetTrackedUsers(), Request.Query, true), fileName);
//        }

//        [HttpGet("/export/destinationTest/vwgetairbnbdepositsinfos/csv")]
//        [HttpGet("/export/destinationTest/vwgetairbnbdepositsinfos/csv(fileName='{fileName}')")]
//        public async Task<FileStreamResult> ExportVwGetAirbnbDepositsInfosToCSV(string fileName = null)
//        {
//            return ToCSV(ApplyQuery(await service.GetVwGetAirbnbDepositsInfos(), Request.Query, true), fileName);
//        }

//        [HttpGet("/export/destinationTest/vwgetairbnbdepositsinfos/excel")]
//        [HttpGet("/export/destinationTest/vwgetairbnbdepositsinfos/excel(fileName='{fileName}')")]
//        public async Task<FileStreamResult> ExportVwGetAirbnbDepositsInfosToExcel(string fileName = null)
//        {
//            return ToExcel(ApplyQuery(await service.GetVwGetAirbnbDepositsInfos(), Request.Query, true), fileName);
//        }

//        [HttpGet("/export/destinationTest/vwgetallpropertystatuses/csv")]
//        [HttpGet("/export/destinationTest/vwgetallpropertystatuses/csv(fileName='{fileName}')")]
//        public async Task<FileStreamResult> ExportVwGetAllPropertyStatusesToCSV(string fileName = null)
//        {
//            return ToCSV(ApplyQuery(await service.GetVwGetAllPropertyStatuses(), Request.Query, true), fileName);
//        }

//        [HttpGet("/export/destinationTest/vwgetallpropertystatuses/excel")]
//        [HttpGet("/export/destinationTest/vwgetallpropertystatuses/excel(fileName='{fileName}')")]
//        public async Task<FileStreamResult> ExportVwGetAllPropertyStatusesToExcel(string fileName = null)
//        {
//            return ToExcel(ApplyQuery(await service.GetVwGetAllPropertyStatuses(), Request.Query, true), fileName);
//        }

//        [HttpGet("/export/destinationTest/vwgetclosestbookingwithcleaningstatuses/csv")]
//        [HttpGet("/export/destinationTest/vwgetclosestbookingwithcleaningstatuses/csv(fileName='{fileName}')")]
//        public async Task<FileStreamResult> ExportVwGetClosestBookingWithCleaningStatusesToCSV(string fileName = null)
//        {
//            return ToCSV(ApplyQuery(await service.GetVwGetClosestBookingWithCleaningStatuses(), Request.Query, true), fileName);
//        }

//        [HttpGet("/export/destinationTest/vwgetclosestbookingwithcleaningstatuses/excel")]
//        [HttpGet("/export/destinationTest/vwgetclosestbookingwithcleaningstatuses/excel(fileName='{fileName}')")]
//        public async Task<FileStreamResult> ExportVwGetClosestBookingWithCleaningStatusesToExcel(string fileName = null)
//        {
//            return ToExcel(ApplyQuery(await service.GetVwGetClosestBookingWithCleaningStatuses(), Request.Query, true), fileName);
//        }

//        [HttpGet("/export/destinationTest/vwgetclosestwithcleaners/csv")]
//        [HttpGet("/export/destinationTest/vwgetclosestwithcleaners/csv(fileName='{fileName}')")]
//        public async Task<FileStreamResult> ExportVwGetclosestwithCleanersToCSV(string fileName = null)
//        {
//            return ToCSV(ApplyQuery(await service.GetVwGetclosestwithCleaners(), Request.Query, true), fileName);
//        }

//        [HttpGet("/export/destinationTest/vwgetclosestwithcleaners/excel")]
//        [HttpGet("/export/destinationTest/vwgetclosestwithcleaners/excel(fileName='{fileName}')")]
//        public async Task<FileStreamResult> ExportVwGetclosestwithCleanersToExcel(string fileName = null)
//        {
//            return ToExcel(ApplyQuery(await service.GetVwGetclosestwithCleaners(), Request.Query, true), fileName);
//        }

//        [HttpGet("/export/destinationTest/vwgetclosestwithdates/csv")]
//        [HttpGet("/export/destinationTest/vwgetclosestwithdates/csv(fileName='{fileName}')")]
//        public async Task<FileStreamResult> ExportVwGetclosestwithDatesToCSV(string fileName = null)
//        {
//            return ToCSV(ApplyQuery(await service.GetVwGetclosestwithDates(), Request.Query, true), fileName);
//        }

//        [HttpGet("/export/destinationTest/vwgetclosestwithdates/excel")]
//        [HttpGet("/export/destinationTest/vwgetclosestwithdates/excel(fileName='{fileName}')")]
//        public async Task<FileStreamResult> ExportVwGetclosestwithDatesToExcel(string fileName = null)
//        {
//            return ToExcel(ApplyQuery(await service.GetVwGetclosestwithDates(), Request.Query, true), fileName);
//        }

//        [HttpGet("/export/destinationTest/vwgetcommmaxes1/csv")]
//        [HttpGet("/export/destinationTest/vwgetcommmaxes1/csv(fileName='{fileName}')")]
//        public async Task<FileStreamResult> ExportVwGetCommMaxes1ToCSV(string fileName = null)
//        {
//            return ToCSV(ApplyQuery(await service.GetVwGetCommMaxes1(), Request.Query, true), fileName);
//        }

//        [HttpGet("/export/destinationTest/vwgetcommmaxes1/excel")]
//        [HttpGet("/export/destinationTest/vwgetcommmaxes1/excel(fileName='{fileName}')")]
//        public async Task<FileStreamResult> ExportVwGetCommMaxes1ToExcel(string fileName = null)
//        {
//            return ToExcel(ApplyQuery(await service.GetVwGetCommMaxes1(), Request.Query, true), fileName);
//        }

//        [HttpGet("/export/destinationTest/vwgetdoorcodelogs/csv")]
//        [HttpGet("/export/destinationTest/vwgetdoorcodelogs/csv(fileName='{fileName}')")]
//        public async Task<FileStreamResult> ExportVwGetDoorCodeLogsToCSV(string fileName = null)
//        {
//            return ToCSV(ApplyQuery(await service.GetVwGetDoorCodeLogs(), Request.Query, true), fileName);
//        }

//        [HttpGet("/export/destinationTest/vwgetdoorcodelogs/excel")]
//        [HttpGet("/export/destinationTest/vwgetdoorcodelogs/excel(fileName='{fileName}')")]
//        public async Task<FileStreamResult> ExportVwGetDoorCodeLogsToExcel(string fileName = null)
//        {
//            return ToExcel(ApplyQuery(await service.GetVwGetDoorCodeLogs(), Request.Query, true), fileName);
//        }

//        [HttpGet("/export/destinationTest/vwgetinquirydatesforbookingsdashboardqueries/csv")]
//        [HttpGet("/export/destinationTest/vwgetinquirydatesforbookingsdashboardqueries/csv(fileName='{fileName}')")]
//        public async Task<FileStreamResult> ExportVwGetInquiryDatesForBookingsDashboardQueriesToCSV(string fileName = null)
//        {
//            return ToCSV(ApplyQuery(await service.GetVwGetInquiryDatesForBookingsDashboardQueries(), Request.Query, true), fileName);
//        }

//        [HttpGet("/export/destinationTest/vwgetinquirydatesforbookingsdashboardqueries/excel")]
//        [HttpGet("/export/destinationTest/vwgetinquirydatesforbookingsdashboardqueries/excel(fileName='{fileName}')")]
//        public async Task<FileStreamResult> ExportVwGetInquiryDatesForBookingsDashboardQueriesToExcel(string fileName = null)
//        {
//            return ToExcel(ApplyQuery(await service.GetVwGetInquiryDatesForBookingsDashboardQueries(), Request.Query, true), fileName);
//        }

//        [HttpGet("/export/destinationTest/vwgetinspectiondatemgtforallactiveprops/csv")]
//        [HttpGet("/export/destinationTest/vwgetinspectiondatemgtforallactiveprops/csv(fileName='{fileName}')")]
//        public async Task<FileStreamResult> ExportVwGetInspectionDateMgtForAllActivePropsToCSV(string fileName = null)
//        {
//            return ToCSV(ApplyQuery(await service.GetVwGetInspectionDateMgtForAllActiveProps(), Request.Query, true), fileName);
//        }

//        [HttpGet("/export/destinationTest/vwgetinspectiondatemgtforallactiveprops/excel")]
//        [HttpGet("/export/destinationTest/vwgetinspectiondatemgtforallactiveprops/excel(fileName='{fileName}')")]
//        public async Task<FileStreamResult> ExportVwGetInspectionDateMgtForAllActivePropsToExcel(string fileName = null)
//        {
//            return ToExcel(ApplyQuery(await service.GetVwGetInspectionDateMgtForAllActiveProps(), Request.Query, true), fileName);
//        }

//        [HttpGet("/export/destinationTest/vwgetlast3monthstotals/csv")]
//        [HttpGet("/export/destinationTest/vwgetlast3monthstotals/csv(fileName='{fileName}')")]
//        public async Task<FileStreamResult> ExportVwGetlast3MonthsTotalsToCSV(string fileName = null)
//        {
//            return ToCSV(ApplyQuery(await service.GetVwGetlast3MonthsTotals(), Request.Query, true), fileName);
//        }

//        [HttpGet("/export/destinationTest/vwgetlast3monthstotals/excel")]
//        [HttpGet("/export/destinationTest/vwgetlast3monthstotals/excel(fileName='{fileName}')")]
//        public async Task<FileStreamResult> ExportVwGetlast3MonthsTotalsToExcel(string fileName = null)
//        {
//            return ToExcel(ApplyQuery(await service.GetVwGetlast3MonthsTotals(), Request.Query, true), fileName);
//        }

//        [HttpGet("/export/destinationTest/vwgetlast3monthstotalpies/csv")]
//        [HttpGet("/export/destinationTest/vwgetlast3monthstotalpies/csv(fileName='{fileName}')")]
//        public async Task<FileStreamResult> ExportVwGetlast3MonthsTotalPiesToCSV(string fileName = null)
//        {
//            return ToCSV(ApplyQuery(await service.GetVwGetlast3MonthsTotalPies(), Request.Query, true), fileName);
//        }

//        [HttpGet("/export/destinationTest/vwgetlast3monthstotalpies/excel")]
//        [HttpGet("/export/destinationTest/vwgetlast3monthstotalpies/excel(fileName='{fileName}')")]
//        public async Task<FileStreamResult> ExportVwGetlast3MonthsTotalPiesToExcel(string fileName = null)
//        {
//            return ToExcel(ApplyQuery(await service.GetVwGetlast3MonthsTotalPies(), Request.Query, true), fileName);
//        }

//        [HttpGet("/export/destinationTest/vwgetlast6monthstotals/csv")]
//        [HttpGet("/export/destinationTest/vwgetlast6monthstotals/csv(fileName='{fileName}')")]
//        public async Task<FileStreamResult> ExportVwGetlast6MonthsTotalsToCSV(string fileName = null)
//        {
//            return ToCSV(ApplyQuery(await service.GetVwGetlast6MonthsTotals(), Request.Query, true), fileName);
//        }

//        [HttpGet("/export/destinationTest/vwgetlast6monthstotals/excel")]
//        [HttpGet("/export/destinationTest/vwgetlast6monthstotals/excel(fileName='{fileName}')")]
//        public async Task<FileStreamResult> ExportVwGetlast6MonthsTotalsToExcel(string fileName = null)
//        {
//            return ToExcel(ApplyQuery(await service.GetVwGetlast6MonthsTotals(), Request.Query, true), fileName);
//        }

//        [HttpGet("/export/destinationTest/vwgetlast6monthstotalpies/csv")]
//        [HttpGet("/export/destinationTest/vwgetlast6monthstotalpies/csv(fileName='{fileName}')")]
//        public async Task<FileStreamResult> ExportVwGetlast6MonthsTotalPiesToCSV(string fileName = null)
//        {
//            return ToCSV(ApplyQuery(await service.GetVwGetlast6MonthsTotalPies(), Request.Query, true), fileName);
//        }

//        [HttpGet("/export/destinationTest/vwgetlast6monthstotalpies/excel")]
//        [HttpGet("/export/destinationTest/vwgetlast6monthstotalpies/excel(fileName='{fileName}')")]
//        public async Task<FileStreamResult> ExportVwGetlast6MonthsTotalPiesToExcel(string fileName = null)
//        {
//            return ToExcel(ApplyQuery(await service.GetVwGetlast6MonthsTotalPies(), Request.Query, true), fileName);
//        }

//        [HttpGet("/export/destinationTest/vwgetlastcleaneddateforallactiveprops/csv")]
//        [HttpGet("/export/destinationTest/vwgetlastcleaneddateforallactiveprops/csv(fileName='{fileName}')")]
//        public async Task<FileStreamResult> ExportVwGetLastCleanedDateForAllActivePropsToCSV(string fileName = null)
//        {
//            return ToCSV(ApplyQuery(await service.GetVwGetLastCleanedDateForAllActiveProps(), Request.Query, true), fileName);
//        }

//        [HttpGet("/export/destinationTest/vwgetlastcleaneddateforallactiveprops/excel")]
//        [HttpGet("/export/destinationTest/vwgetlastcleaneddateforallactiveprops/excel(fileName='{fileName}')")]
//        public async Task<FileStreamResult> ExportVwGetLastCleanedDateForAllActivePropsToExcel(string fileName = null)
//        {
//            return ToExcel(ApplyQuery(await service.GetVwGetLastCleanedDateForAllActiveProps(), Request.Query, true), fileName);
//        }

//        [HttpGet("/export/destinationTest/vwgetlastcleaners/csv")]
//        [HttpGet("/export/destinationTest/vwgetlastcleaners/csv(fileName='{fileName}')")]
//        public async Task<FileStreamResult> ExportVwGetLastCleanersToCSV(string fileName = null)
//        {
//            return ToCSV(ApplyQuery(await service.GetVwGetLastCleaners(), Request.Query, true), fileName);
//        }

//        [HttpGet("/export/destinationTest/vwgetlastcleaners/excel")]
//        [HttpGet("/export/destinationTest/vwgetlastcleaners/excel(fileName='{fileName}')")]
//        public async Task<FileStreamResult> ExportVwGetLastCleanersToExcel(string fileName = null)
//        {
//            return ToExcel(ApplyQuery(await service.GetVwGetLastCleaners(), Request.Query, true), fileName);
//        }

//        [HttpGet("/export/destinationTest/vwgetlastdatecompletedfromexpenses/csv")]
//        [HttpGet("/export/destinationTest/vwgetlastdatecompletedfromexpenses/csv(fileName='{fileName}')")]
//        public async Task<FileStreamResult> ExportVwGetLastDateCompletedFromExpensesToCSV(string fileName = null)
//        {
//            return ToCSV(ApplyQuery(await service.GetVwGetLastDateCompletedFromExpenses(), Request.Query, true), fileName);
//        }

//        [HttpGet("/export/destinationTest/vwgetlastdatecompletedfromexpenses/excel")]
//        [HttpGet("/export/destinationTest/vwgetlastdatecompletedfromexpenses/excel(fileName='{fileName}')")]
//        public async Task<FileStreamResult> ExportVwGetLastDateCompletedFromExpensesToExcel(string fileName = null)
//        {
//            return ToExcel(ApplyQuery(await service.GetVwGetLastDateCompletedFromExpenses(), Request.Query, true), fileName);
//        }

//        [HttpGet("/export/destinationTest/vwgetlastinspecteddateforallactiveprops/csv")]
//        [HttpGet("/export/destinationTest/vwgetlastinspecteddateforallactiveprops/csv(fileName='{fileName}')")]
//        public async Task<FileStreamResult> ExportVwGetLastInspectedDateForAllActivePropsToCSV(string fileName = null)
//        {
//            return ToCSV(ApplyQuery(await service.GetVwGetLastInspectedDateForAllActiveProps(), Request.Query, true), fileName);
//        }

//        [HttpGet("/export/destinationTest/vwgetlastinspecteddateforallactiveprops/excel")]
//        [HttpGet("/export/destinationTest/vwgetlastinspecteddateforallactiveprops/excel(fileName='{fileName}')")]
//        public async Task<FileStreamResult> ExportVwGetLastInspectedDateForAllActivePropsToExcel(string fileName = null)
//        {
//            return ToExcel(ApplyQuery(await service.GetVwGetLastInspectedDateForAllActiveProps(), Request.Query, true), fileName);
//        }

//        [HttpGet("/export/destinationTest/vwgetlastratechangeds/csv")]
//        [HttpGet("/export/destinationTest/vwgetlastratechangeds/csv(fileName='{fileName}')")]
//        public async Task<FileStreamResult> ExportVwGetLastRateChangedsToCSV(string fileName = null)
//        {
//            return ToCSV(ApplyQuery(await service.GetVwGetLastRateChangeds(), Request.Query, true), fileName);
//        }

//        [HttpGet("/export/destinationTest/vwgetlastratechangeds/excel")]
//        [HttpGet("/export/destinationTest/vwgetlastratechangeds/excel(fileName='{fileName}')")]
//        public async Task<FileStreamResult> ExportVwGetLastRateChangedsToExcel(string fileName = null)
//        {
//            return ToExcel(ApplyQuery(await service.GetVwGetLastRateChangeds(), Request.Query, true), fileName);
//        }

//        [HttpGet("/export/destinationTest/vwgetlastyeartotals/csv")]
//        [HttpGet("/export/destinationTest/vwgetlastyeartotals/csv(fileName='{fileName}')")]
//        public async Task<FileStreamResult> ExportVwGetlastyearTotalsToCSV(string fileName = null)
//        {
//            return ToCSV(ApplyQuery(await service.GetVwGetlastyearTotals(), Request.Query, true), fileName);
//        }

//        [HttpGet("/export/destinationTest/vwgetlastyeartotals/excel")]
//        [HttpGet("/export/destinationTest/vwgetlastyeartotals/excel(fileName='{fileName}')")]
//        public async Task<FileStreamResult> ExportVwGetlastyearTotalsToExcel(string fileName = null)
//        {
//            return ToExcel(ApplyQuery(await service.GetVwGetlastyearTotals(), Request.Query, true), fileName);
//        }

//        [HttpGet("/export/destinationTest/vwgetlastyeartotalpies/csv")]
//        [HttpGet("/export/destinationTest/vwgetlastyeartotalpies/csv(fileName='{fileName}')")]
//        public async Task<FileStreamResult> ExportVwGetlastyearTotalPiesToCSV(string fileName = null)
//        {
//            return ToCSV(ApplyQuery(await service.GetVwGetlastyearTotalPies(), Request.Query, true), fileName);
//        }

//        [HttpGet("/export/destinationTest/vwgetlastyeartotalpies/excel")]
//        [HttpGet("/export/destinationTest/vwgetlastyeartotalpies/excel(fileName='{fileName}')")]
//        public async Task<FileStreamResult> ExportVwGetlastyearTotalPiesToExcel(string fileName = null)
//        {
//            return ToExcel(ApplyQuery(await service.GetVwGetlastyearTotalPies(), Request.Query, true), fileName);
//        }

//        [HttpGet("/export/destinationTest/vwgetnetsums/csv")]
//        [HttpGet("/export/destinationTest/vwgetnetsums/csv(fileName='{fileName}')")]
//        public async Task<FileStreamResult> ExportVwGetNetSumsToCSV(string fileName = null)
//        {
//            return ToCSV(ApplyQuery(await service.GetVwGetNetSums(), Request.Query, true), fileName);
//        }

//        [HttpGet("/export/destinationTest/vwgetnetsums/excel")]
//        [HttpGet("/export/destinationTest/vwgetnetsums/excel(fileName='{fileName}')")]
//        public async Task<FileStreamResult> ExportVwGetNetSumsToExcel(string fileName = null)
//        {
//            return ToExcel(ApplyQuery(await service.GetVwGetNetSums(), Request.Query, true), fileName);
//        }

//        [HttpGet("/export/destinationTest/vwgetnextbookings/csv")]
//        [HttpGet("/export/destinationTest/vwgetnextbookings/csv(fileName='{fileName}')")]
//        public async Task<FileStreamResult> ExportVwGetNextBookingsToCSV(string fileName = null)
//        {
//            return ToCSV(ApplyQuery(await service.GetVwGetNextBookings(), Request.Query, true), fileName);
//        }

//        [HttpGet("/export/destinationTest/vwgetnextbookings/excel")]
//        [HttpGet("/export/destinationTest/vwgetnextbookings/excel(fileName='{fileName}')")]
//        public async Task<FileStreamResult> ExportVwGetNextBookingsToExcel(string fileName = null)
//        {
//            return ToExcel(ApplyQuery(await service.GetVwGetNextBookings(), Request.Query, true), fileName);
//        }

//        [HttpGet("/export/destinationTest/vwgetnextownerbookings/csv")]
//        [HttpGet("/export/destinationTest/vwgetnextownerbookings/csv(fileName='{fileName}')")]
//        public async Task<FileStreamResult> ExportVwGetNextOwnerBookingsToCSV(string fileName = null)
//        {
//            return ToCSV(ApplyQuery(await service.GetVwGetNextOwnerBookings(), Request.Query, true), fileName);
//        }

//        [HttpGet("/export/destinationTest/vwgetnextownerbookings/excel")]
//        [HttpGet("/export/destinationTest/vwgetnextownerbookings/excel(fileName='{fileName}')")]
//        public async Task<FileStreamResult> ExportVwGetNextOwnerBookingsToExcel(string fileName = null)
//        {
//            return ToExcel(ApplyQuery(await service.GetVwGetNextOwnerBookings(), Request.Query, true), fileName);
//        }

//        [HttpGet("/export/destinationTest/vwgetpropclosestdatewithcleaners/csv")]
//        [HttpGet("/export/destinationTest/vwgetpropclosestdatewithcleaners/csv(fileName='{fileName}')")]
//        public async Task<FileStreamResult> ExportVwGetPropClosestDatewithCleanersToCSV(string fileName = null)
//        {
//            return ToCSV(ApplyQuery(await service.GetVwGetPropClosestDatewithCleaners(), Request.Query, true), fileName);
//        }

//        [HttpGet("/export/destinationTest/vwgetpropclosestdatewithcleaners/excel")]
//        [HttpGet("/export/destinationTest/vwgetpropclosestdatewithcleaners/excel(fileName='{fileName}')")]
//        public async Task<FileStreamResult> ExportVwGetPropClosestDatewithCleanersToExcel(string fileName = null)
//        {
//            return ToExcel(ApplyQuery(await service.GetVwGetPropClosestDatewithCleaners(), Request.Query, true), fileName);
//        }

//        [HttpGet("/export/destinationTest/vwgetpropertieswithoutspaces/csv")]
//        [HttpGet("/export/destinationTest/vwgetpropertieswithoutspaces/csv(fileName='{fileName}')")]
//        public async Task<FileStreamResult> ExportVwGetPropertiesWithoutSpacesToCSV(string fileName = null)
//        {
//            return ToCSV(ApplyQuery(await service.GetVwGetPropertiesWithoutSpaces(), Request.Query, true), fileName);
//        }

//        [HttpGet("/export/destinationTest/vwgetpropertieswithoutspaces/excel")]
//        [HttpGet("/export/destinationTest/vwgetpropertieswithoutspaces/excel(fileName='{fileName}')")]
//        public async Task<FileStreamResult> ExportVwGetPropertiesWithoutSpacesToExcel(string fileName = null)
//        {
//            return ToExcel(ApplyQuery(await service.GetVwGetPropertiesWithoutSpaces(), Request.Query, true), fileName);
//        }

//        [HttpGet("/export/destinationTest/vwgetpropertyexpenses/csv")]
//        [HttpGet("/export/destinationTest/vwgetpropertyexpenses/csv(fileName='{fileName}')")]
//        public async Task<FileStreamResult> ExportVwGetPropertyExpensesToCSV(string fileName = null)
//        {
//            return ToCSV(ApplyQuery(await service.GetVwGetPropertyExpenses(), Request.Query, true), fileName);
//        }

//        [HttpGet("/export/destinationTest/vwgetpropertyexpenses/excel")]
//        [HttpGet("/export/destinationTest/vwgetpropertyexpenses/excel(fileName='{fileName}')")]
//        public async Task<FileStreamResult> ExportVwGetPropertyExpensesToExcel(string fileName = null)
//        {
//            return ToExcel(ApplyQuery(await service.GetVwGetPropertyExpenses(), Request.Query, true), fileName);
//        }

//        [HttpGet("/export/destinationTest/vwgetpropertystatuses/csv")]
//        [HttpGet("/export/destinationTest/vwgetpropertystatuses/csv(fileName='{fileName}')")]
//        public async Task<FileStreamResult> ExportVwGetPropertyStatusesToCSV(string fileName = null)
//        {
//            return ToCSV(ApplyQuery(await service.GetVwGetPropertyStatuses(), Request.Query, true), fileName);
//        }

//        [HttpGet("/export/destinationTest/vwgetpropertystatuses/excel")]
//        [HttpGet("/export/destinationTest/vwgetpropertystatuses/excel(fileName='{fileName}')")]
//        public async Task<FileStreamResult> ExportVwGetPropertyStatusesToExcel(string fileName = null)
//        {
//            return ToExcel(ApplyQuery(await service.GetVwGetPropertyStatuses(), Request.Query, true), fileName);
//        }

//        [HttpGet("/export/destinationTest/vwgetpropertystatusonlymaintenancedepts/csv")]
//        [HttpGet("/export/destinationTest/vwgetpropertystatusonlymaintenancedepts/csv(fileName='{fileName}')")]
//        public async Task<FileStreamResult> ExportVwGetPropertyStatusOnlyMaintenanceDeptsToCSV(string fileName = null)
//        {
//            return ToCSV(ApplyQuery(await service.GetVwGetPropertyStatusOnlyMaintenanceDepts(), Request.Query, true), fileName);
//        }

//        [HttpGet("/export/destinationTest/vwgetpropertystatusonlymaintenancedepts/excel")]
//        [HttpGet("/export/destinationTest/vwgetpropertystatusonlymaintenancedepts/excel(fileName='{fileName}')")]
//        public async Task<FileStreamResult> ExportVwGetPropertyStatusOnlyMaintenanceDeptsToExcel(string fileName = null)
//        {
//            return ToExcel(ApplyQuery(await service.GetVwGetPropertyStatusOnlyMaintenanceDepts(), Request.Query, true), fileName);
//        }

//        [HttpGet("/export/destinationTest/vwgetproplistwithcontrollogs/csv")]
//        [HttpGet("/export/destinationTest/vwgetproplistwithcontrollogs/csv(fileName='{fileName}')")]
//        public async Task<FileStreamResult> ExportVwGetPropListWithControlLogsToCSV(string fileName = null)
//        {
//            return ToCSV(ApplyQuery(await service.GetVwGetPropListWithControlLogs(), Request.Query, true), fileName);
//        }

//        [HttpGet("/export/destinationTest/vwgetproplistwithcontrollogs/excel")]
//        [HttpGet("/export/destinationTest/vwgetproplistwithcontrollogs/excel(fileName='{fileName}')")]
//        public async Task<FileStreamResult> ExportVwGetPropListWithControlLogsToExcel(string fileName = null)
//        {
//            return ToExcel(ApplyQuery(await service.GetVwGetPropListWithControlLogs(), Request.Query, true), fileName);
//        }

//        [HttpGet("/export/destinationTest/vwgetpropreviewcounts/csv")]
//        [HttpGet("/export/destinationTest/vwgetpropreviewcounts/csv(fileName='{fileName}')")]
//        public async Task<FileStreamResult> ExportVwGetPropReviewCountsToCSV(string fileName = null)
//        {
//            return ToCSV(ApplyQuery(await service.GetVwGetPropReviewCounts(), Request.Query, true), fileName);
//        }

//        [HttpGet("/export/destinationTest/vwgetpropreviewcounts/excel")]
//        [HttpGet("/export/destinationTest/vwgetpropreviewcounts/excel(fileName='{fileName}')")]
//        public async Task<FileStreamResult> ExportVwGetPropReviewCountsToExcel(string fileName = null)
//        {
//            return ToExcel(ApplyQuery(await service.GetVwGetPropReviewCounts(), Request.Query, true), fileName);
//        }

//        [HttpGet("/export/destinationTest/vwgetprpertieshotopens/csv")]
//        [HttpGet("/export/destinationTest/vwgetprpertieshotopens/csv(fileName='{fileName}')")]
//        public async Task<FileStreamResult> ExportVwGetPrpertiesHotOpensToCSV(string fileName = null)
//        {
//            return ToCSV(ApplyQuery(await service.GetVwGetPrpertiesHotOpens(), Request.Query, true), fileName);
//        }

//        [HttpGet("/export/destinationTest/vwgetprpertieshotopens/excel")]
//        [HttpGet("/export/destinationTest/vwgetprpertieshotopens/excel(fileName='{fileName}')")]
//        public async Task<FileStreamResult> ExportVwGetPrpertiesHotOpensToExcel(string fileName = null)
//        {
//            return ToExcel(ApplyQuery(await service.GetVwGetPrpertiesHotOpens(), Request.Query, true), fileName);
//        }

//        [HttpGet("/export/destinationTest/vwgetsnapshottotals/csv")]
//        [HttpGet("/export/destinationTest/vwgetsnapshottotals/csv(fileName='{fileName}')")]
//        public async Task<FileStreamResult> ExportVwGetSnapshotTotalsToCSV(string fileName = null)
//        {
//            return ToCSV(ApplyQuery(await service.GetVwGetSnapshotTotals(), Request.Query, true), fileName);
//        }

//        [HttpGet("/export/destinationTest/vwgetsnapshottotals/excel")]
//        [HttpGet("/export/destinationTest/vwgetsnapshottotals/excel(fileName='{fileName}')")]
//        public async Task<FileStreamResult> ExportVwGetSnapshotTotalsToExcel(string fileName = null)
//        {
//            return ToExcel(ApplyQuery(await service.GetVwGetSnapshotTotals(), Request.Query, true), fileName);
//        }

//        [HttpGet("/export/destinationTest/vwgetsnapshottotalpies/csv")]
//        [HttpGet("/export/destinationTest/vwgetsnapshottotalpies/csv(fileName='{fileName}')")]
//        public async Task<FileStreamResult> ExportVwGetSnapshotTotalPiesToCSV(string fileName = null)
//        {
//            return ToCSV(ApplyQuery(await service.GetVwGetSnapshotTotalPies(), Request.Query, true), fileName);
//        }

//        [HttpGet("/export/destinationTest/vwgetsnapshottotalpies/excel")]
//        [HttpGet("/export/destinationTest/vwgetsnapshottotalpies/excel(fileName='{fileName}')")]
//        public async Task<FileStreamResult> ExportVwGetSnapshotTotalPiesToExcel(string fileName = null)
//        {
//            return ToExcel(ApplyQuery(await service.GetVwGetSnapshotTotalPies(), Request.Query, true), fileName);
//        }

//        [HttpGet("/export/destinationTest/vwgettotalbkngsforbookingsdashboardqueries/csv")]
//        [HttpGet("/export/destinationTest/vwgettotalbkngsforbookingsdashboardqueries/csv(fileName='{fileName}')")]
//        public async Task<FileStreamResult> ExportVwGetTotalBkngsForBookingsDashboardQueriesToCSV(string fileName = null)
//        {
//            return ToCSV(ApplyQuery(await service.GetVwGetTotalBkngsForBookingsDashboardQueries(), Request.Query, true), fileName);
//        }

//        [HttpGet("/export/destinationTest/vwgettotalbkngsforbookingsdashboardqueries/excel")]
//        [HttpGet("/export/destinationTest/vwgettotalbkngsforbookingsdashboardqueries/excel(fileName='{fileName}')")]
//        public async Task<FileStreamResult> ExportVwGetTotalBkngsForBookingsDashboardQueriesToExcel(string fileName = null)
//        {
//            return ToExcel(ApplyQuery(await service.GetVwGetTotalBkngsForBookingsDashboardQueries(), Request.Query, true), fileName);
//        }

//        [HttpGet("/export/destinationTest/vwgettotalexpenses/csv")]
//        [HttpGet("/export/destinationTest/vwgettotalexpenses/csv(fileName='{fileName}')")]
//        public async Task<FileStreamResult> ExportVwGetTotalExpensesToCSV(string fileName = null)
//        {
//            return ToCSV(ApplyQuery(await service.GetVwGetTotalExpenses(), Request.Query, true), fileName);
//        }

//        [HttpGet("/export/destinationTest/vwgettotalexpenses/excel")]
//        [HttpGet("/export/destinationTest/vwgettotalexpenses/excel(fileName='{fileName}')")]
//        public async Task<FileStreamResult> ExportVwGetTotalExpensesToExcel(string fileName = null)
//        {
//            return ToExcel(ApplyQuery(await service.GetVwGetTotalExpenses(), Request.Query, true), fileName);
//        }

//        [HttpGet("/export/destinationTest/vwgettotalexpensesonlymaintenancedepts/csv")]
//        [HttpGet("/export/destinationTest/vwgettotalexpensesonlymaintenancedepts/csv(fileName='{fileName}')")]
//        public async Task<FileStreamResult> ExportVwGetTotalExpensesOnlyMaintenanceDeptsToCSV(string fileName = null)
//        {
//            return ToCSV(ApplyQuery(await service.GetVwGetTotalExpensesOnlyMaintenanceDepts(), Request.Query, true), fileName);
//        }

//        [HttpGet("/export/destinationTest/vwgettotalexpensesonlymaintenancedepts/excel")]
//        [HttpGet("/export/destinationTest/vwgettotalexpensesonlymaintenancedepts/excel(fileName='{fileName}')")]
//        public async Task<FileStreamResult> ExportVwGetTotalExpensesOnlyMaintenanceDeptsToExcel(string fileName = null)
//        {
//            return ToExcel(ApplyQuery(await service.GetVwGetTotalExpensesOnlyMaintenanceDepts(), Request.Query, true), fileName);
//        }

//        [HttpGet("/export/destinationTest/vwgettotalexpensesfiltereds/csv")]
//        [HttpGet("/export/destinationTest/vwgettotalexpensesfiltereds/csv(fileName='{fileName}')")]
//        public async Task<FileStreamResult> ExportVwGetTotalExpensesFilteredsToCSV(string fileName = null)
//        {
//            return ToCSV(ApplyQuery(await service.GetVwGetTotalExpensesFiltereds(), Request.Query, true), fileName);
//        }

//        [HttpGet("/export/destinationTest/vwgettotalexpensesfiltereds/excel")]
//        [HttpGet("/export/destinationTest/vwgettotalexpensesfiltereds/excel(fileName='{fileName}')")]
//        public async Task<FileStreamResult> ExportVwGetTotalExpensesFilteredsToExcel(string fileName = null)
//        {
//            return ToExcel(ApplyQuery(await service.GetVwGetTotalExpensesFiltereds(), Request.Query, true), fileName);
//        }

//        [HttpGet("/export/destinationTest/vwgettotalinquiriesforbookingsdashboardqueries/csv")]
//        [HttpGet("/export/destinationTest/vwgettotalinquiriesforbookingsdashboardqueries/csv(fileName='{fileName}')")]
//        public async Task<FileStreamResult> ExportVwGetTotalInquiriesForBookingsDashboardQueriesToCSV(string fileName = null)
//        {
//            return ToCSV(ApplyQuery(await service.GetVwGetTotalInquiriesForBookingsDashboardQueries(), Request.Query, true), fileName);
//        }

//        [HttpGet("/export/destinationTest/vwgettotalinquiriesforbookingsdashboardqueries/excel")]
//        [HttpGet("/export/destinationTest/vwgettotalinquiriesforbookingsdashboardqueries/excel(fileName='{fileName}')")]
//        public async Task<FileStreamResult> ExportVwGetTotalInquiriesForBookingsDashboardQueriesToExcel(string fileName = null)
//        {
//            return ToExcel(ApplyQuery(await service.GetVwGetTotalInquiriesForBookingsDashboardQueries(), Request.Query, true), fileName);
//        }

//        [HttpGet("/export/destinationTest/vwgettrackedusers1/csv")]
//        [HttpGet("/export/destinationTest/vwgettrackedusers1/csv(fileName='{fileName}')")]
//        public async Task<FileStreamResult> ExportVwGetTrackedUsers1ToCSV(string fileName = null)
//        {
//            return ToCSV(ApplyQuery(await service.GetVwGetTrackedUsers1(), Request.Query, true), fileName);
//        }

//        [HttpGet("/export/destinationTest/vwgettrackedusers1/excel")]
//        [HttpGet("/export/destinationTest/vwgettrackedusers1/excel(fileName='{fileName}')")]
//        public async Task<FileStreamResult> ExportVwGetTrackedUsers1ToExcel(string fileName = null)
//        {
//            return ToExcel(ApplyQuery(await service.GetVwGetTrackedUsers1(), Request.Query, true), fileName);
//        }

//        [HttpGet("/export/destinationTest/vwgetuniquetenants/csv")]
//        [HttpGet("/export/destinationTest/vwgetuniquetenants/csv(fileName='{fileName}')")]
//        public async Task<FileStreamResult> ExportVwGetUniqueTenantsToCSV(string fileName = null)
//        {
//            return ToCSV(ApplyQuery(await service.GetVwGetUniqueTenants(), Request.Query, true), fileName);
//        }

//        [HttpGet("/export/destinationTest/vwgetuniquetenants/excel")]
//        [HttpGet("/export/destinationTest/vwgetuniquetenants/excel(fileName='{fileName}')")]
//        public async Task<FileStreamResult> ExportVwGetUniqueTenantsToExcel(string fileName = null)
//        {
//            return ToExcel(ApplyQuery(await service.GetVwGetUniqueTenants(), Request.Query, true), fileName);
//        }

//        [HttpGet("/export/destinationTest/vwgetworkingbookings/csv")]
//        [HttpGet("/export/destinationTest/vwgetworkingbookings/csv(fileName='{fileName}')")]
//        public async Task<FileStreamResult> ExportVwGetWorkingBookingsToCSV(string fileName = null)
//        {
//            return ToCSV(ApplyQuery(await service.GetVwGetWorkingBookings(), Request.Query, true), fileName);
//        }

//        [HttpGet("/export/destinationTest/vwgetworkingbookings/excel")]
//        [HttpGet("/export/destinationTest/vwgetworkingbookings/excel(fileName='{fileName}')")]
//        public async Task<FileStreamResult> ExportVwGetWorkingBookingsToExcel(string fileName = null)
//        {
//            return ToExcel(ApplyQuery(await service.GetVwGetWorkingBookings(), Request.Query, true), fileName);
//        }

//        [HttpGet("/export/destinationTest/vwgetyearwisetotals/csv")]
//        [HttpGet("/export/destinationTest/vwgetyearwisetotals/csv(fileName='{fileName}')")]
//        public async Task<FileStreamResult> ExportVwGetYearWiseTotalsToCSV(string fileName = null)
//        {
//            return ToCSV(ApplyQuery(await service.GetVwGetYearWiseTotals(), Request.Query, true), fileName);
//        }

//        [HttpGet("/export/destinationTest/vwgetyearwisetotals/excel")]
//        [HttpGet("/export/destinationTest/vwgetyearwisetotals/excel(fileName='{fileName}')")]
//        public async Task<FileStreamResult> ExportVwGetYearWiseTotalsToExcel(string fileName = null)
//        {
//            return ToExcel(ApplyQuery(await service.GetVwGetYearWiseTotals(), Request.Query, true), fileName);
//        }

//        [HttpGet("/export/destinationTest/vwlastbookedons/csv")]
//        [HttpGet("/export/destinationTest/vwlastbookedons/csv(fileName='{fileName}')")]
//        public async Task<FileStreamResult> ExportVwLastBookedOnsToCSV(string fileName = null)
//        {
//            return ToCSV(ApplyQuery(await service.GetVwLastBookedOns(), Request.Query, true), fileName);
//        }

//        [HttpGet("/export/destinationTest/vwlastbookedons/excel")]
//        [HttpGet("/export/destinationTest/vwlastbookedons/excel(fileName='{fileName}')")]
//        public async Task<FileStreamResult> ExportVwLastBookedOnsToExcel(string fileName = null)
//        {
//            return ToExcel(ApplyQuery(await service.GetVwLastBookedOns(), Request.Query, true), fileName);
//        }

//        [HttpGet("/export/destinationTest/vwlastdatechangedoflockboxes/csv")]
//        [HttpGet("/export/destinationTest/vwlastdatechangedoflockboxes/csv(fileName='{fileName}')")]
//        public async Task<FileStreamResult> ExportVwLastDateChangedOfLockBoxesToCSV(string fileName = null)
//        {
//            return ToCSV(ApplyQuery(await service.GetVwLastDateChangedOfLockBoxes(), Request.Query, true), fileName);
//        }

//        [HttpGet("/export/destinationTest/vwlastdatechangedoflockboxes/excel")]
//        [HttpGet("/export/destinationTest/vwlastdatechangedoflockboxes/excel(fileName='{fileName}')")]
//        public async Task<FileStreamResult> ExportVwLastDateChangedOfLockBoxesToExcel(string fileName = null)
//        {
//            return ToExcel(ApplyQuery(await service.GetVwLastDateChangedOfLockBoxes(), Request.Query, true), fileName);
//        }

//        [HttpGet("/export/destinationTest/vwlastdoorcodechangedperproperties/csv")]
//        [HttpGet("/export/destinationTest/vwlastdoorcodechangedperproperties/csv(fileName='{fileName}')")]
//        public async Task<FileStreamResult> ExportVwLastDoorCodeChangedPerPropertiesToCSV(string fileName = null)
//        {
//            return ToCSV(ApplyQuery(await service.GetVwLastDoorCodeChangedPerProperties(), Request.Query, true), fileName);
//        }

//        [HttpGet("/export/destinationTest/vwlastdoorcodechangedperproperties/excel")]
//        [HttpGet("/export/destinationTest/vwlastdoorcodechangedperproperties/excel(fileName='{fileName}')")]
//        public async Task<FileStreamResult> ExportVwLastDoorCodeChangedPerPropertiesToExcel(string fileName = null)
//        {
//            return ToExcel(ApplyQuery(await service.GetVwLastDoorCodeChangedPerProperties(), Request.Query, true), fileName);
//        }

//        [HttpGet("/export/destinationTest/vwlastrecordedownercommunications/csv")]
//        [HttpGet("/export/destinationTest/vwlastrecordedownercommunications/csv(fileName='{fileName}')")]
//        public async Task<FileStreamResult> ExportVwLastRecordedOwnerCommunicationsToCSV(string fileName = null)
//        {
//            return ToCSV(ApplyQuery(await service.GetVwLastRecordedOwnerCommunications(), Request.Query, true), fileName);
//        }

//        [HttpGet("/export/destinationTest/vwlastrecordedownercommunications/excel")]
//        [HttpGet("/export/destinationTest/vwlastrecordedownercommunications/excel(fileName='{fileName}')")]
//        public async Task<FileStreamResult> ExportVwLastRecordedOwnerCommunicationsToExcel(string fileName = null)
//        {
//            return ToExcel(ApplyQuery(await service.GetVwLastRecordedOwnerCommunications(), Request.Query, true), fileName);
//        }

//        [HttpGet("/export/destinationTest/vwmaintenancenextdatefroms/csv")]
//        [HttpGet("/export/destinationTest/vwmaintenancenextdatefroms/csv(fileName='{fileName}')")]
//        public async Task<FileStreamResult> ExportVwMaintenanceNextDateFromsToCSV(string fileName = null)
//        {
//            return ToCSV(ApplyQuery(await service.GetVwMaintenanceNextDateFroms(), Request.Query, true), fileName);
//        }

//        [HttpGet("/export/destinationTest/vwmaintenancenextdatefroms/excel")]
//        [HttpGet("/export/destinationTest/vwmaintenancenextdatefroms/excel(fileName='{fileName}')")]
//        public async Task<FileStreamResult> ExportVwMaintenanceNextDateFromsToExcel(string fileName = null)
//        {
//            return ToExcel(ApplyQuery(await service.GetVwMaintenanceNextDateFroms(), Request.Query, true), fileName);
//        }

//        [HttpGet("/export/destinationTest/vwnetpayments/csv")]
//        [HttpGet("/export/destinationTest/vwnetpayments/csv(fileName='{fileName}')")]
//        public async Task<FileStreamResult> ExportVwNetPaymentsToCSV(string fileName = null)
//        {
//            return ToCSV(ApplyQuery(await service.GetVwNetPayments(), Request.Query, true), fileName);
//        }

//        [HttpGet("/export/destinationTest/vwnetpayments/excel")]
//        [HttpGet("/export/destinationTest/vwnetpayments/excel(fileName='{fileName}')")]
//        public async Task<FileStreamResult> ExportVwNetPaymentsToExcel(string fileName = null)
//        {
//            return ToExcel(ApplyQuery(await service.GetVwNetPayments(), Request.Query, true), fileName);
//        }

//        [HttpGet("/export/destinationTest/vwpaymentsummaries/csv")]
//        [HttpGet("/export/destinationTest/vwpaymentsummaries/csv(fileName='{fileName}')")]
//        public async Task<FileStreamResult> ExportVwPaymentSummariesToCSV(string fileName = null)
//        {
//            return ToCSV(ApplyQuery(await service.GetVwPaymentSummaries(), Request.Query, true), fileName);
//        }

//        [HttpGet("/export/destinationTest/vwpaymentsummaries/excel")]
//        [HttpGet("/export/destinationTest/vwpaymentsummaries/excel(fileName='{fileName}')")]
//        public async Task<FileStreamResult> ExportVwPaymentSummariesToExcel(string fileName = null)
//        {
//            return ToExcel(ApplyQuery(await service.GetVwPaymentSummaries(), Request.Query, true), fileName);
//        }

//        [HttpGet("/export/destinationTest/vwpropertyoccupiedstatuses/csv")]
//        [HttpGet("/export/destinationTest/vwpropertyoccupiedstatuses/csv(fileName='{fileName}')")]
//        public async Task<FileStreamResult> ExportVwPropertyOccupiedStatusesToCSV(string fileName = null)
//        {
//            return ToCSV(ApplyQuery(await service.GetVwPropertyOccupiedStatuses(), Request.Query, true), fileName);
//        }

//        [HttpGet("/export/destinationTest/vwpropertyoccupiedstatuses/excel")]
//        [HttpGet("/export/destinationTest/vwpropertyoccupiedstatuses/excel(fileName='{fileName}')")]
//        public async Task<FileStreamResult> ExportVwPropertyOccupiedStatusesToExcel(string fileName = null)
//        {
//            return ToExcel(ApplyQuery(await service.GetVwPropertyOccupiedStatuses(), Request.Query, true), fileName);
//        }

//        [HttpGet("/export/destinationTest/vwrptgetlastcleaneds/csv")]
//        [HttpGet("/export/destinationTest/vwrptgetlastcleaneds/csv(fileName='{fileName}')")]
//        public async Task<FileStreamResult> ExportVwRptGetLastCleanedsToCSV(string fileName = null)
//        {
//            return ToCSV(ApplyQuery(await service.GetVwRptGetLastCleaneds(), Request.Query, true), fileName);
//        }

//        [HttpGet("/export/destinationTest/vwrptgetlastcleaneds/excel")]
//        [HttpGet("/export/destinationTest/vwrptgetlastcleaneds/excel(fileName='{fileName}')")]
//        public async Task<FileStreamResult> ExportVwRptGetLastCleanedsToExcel(string fileName = null)
//        {
//            return ToExcel(ApplyQuery(await service.GetVwRptGetLastCleaneds(), Request.Query, true), fileName);
//        }

//        [HttpGet("/export/destinationTest/vwspringcleanings/csv")]
//        [HttpGet("/export/destinationTest/vwspringcleanings/csv(fileName='{fileName}')")]
//        public async Task<FileStreamResult> ExportVwSpringCleaningsToCSV(string fileName = null)
//        {
//            return ToCSV(ApplyQuery(await service.GetVwSpringCleanings(), Request.Query, true), fileName);
//        }

//        [HttpGet("/export/destinationTest/vwspringcleanings/excel")]
//        [HttpGet("/export/destinationTest/vwspringcleanings/excel(fileName='{fileName}')")]
//        public async Task<FileStreamResult> ExportVwSpringCleaningsToExcel(string fileName = null)
//        {
//            return ToExcel(ApplyQuery(await service.GetVwSpringCleanings(), Request.Query, true), fileName);
//        }

//        [HttpGet("/export/destinationTest/vwsumpropertyexpenses/csv")]
//        [HttpGet("/export/destinationTest/vwsumpropertyexpenses/csv(fileName='{fileName}')")]
//        public async Task<FileStreamResult> ExportVwSumPropertyExpensesToCSV(string fileName = null)
//        {
//            return ToCSV(ApplyQuery(await service.GetVwSumPropertyExpenses(), Request.Query, true), fileName);
//        }

//        [HttpGet("/export/destinationTest/vwsumpropertyexpenses/excel")]
//        [HttpGet("/export/destinationTest/vwsumpropertyexpenses/excel(fileName='{fileName}')")]
//        public async Task<FileStreamResult> ExportVwSumPropertyExpensesToExcel(string fileName = null)
//        {
//            return ToExcel(ApplyQuery(await service.GetVwSumPropertyExpenses(), Request.Query, true), fileName);
//        }

//        [HttpGet("/export/destinationTest/vwtenantcounts/csv")]
//        [HttpGet("/export/destinationTest/vwtenantcounts/csv(fileName='{fileName}')")]
//        public async Task<FileStreamResult> ExportVwTenantCountsToCSV(string fileName = null)
//        {
//            return ToCSV(ApplyQuery(await service.GetVwTenantCounts(), Request.Query, true), fileName);
//        }

//        [HttpGet("/export/destinationTest/vwtenantcounts/excel")]
//        [HttpGet("/export/destinationTest/vwtenantcounts/excel(fileName='{fileName}')")]
//        public async Task<FileStreamResult> ExportVwTenantCountsToExcel(string fileName = null)
//        {
//            return ToExcel(ApplyQuery(await service.GetVwTenantCounts(), Request.Query, true), fileName);
//        }

//        [HttpGet("/export/destinationTest/vwunbalanceds/csv")]
//        [HttpGet("/export/destinationTest/vwunbalanceds/csv(fileName='{fileName}')")]
//        public async Task<FileStreamResult> ExportVwUnbalancedsToCSV(string fileName = null)
//        {
//            return ToCSV(ApplyQuery(await service.GetVwUnbalanceds(), Request.Query, true), fileName);
//        }

//        [HttpGet("/export/destinationTest/vwunbalanceds/excel")]
//        [HttpGet("/export/destinationTest/vwunbalanceds/excel(fileName='{fileName}')")]
//        public async Task<FileStreamResult> ExportVwUnbalancedsToExcel(string fileName = null)
//        {
//            return ToExcel(ApplyQuery(await service.GetVwUnbalanceds(), Request.Query, true), fileName);
//        }

//        [HttpGet("/export/destinationTest/warrranties/csv")]
//        [HttpGet("/export/destinationTest/warrranties/csv(fileName='{fileName}')")]
//        public async Task<FileStreamResult> ExportWarrrantiesToCSV(string fileName = null)
//        {
//            return ToCSV(ApplyQuery(await service.GetWarrranties(), Request.Query, false), fileName);
//        }

//        [HttpGet("/export/destinationTest/warrranties/excel")]
//        [HttpGet("/export/destinationTest/warrranties/excel(fileName='{fileName}')")]
//        public async Task<FileStreamResult> ExportWarrrantiesToExcel(string fileName = null)
//        {
//            return ToExcel(ApplyQuery(await service.GetWarrranties(), Request.Query, false), fileName);
//        }

//        [HttpGet("/export/destinationTest/webpagetemplates/csv")]
//        [HttpGet("/export/destinationTest/webpagetemplates/csv(fileName='{fileName}')")]
//        public async Task<FileStreamResult> ExportWebPageTemplatesToCSV(string fileName = null)
//        {
//            return ToCSV(ApplyQuery(await service.GetWebPageTemplates(), Request.Query, false), fileName);
//        }

//        [HttpGet("/export/destinationTest/webpagetemplates/excel")]
//        [HttpGet("/export/destinationTest/webpagetemplates/excel(fileName='{fileName}')")]
//        public async Task<FileStreamResult> ExportWebPageTemplatesToExcel(string fileName = null)
//        {
//            return ToExcel(ApplyQuery(await service.GetWebPageTemplates(), Request.Query, false), fileName);
//        }

//        [HttpGet("/export/destinationTest/rdzvwget2024bookings/csv")]
//        [HttpGet("/export/destinationTest/rdzvwget2024bookings/csv(fileName='{fileName}')")]
//        public async Task<FileStreamResult> ExportRdzVwGet2024BookingsToCSV(string fileName = null)
//        {
//            return ToCSV(ApplyQuery(await service.GetRdzVwGet2024Bookings(), Request.Query, true), fileName);
//        }

//        [HttpGet("/export/destinationTest/rdzvwget2024bookings/excel")]
//        [HttpGet("/export/destinationTest/rdzvwget2024bookings/excel(fileName='{fileName}')")]
//        public async Task<FileStreamResult> ExportRdzVwGet2024BookingsToExcel(string fileName = null)
//        {
//            return ToExcel(ApplyQuery(await service.GetRdzVwGet2024Bookings(), Request.Query, true), fileName);
//        }
//    }
//}
