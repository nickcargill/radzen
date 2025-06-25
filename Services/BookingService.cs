using Destination.Components.Pages;
using Destination.Data;
using Destination.Models.destinationTest;
using Destination.Shared.DTO;
using DocumentFormat.OpenXml.InkML;
using DocumentFormat.OpenXml.Office2010.Excel;
using DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing;
using DocumentFormat.OpenXml.Spreadsheet;
using Microsoft.AspNetCore.Mvc.ApplicationModels;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Internal;
using Microsoft.IdentityModel.Tokens;
using Radzen;
using System;
using System.Linq;
using System.Linq.Dynamic.Core;
using static Destination.Shared.DTO.MainResponse;
using Query = Radzen.Query;

namespace Destination.Services
{
    public class BookingService
    {
        private readonly IDbContextFactory<destinationTestContext> dbContextFactory;
        //   private readonly SendGridEmailService emailService;

        public BookingService(IDbContextFactory<destinationTestContext> dbContextFactory)//, SendGridEmailService emailService)
        {
            this.dbContextFactory = dbContextFactory;
            //   this.emailService = emailService;
        }

        public async Task<PagedResult<Booking>> GetBookingsPagedAsync(Query query, QueryParamFilterModel? queryParamFilters = null , BookingFilterModel? filterModel = null)
        {
            using var context = dbContextFactory.CreateDbContext();

            var items = context.Bookings
                .Include(i => i.Property)
                .Include(i => i.TblService)
                .Include(i => i.PropertySource)
                .Include(i => i.BookingStatus)
                .Include(i => i.Tenant)
                .AsQueryable();

            // Apply filtering, sorting, skip, and take
            var filteredItems = items;

            if (!string.IsNullOrEmpty(query.Filter))
            {
                filteredItems = filteredItems.Where(query.Filter, query.FilterParameters);
            }

            if (filterModel != null)
            {
                if (filterModel.FilterModelId != 0)
                {
                    filteredItems = filteredItems.Where(b => b.Id == filterModel.FilterModelId);
                }

                if (filterModel.PropertyId.HasValue)
                {
                    filteredItems = filteredItems.Where(b => b.Propertyid == filterModel.PropertyId.Value);
                }

                if (!string.IsNullOrWhiteSpace(filterModel.FirstName))
                {
                    filteredItems = filteredItems.Where(b => b.Tenant.Firstname.Contains(filterModel.FirstName));
                }

                if (!string.IsNullOrWhiteSpace(filterModel.LastName))
                {
                    filteredItems = filteredItems.Where(b => b.Tenant.Lastname.Contains(filterModel.LastName));
                }

                if (!string.IsNullOrWhiteSpace(filterModel.Phone))
                {
                    filteredItems = filteredItems.Where(b => b.Tenant.Phone.Contains(filterModel.Phone));
                }

                if (!string.IsNullOrWhiteSpace(filterModel.Email))
                {
                    filteredItems = filteredItems.Where(b => b.Tenant.Email.Contains(filterModel.Email));
                }

                if (!string.IsNullOrWhiteSpace(filterModel.City))
                {
                    filteredItems = filteredItems.Where(b => b.Property.Bbcity.ToLower() == filterModel.City.ToLower());
                }

                if (filterModel.Status != null && filterModel.Status > 0)
                {
                    filteredItems = filteredItems.Where(b => b.Statusid == filterModel.Status);
                }

                if (filterModel.Sleeps1 != 0 && filterModel.Sleeps2 != 0)
                {
                    filteredItems = filteredItems.Where(b => b.Property.SleepNum > filterModel.Sleeps1 && b.Property.SleepNum < filterModel.Sleeps2);
                }

                if (filterModel.DateFrom1.HasValue && filterModel.DateFrom2.HasValue)
                {
                    filteredItems = filteredItems.Where(b => b.Datefrom >= filterModel.DateFrom1.Value && b.Datefrom <= filterModel.DateFrom2.Value);
                }

                if (filterModel.DateTo1.HasValue && filterModel.DateTo2.HasValue)
                {
                    filteredItems = filteredItems.Where(b => b.Dateto >= filterModel.DateTo1.Value && b.Dateto <= filterModel.DateTo2.Value);
                }

                if (filterModel.BookedFrom1.HasValue && filterModel.BookedFrom2.HasValue)
                {
                    filteredItems = filteredItems.Where(b => b.Bookingdate >= filterModel.BookedFrom1.Value && b.Bookingdate <= filterModel.BookedFrom2.Value);
                }

                if (filterModel.Source != 0)
                {
                    filteredItems = filteredItems.Where(b => b.Sourceid == filterModel.Source);
                }

                // Example: Cleaning filter
                if (!string.IsNullOrWhiteSpace(filterModel.Cleaning) && filterModel.Cleaning != "All")
                {
                    bool cleaningBool = filterModel.Cleaning?.Equals("Cleaned", StringComparison.OrdinalIgnoreCase) == true;
                    filteredItems = filteredItems.Where(b => b.Property.IsCleaned == cleaningBool);
                }
            }     

            if (queryParamFilters != null)
            {
                if (!string.IsNullOrEmpty(queryParamFilters.Source))
                {
                    filteredItems = filteredItems.Where(b => b.PropertySource.Source == queryParamFilters.Source);
                }
                if (queryParamFilters.queryParamStatuses?.Count > 0)
                {
                    if (queryParamFilters.queryParamStatuses.Contains("Crusties"))
                    {
                        var now = DateTime.Now.Date; // Truncate time to midnight (e.g., 2025-06-26 00:00:00.000)
                        var sevenDaysAgo = now.AddDays(-7); // Midnight 7 days ago (e.g., 2025-06-19 00:00:00.000)
                        filteredItems = filteredItems.Where(x => x.BookingStatus != null
                            && x.BookingStatus.Status.ToLower() == "pending"
                            && x.Datefrom >= sevenDaysAgo
                            && x.Datefrom < now);
                    }
                    else
                    {
                        var tempFilteredItems = filteredItems.Take(0); // Empty starting point
                        foreach (var status in queryParamFilters.queryParamStatuses.Where(s => s != null))
                        {
                            var currentStatus = status; // Avoid modified closure
                            tempFilteredItems = tempFilteredItems.Union(
                                filteredItems.Where(b => b.BookingStatus.Status == currentStatus));
                        }
                        filteredItems = tempFilteredItems;
                    }
                }
            }

            var count = await filteredItems.CountAsync();

            if (!string.IsNullOrEmpty(query.OrderBy))
            {
                filteredItems = filteredItems.OrderBy(query.OrderBy);
            }

            if (query.Skip.HasValue)
            {
                filteredItems = filteredItems.Skip(query.Skip.Value);
            }

            if (query.Top.HasValue)
            {
                filteredItems = filteredItems.Take(query.Top.Value);
            }

            var data = await filteredItems.ToListAsync();

            return new PagedResult<Booking>
            {
                Items = data,
                Count = count
            };
        }

