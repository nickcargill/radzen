using Destination.Components.Pages;
using Destination.Data;
using Destination.Models.destinationTest;
using Destination.Shared.DTO;
using DocumentFormat.OpenXml.InkML;
using DocumentFormat.OpenXml.Spreadsheet;
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

        public async Task<PagedResult<Booking>> GetBookingsPagedAsync(Query query)
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
            using var dbContext = await dbContextFactory.CreateDbContextAsync();
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
