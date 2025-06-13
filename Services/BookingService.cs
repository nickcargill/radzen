using Destination.Components.Pages;
using Destination.Data;
using Destination.Models.destinationTest;
using Destination.Shared.DTO;
using DocumentFormat.OpenXml.InkML;
using DocumentFormat.OpenXml.Spreadsheet;
using Microsoft.AspNetCore.Mvc.ApplicationModels;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;
using Radzen;
using System.Linq;
using System.Linq.Dynamic.Core;
using static Destination.Shared.DTO.MainResponse;
using Query = Radzen.Query;

namespace Destination.Services
{
    public class BookingService
    {
        private readonly IDbContextFactory<destinationTestContext> dbContextFactory;

        public BookingService(IDbContextFactory<destinationTestContext> dbContextFactory)
        {
            this.dbContextFactory = dbContextFactory;
        }

        public async Task<PagedResult<Booking>> GetBookingsPagedAsync(Query query, string type, BookingFilterModel? filterModel = null)
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

            if (!string.IsNullOrEmpty(type))
            {
                filteredItems = filteredItems.Where(x => x.BookingStatus.Status == type);
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

            var result = await dbContext.Communications.Where(x=>x.Commid == id).FirstOrDefaultAsync();
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
            var result = await dbContext.Payments.Where(x=>x.IntBookingId == id).ToListAsync();
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
    }
}