        public async Task<List<UserVisitHistoryDto>> GetVisitHistoryByBookingId(int id)
        {
            using var dbContext = await dbContextFactory.CreateDbContextAsync();

            var result = await dbContext.UserVisitHistoryResult
                .FromSqlRaw("EXEC RDZ_proc_getUserVisitHistoryPerBooking @BookingID = {0}", id)
                    .AsNoTracking()
                    .ToListAsync();
            return result;

        }

        public async Task<List<CommunicationHistoryDto>> GetCommHistoryByBookingId(int id)
        {
            using var dbContext = await dbContextFactory.CreateDbContextAsync();

            var result = await dbContext.CommunicationHistoryResult
                .FromSqlRaw("EXEC RDZ_proc_GetCommunicationPerBooking @BookingID = {0}", id)
                    .AsNoTracking()
                    .ToListAsync();
            return result;

        }

        public async Task<List<CommCode>> GetAllCommCodes()
        {
            using var dbContext = await dbContextFactory.CreateDbContextAsync();

            var result = await dbContext.CommCodes.ToListAsync();
            return result;

        }

        public async Task<Communication> GetCommunicationById(int id)
        {
            using var dbContext = await dbContextFactory.CreateDbContextAsync();

            var result = await dbContext.Communications.Where(x => x.Commid == id).FirstOrDefaultAsync();
            return result;

        }

