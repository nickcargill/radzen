using Destination.Data;
using Destination.Models.destinationTest;
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
    }
}