        public async Task<PagedResult<Booking>> GetBookingsByPropId(Query query, int Id)
        {
            using var context = dbContextFactory.CreateDbContext();

            var items = context.Bookings
                .Include(i => i.Property)
                .Include(i => i.TblService)
                .Include(i => i.PropertySource)
                .Include(i => i.BookingStatus)
                .Include(i => i.Tenant)
                .Where(x => x.Propertyid == Id); // Apply filter early

            var filteredItems = items;

            var count = await filteredItems.CountAsync();

            if (!string.IsNullOrEmpty(query.OrderBy))
            {
                filteredItems = filteredItems.OrderBy(query.OrderBy);
            }

            if (query.Skip.HasValue)
            {
                filteredItems = filteredItems.Skip(query.Skip.Value);
            }

            if (query.Top.HasValue)
            {
                filteredItems = filteredItems.Take(query.Top.Value);
            }

            var data = await filteredItems.ToListAsync();

            return new PagedResult<Booking>
            {
                Items = data,
                Count = count
            };
        }

        public async Task<List<Payment>> GetPaymentsByBookingId(int id)
        {
            using var dbContext = await dbContextFactory.CreateDbContextAsync();
            var result = await dbContext.Payments.Where(x => x.IntBookingId == id).ToListAsync();
            return result;
        }

        public async Task<CreditRequest> GetCreditRequestByBookingId(int id)
        {
            using var dbContext = await dbContextFactory.CreateDbContextAsync();
            var result = await dbContext.CreditRequests.Where(x => x.BookingId == id).FirstOrDefaultAsync();
            return result;
        }

        public async Task<List<CreditRequestType>> GetCreditRequestTypes()
        {
            using var dbContext = await dbContextFactory.CreateDbContextAsync();
            var result = await dbContext.CreditRequestTypes.ToListAsync();
            return result;
        }

        public async Task<List<BookingHistoryResultDto>> GetBookingHistoryByBookingId(int id)
        {
            using var dbContext = await dbContextFactory.CreateDbContextAsync();

            var result = await dbContext.BookingHistoryResult
                .FromSqlRaw("EXEC RDZ_proc_GetBookingHistory @BookingID = {0}", id)
                    .AsNoTracking()
                    .ToListAsync();
            return result;
        }

        public async Task<bool> CraeteOrUpdateCommunication(Communication comm, bool isEdit)
        {
            try
            {
                using var context = dbContextFactory.CreateDbContext();
                if (isEdit)
                {
                    context.Communications.Update(comm);
                }
                else
                {
                    context.Communications.Add(comm);
                }

                await context.SaveChangesAsync();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public async Task<bool> CraeteOrUpdateCreditRequests(CreditRequest cr, bool isEdit)
        {
            using var dbContext = await dbContextFactory.CreateDbContextAsync();
            try
            {
                using var context = dbContextFactory.CreateDbContext();
                if (isEdit)
                {
                    context.CreditRequests.Update(cr);
                }
                else
                {
                    context.CreditRequests.Add(cr);
                }

                await context.SaveChangesAsync();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public async Task<Booking> GetBookingsCleanerById(int id)
        {
            using var context = dbContextFactory.CreateDbContext();
            return await context.Bookings.Where(x => x.Id == id).FirstOrDefaultAsync();
        }

        public async Task<Review> GetReviewsByBookingId(int id)
        {
            using var context = dbContextFactory.CreateDbContext();
            return await context.Reviews.Where(x => x.Bookingid == id).FirstOrDefaultAsync();
        }

        public async Task<List<PropertyCleaner>> GetBookingsCleanersAsync()
        {
            using var context = dbContextFactory.CreateDbContext();
            return await context.PropertyCleaners.Where(x => x.Status == "Cleaner").ToListAsync();
        }



















        //    public async Task<(bool Success, string ErrorMessage, BookingUpdateResult Result)> UpdateBookingAsync(
        //    int id, int propertyId, DateTime dateFrom, DateTime dateTo, int statusId, int nights,
        //    decimal rentalAmount, decimal rate, string checkInTime, string checkOutTime,
        //    decimal damageWaiver, int? previousStatusId = null, int? previousPropertyId = null)
        //    {
        //        using var context = dbContextFactory.CreateDbContext();

        //        // Fetch booking logic (replacing BookingLogic.GetBookingsLogic)
        //        var bookingsLogic = await context.BookingsLogics.ToListAsync(); // Assumes BookingLogic is an EF entity

        //        // Validate booking
        //        int validationResult = await FetchStatusAsync(id, propertyId, dateFrom, dateTo, statusId, nights);
        //        if (validationResult <= 0)
        //        {
        //            return (false, validationResult == -1 ? "A Booking for the same date and property already exists." : "Please enter valid number of nights.", null);
        //        }

        //        // Validate booking rules
        //        string errorMessage = await ValidateBookingRulesAsync(bookingsLogic, dateFrom, dateTo, propertyId, statusId, nights, rentalAmount, rate);
        //        if (!string.IsNullOrEmpty(errorMessage))
        //        {
        //            return (false, errorMessage, null);
        //        }

        //        // Calculate rates and related data
        //        var rateResult = await CalculateRatesAsync(propertyId, dateFrom, dateTo, nights);
        //        decimal roomRate = rateResult.RoomRate;
        //        decimal discountRate = rateResult.DiscountRate;
        //        decimal totalRate = rateResult.TotalRate;
        //        decimal deposit = rateResult.Deposit;
        //        decimal cleaningFee = rateResult.CleaningFee;

        //        // Send last-minute warning email if needed
        //        if ((statusId == 1 || statusId == 4) && (statusId != previousStatusId || propertyId != previousPropertyId))
        //        {
        //            int days = (dateFrom - DateTime.Today).Days;
        //            if (days <= 2 && days > 0)
        //            {
        //                await SendLastMinuteEmailAsync(id, propertyId, dateFrom, dateTo, nights, checkInTime, checkOutTime);
        //            }
        //        }

        //        // Update booking in database (example, adjust based on your model)
        //        var booking = await context.Bookings.FindAsync(id);
        //        if (booking != null)
        //        {
        //            booking.Propertyid = propertyId;
        //            booking.Datefrom = dateFrom;
        //            booking.Dateto = dateTo;
        //            booking.Statusid = statusId;
        //            booking.Nights = nights;
        //            booking.Rentalamount = Convert.ToDouble(rentalAmount);
        //            booking.Rentalamount = Convert.ToDouble(roomRate);
        //            booking.DamageWaiver = Convert.ToDouble(damageWaiver);
        //            await context.SaveChangesAsync();
        //        }

        //        return (true, null, new BookingUpdateResult
        //        {
        //            RoomRate = roomRate,
        //            TotalRate = totalRate,
        //            DiscountRate = discountRate,
        //            Deposit = deposit,
        //            CleaningFee = cleaningFee
        //        });
        //    }

        //    private async Task<int> FetchStatusAsync(int id, int propertyId, DateTime dateFrom, DateTime dateTo, int statusId, int nights)
        //    {
        //        using var context = dbContextFactory.CreateDbContext();

        //        var result = await context.Database
        //            .SqlQueryRaw<int>(
        //                "EXEC Proc_CheckBooking @Id = @p0, @PropertyId = @p1, @datefrom = @p2, @dateto = @p3, @statusid = @p4, @intnights = @p5",
        //                id, propertyId, dateFrom, dateTo, statusId, nights
        //            )
        //            .SingleOrDefaultAsync();

        //        return result;
        //    }

        //    private async Task<string> ValidateBookingRulesAsync(List<BookingsLogic> bookingsLogic, DateTime dateFrom, DateTime dateTo, int propertyId, int statusId, int nights, decimal rentalAmount, decimal rate)
        //    {
        //        foreach (var rule in bookingsLogic)
        //        {
        //            if (rule.DtDateFrom1 <= dateFrom && dateFrom <= rule.DtDateFrom2)
        //            {
        //                if (statusId == 1 || statusId == 2)
        //                {
        //                    if (rule.IntPropId == 415 || rule.IntPropId == propertyId)
        //                    {
        //                        if (rule.Type.Equals("nights", StringComparison.OrdinalIgnoreCase))
        //                        {
        //                            if (rule.Condition.Equals("greater", StringComparison.OrdinalIgnoreCase) && nights < rule.IntNights)
        //                            {
        //                                return rule.Description;
        //                            }
        //                            if (rule.Condition.Equals("less", StringComparison.OrdinalIgnoreCase) && nights > rule.IntNights)
        //                            {
        //                                return rule.Description;
        //                            }
        //                            if (rule.Condition.Equals("equal", StringComparison.OrdinalIgnoreCase) && nights != rule.IntNights)
        //                            {
        //                                return rule.Description;
        //                            }
        //                        }
        //                        else if (rule.Type.Equals("rate", StringComparison.OrdinalIgnoreCase))
        //                        {
        //                            decimal calc = rate * rule.MinRatePercentage.Value / 100;
        //                            if (rentalAmount < calc)
        //                            {
        //                                return rule.Description;
        //                            }
        //                        }
        //                    }
        //                }
        //            }
        //        }
        //        return null;
        //    }

        //    private async Task<RateCalculationResult> CalculateRatesAsync(int propertyId, DateTime dateFrom, DateTime dateTo, int nights)
        //    {
        //        using var context = dbContextFactory.CreateDbContext();

        //        // Fetch property details
        //        var property = await context.Properties
        //            .Where(p => p.Propid == propertyId)
        //            .Select(p => new { p.Deposit, p.Cleaningfee })
        //            .FirstOrDefaultAsync();

        //        decimal cleaningFee = Convert.ToDecimal(property?.Cleaningfee);
        //        decimal deposit = Convert.ToDecimal(property?.Deposit);

        //        // Calculate cleaning fee with variance
        //        cleaningFee = await CalculateWithVarianceAsync(propertyId, cleaningFee, dateFrom);

        //        // Fetch rates
        //        var rates = await context.EventDates
        //            .Where(ed =>
        //                (ed.StartDate >= dateFrom && ed.StartDate <= dateTo) ||
        //                (ed.EndDate >= dateFrom && ed.EndDate <= dateTo) ||
        //                (dateFrom >= ed.StartDate && dateFrom <= ed.EndDate) ||
        //                (dateTo >= ed.StartDate && dateTo <= ed.EndDate)
        //            )
        //            .OrderByDescending(ed => ed.SpecialEvent)
        //            .ToListAsync();

        //        double totalRate = 0.0;
        //        double discountRate = 0.0;
        //        double publishedRate = 0.0;
        //        DateTime currentDay = dateFrom;

        //        while (currentDay < dateTo.AddDays(1))
        //        {
        //            foreach (var rate in rates)
        //            {
        //                if (currentDay >= rate.StartDate && currentDay <= rate.EndDate)
        //                {
        //                    bool isWeekend = IsWeekend(currentDay, dateFrom, dateTo);
        //                    bool isWeekendRate = rate.Event.Contains("Weekend", StringComparison.OrdinalIgnoreCase);

        //                    if ((rate.SpecialEvent || (isWeekend && isWeekendRate) || (!isWeekend && !isWeekendRate)))
        //                    {
        //                        double rateValue = await GetRateAsync(propertyId, rate.Event);
        //                        publishedRate += rateValue;
        //                        totalRate += rateValue;

        //                        double percentOff = await GetDiscountsAsync(propertyId, dateFrom);
        //                        if (percentOff > 0)
        //                        {
        //                            discountRate = totalRate - (totalRate * percentOff / 100);
        //                        }
        //                        break;
        //                    }
        //                }
        //            }
        //            currentDay = currentDay.AddDays(1);
        //        }

        //        // Apply multi-day discount
        //        double multiDisc = await GetMultiDayDiscountAsync(nights, dateFrom.ToString("d"), dateTo.ToString("d"), propertyId);
        //        if (multiDisc > 0 && discountRate == 0)
        //        {
        //            totalRate -= totalRate * multiDisc / 100;
        //        }
        //        else if (multiDisc > 0)
        //        {
        //            discountRate -= discountRate * multiDisc / 100;
        //        }

        //        double roomRate = discountRate > 0 ? discountRate : totalRate;
        //        totalRate = (Convert.ToDouble(cleaningFee) + totalRate + 30) * 1.105;
        //        discountRate = discountRate > 0 ? (Convert.ToDouble(cleaningFee) + discountRate + 30) * 1.105 : 0;

        //        return new RateCalculationResult
        //        {
        //            RoomRate = (decimal)roomRate,
        //            TotalRate = (decimal)totalRate,
        //            DiscountRate = (decimal)discountRate,
        //            Deposit = deposit,
        //            CleaningFee = cleaningFee
        //        };
        //    }

        //    private async Task<decimal> CalculateWithVarianceAsync(int propertyId, decimal charges, DateTime checkDate)
        //    {
        //        using var context = dbContextFactory.CreateDbContext();

        //        var result = await context.Database
        //            .SqlQueryRaw<decimal>(
        //                "EXEC proc_CalculateWithVariance @propid = @p0, @charges = @p1, @checkdate = @p2",
        //                propertyId, charges, checkDate
        //            )
        //            .FirstOrDefaultAsync();

        //        return result;
        //    }


        //    private async Task<double> GetRateAsync(int propertyId, string eventName)
        //    {
        //        using var context = dbContextFactory.CreateDbContext();
        //        var rate = await context.DailyRatesBasedOnPropertyRates.Where(x => x.PropId == propertyId).Select(f => f.Rate).FirstOrDefaultAsync();
        //        return Convert.ToDouble(rate);
        //    }

        //    private async Task<double> GetDiscountsAsync(int propertyId, DateTime date)
        //    {
        //        using var context = dbContextFactory.CreateDbContext();

        //        var result = await context.Database
        //            .SqlQueryRaw<double>(
        //                "EXEC Proc_GetDiscounts @propid = @p0, @date = @p1",
        //                propertyId, date
        //            )
        //            .FirstOrDefaultAsync();

        //        return result;
        //    }


        //    private async Task<double> GetMultiDayDiscountAsync(int nights, string firstNight, string lastNight, int propertyId)
        //    {
        //        using var context = dbContextFactory.CreateDbContext();

        //        var result = await context.Database
        //            .SqlQueryRaw<double>(
        //                "EXEC Proc_GetMultiDayDiscount @nights = @p0, @firstNight = @p1, @lastNight = @p2, @propertyId = @p3",
        //                nights, firstNight, lastNight, propertyId
        //            )
        //            .FirstOrDefaultAsync();

        //        return result;
        //    }


        //    private bool IsWeekend(DateTime currentDay, DateTime firstNight, DateTime lastNight)
        //    {
        //        if ((firstNight.DayOfWeek == DayOfWeek.Thursday && lastNight.DayOfWeek == DayOfWeek.Friday) ||
        //            (firstNight.DayOfWeek == DayOfWeek.Friday && lastNight.DayOfWeek == DayOfWeek.Saturday) ||
        //            (lastNight.DayOfWeek == DayOfWeek.Friday && currentDay.DayOfWeek == DayOfWeek.Thursday) ||
        //            (firstNight.DayOfWeek == DayOfWeek.Saturday && lastNight.DayOfWeek == DayOfWeek.Sunday) ||
        //            (firstNight.DayOfWeek == DayOfWeek.Saturday && currentDay.DayOfWeek == DayOfWeek.Sunday) ||
        //            (currentDay.DayOfWeek == DayOfWeek.Friday || currentDay.DayOfWeek == DayOfWeek.Saturday))
        //        {
        //            return true;
        //        }
        //        return false;
        //    }

        //    private async Task SendLastMinuteEmailAsync(int id, int propertyId, DateTime dateFrom, DateTime dateTo, int nights, string checkInTime, string checkOutTime)
        //    {
        //        using var context = dbContextFactory.CreateDbContext();

        //        // Fetch email template
        //        var template = await context.Templates
        //            .Where(t => t.IntTemplateId == 41)
        //            .FirstOrDefaultAsync();

        //        //if (template == null) return;

        //        // Fetch property details
        //        var propDetails = await context.Properties.Include(x => x.PropertyCleaner)
        //                .Where(p => p.Propid == propertyId)
        //                .Select(p => new { p.Address, p.Spa, p.PropertyCleaner.Email })
        //                .FirstOrDefaultAsync();

        //        string content = template.StrTemplateContent;
        //        string subject = template.StrSubject.Replace("[id]", id.ToString());
        //        string propertyName = (await context.Properties.FindAsync(propertyId))?.Name ?? "";
        //        DateTime checkout = dateTo.AddDays(1);

        //        // Replace placeholders
        //        content = content
        //            .Replace("[Name]", propertyName)
        //            .Replace("[datefrom]", dateFrom.ToShortDateString())
        //            .Replace("[nights]", nights.ToString())
        //            .Replace("[checkout]", checkout.ToShortDateString())
        //            .Replace("[checkintime]", checkInTime)
        //            .Replace("[checkouttime]", checkOutTime)
        //            .Replace("[id]", id.ToString())
        //            .Replace("[address]", propDetails?.Address ?? "");

        //        // Send emails based on spa status
        //        var recipients = new List<string> { "operations@destinationbigbear.com", "nickcargill@yahoo.com" };
        //        if (propDetails?.Spa == true)
        //        {
        //            recipients.Add(propDetails.Email);
        //        }
        //        else
        //        {
        //            recipients.Add("destinationbigbear@gmail.com");
        //        }

        //        foreach (var recipient in recipients)
        //        {
        //           // await emailService.SendEmailAsync(recipient, subject, content);
        //        }
        //    }



        //    // second method start here.

        //    public async Task<int> GetSavedStatusAsync(int id)
        //    {
        //        using var context = dbContextFactory.CreateDbContext();
        //        var statusId = await context.Bookings
        //            .Where(b => b.Id == id)
        //            .Select(b => b.Statusid)
        //            .FirstOrDefaultAsync();
        //        return statusId.Value;
        //    }


        //    // Third Method will be update 



        //    // Last method is below


        //    public async Task<(bool Success, string ErrorMessage)> AfterUpdateBookingAsync(
        //        int bookingId, int propertyId, DateTime dateFrom, DateTime dateTo, int statusId,
        //        decimal deposit, decimal damageWaiver, decimal dueNow, string listBox3Value,
        //        int previousPropertyId, DateTime previousDateFrom, DateTime previousDateTo,
        //        int? agentId = null, string previousStatus = null, bool isScrap = false)
        //    {
        //        using var context = dbContextFactory.CreateDbContext();
        //        try
        //        {
        //            // Calculate damage waiver
        //            if (listBox3Value != "15" && listBox3Value != "29")
        //            {
        //                await CalculateDamageWaiverAsync(bookingId, deposit == 0 ? 1 : 0);
        //            }

        //            // Clear and set back-to-back statuses
        //            await ClearBackToBackAsync(previousPropertyId, previousDateFrom, previousDateTo, statusId);
        //            await ClearBackToBackAsync(propertyId, dateFrom, dateTo, statusId);
        //            if (previousPropertyId != propertyId)
        //            {
        //                await ClearBitAsync(bookingId);
        //            }
        //            await SetBackToBackAsync(propertyId, dateFrom, dateTo, statusId);

        //            // Handle deposit and damage waiver calculation
        //            int isWaiverCalculate = 0;
        //            int collectedAmount = 0;
        //            var propertyDeposit = await GetPropertyDepositByIdAsync(propertyId);
        //            if (propertyDeposit != null)
        //            {
        //                if (propertyDeposit.IsDamageWaiver.Value)
        //                {
        //                    isWaiverCalculate = 1;
        //                    collectedAmount = propertyDeposit.CollectedAmount.Value;
        //                }
        //                else if (deposit == 0)
        //                {
        //                    isWaiverCalculate = 1;
        //                    collectedAmount = 50;
        //                }
        //            }
        //            else if (deposit == 0)
        //            {
        //                isWaiverCalculate = 1;
        //                collectedAmount = 50;
        //            }

        //            // Update payment and booking details
        //            await UpdateOnlinePaymentDueNowAsync(bookingId, dueNow.ToString());
        //            await UpdateBookingDateAsync(bookingId);
        //            await UpdateOutstandingAsync(bookingId);

        //            // Log status change if applicable
        //            if (!string.IsNullOrEmpty(previousStatus) && previousStatus != "Empty" && previousStatus != statusId.ToString())
        //            {
        //                var statusName = (await context.BookingStatuses.FindAsync(statusId))?.Status ?? statusId.ToString();
        //                await UpdateBookingAfterFollowMailsNewAsync(
        //                    bookingId.ToString(),
        //                    commCode: "",
        //                    agentId ?? 0,
        //                    $"Booking Status Updated To: {statusName}",
        //                    actionRequired: 0,
        //                    assigned: 0);
        //            }

        //            // Handle redirect for scraping (return flag for caller to handle navigation)
        //            if (isScrap)
        //            {
        //                return (true, "Redirect to Scrapping.aspx");
        //            }

        //            return (true, null);
        //        }
        //        catch (Exception ex)
        //        {
        //            return (false, $"Error during post-update processing: {ex.Message}");
        //        }
        //    }

        //    private async Task<int> CalculateDamageWaiverAsync(int bookingId, int isWaiverCalculate)
        //    {
        //        using var context = dbContextFactory.CreateDbContext();

        //        var result = await context.Database
        //            .SqlQueryRaw<int>(
        //                "EXEC proc_UpdateDamageWaiver @BookingId = @p0, @IsWaiverCalculate = @p1",
        //                bookingId, isWaiverCalculate
        //            )
        //            .SingleOrDefaultAsync();

        //        return result;
        //    }



        //    private async Task<int> ClearBackToBackAsync(int propertyId, DateTime dateFrom, DateTime dateTo, int statusId)
        //    {
        //        using var context = dbContextFactory.CreateDbContext();

        //        var result = await context.Database
        //            .SqlQueryRaw<int>(
        //                "EXEC Proc_ClearBacktoBackStatus @PropertyId = @p0, @datefrom = @p1, @dateto = @p2, @statusid = @p3",
        //                propertyId, dateFrom, dateTo, statusId
        //            )
        //            .SingleOrDefaultAsync();

        //        return result;
        //    }


        //    // ClearBitAsync
        //    private async Task<int> ClearBitAsync(int bookingId)
        //    {
        //        using var context = dbContextFactory.CreateDbContext();

        //        var result = await context.Database
        //            .SqlQueryRaw<int>(
        //                "EXEC Proc_ClearBit @id = @p0", bookingId
        //            )
        //            .SingleOrDefaultAsync();

        //        return result;
        //    }

        //    // SetBackToBackAsync
        //    private async Task<int> SetBackToBackAsync(int propertyId, DateTime dateFrom, DateTime dateTo, int statusId)
        //    {
        //        using var context = dbContextFactory.CreateDbContext();

        //        var result = await context.Database
        //            .SqlQueryRaw<int>(
        //                "EXEC Proc_SetBacktoBackStatus @PropertyId = @p0, @datefrom = @p1, @dateto = @p2, @statusid = @p3",
        //                propertyId, dateFrom, dateTo, statusId
        //            )
        //            .SingleOrDefaultAsync();

        //        return result;
        //    }


        //    private async Task<PropertyDeposit> GetPropertyDepositByIdAsync(int propertyId)
        //    {
        //        using var context = dbContextFactory.CreateDbContext();
        //        var result = await context.PropertyDeposits.Where(x => x.PropId == propertyId).FirstOrDefaultAsync();
        //        return result;
        //    }

        //    private async Task UpdateOnlinePaymentDueNowAsync(int bookingId, string dueNow)
        //    {
        //        using var context = dbContextFactory.CreateDbContext();

        //        dueNow = string.IsNullOrEmpty(dueNow) ? "0" : dueNow;

        //        await context.Database.ExecuteSqlRawAsync(
        //            "EXEC proc_UpdateOnlinePaymentDueNow @BookingID = @p0, @DueNow = @p1",
        //            bookingId, dueNow
        //        );
        //    }


        //    // UpdateBookingDateAsync
        //    private async Task<int> UpdateBookingDateAsync(int bookingId)
        //    {
        //        using var context = dbContextFactory.CreateDbContext();

        //        var result = await context.Database
        //            .SqlQueryRaw<int>(
        //                "EXEC proc_UpdateBookingDate @BookingId = @p0",
        //                bookingId
        //            )
        //            .SingleOrDefaultAsync();

        //        return result;
        //    }


        //    // UpdateOutstandingAsync
        //    private async Task<int> UpdateOutstandingAsync(int bookingId)
        //    {
        //        using var context = dbContextFactory.CreateDbContext();

        //        var result = await context.Database
        //            .SqlQueryRaw<int>(
        //                "EXEC Proc_UpdateOutstanding @id = @p0",
        //                bookingId
        //            )
        //            .SingleOrDefaultAsync();

        //        return result;
        //    }


        //    private async Task<int> UpdateBookingAfterFollowMailsNewAsync(string bookingId, string commCode, int agent, string communicationText, int actionRequired, int assigned)
        //    {
        //        using var context = dbContextFactory.CreateDbContext();

        //        var result = await context.Database
        //            .SqlQueryRaw<int>(
        //                "EXEC Proc_UpdateBookingAfterFollowSMSNew @id = @p0, @commCode = @p1, @agent = @p2, @CommunicationText = @p3, @ActionRequired = @p4, @assigned = @p5",
        //                bookingId, commCode, agent, communicationText, actionRequired, assigned
        //            )
        //            .SingleOrDefaultAsync();

        //        return result;
        //    }

        //}

        //// Supporting classes
        //public class BookingUpdateResult
        //{
        //    public decimal RoomRate { get; set; }
        //    public decimal TotalRate { get; set; }
        //    public decimal DiscountRate { get; set; }
        //    public decimal Deposit { get; set; }
        //    public decimal CleaningFee { get; set; }
        //}

        //public class RateCalculationResult
        //{
        //    public decimal RoomRate { get; set; }
        //    public decimal TotalRate { get; set; }
        //    public decimal DiscountRate { get; set; }
        //    public decimal Deposit { get; set; }
        //    public decimal CleaningFee { get; set; }
        //}
    }
}


