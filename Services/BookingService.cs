using Destination.Data;
using Destination.Models.destinationTest;
using DocumentFormat.OpenXml.InkML;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;
using Radzen;
using System.Linq;
using System.Linq.Dynamic.Core;

namespace Destination.Services
{
    public class BookingService
    {
        private readonly IDbContextFactory<destinationTestContext> dbContextFactory;

        public BookingService(IDbContextFactory<destinationTestContext> dbContextFactory)
        {
            this.dbContextFactory = dbContextFactory;
        }

        //public async Task<List<Destination.Models.destinationTest.Booking>> GetBookings()
        //{

        //    var fromDate = new DateTime(2024, 6, 6);

        //    using var context = dbContextFactory.CreateDbContext(); // New instance per call
        //    var query = context.Bookings
        //        .Where(x => x.Datefrom >= fromDate)
        //        .Include(x => x.Property)
        //        .Include(i => i.TblService)
        //        .Include(i => i.PropertySource)
        //        .Include(i => i.BookingStatus)
        //        .Include(i => i.Tenant);
        //    return await query.ToListAsync();
        //}

        public async Task<List<Destination.Models.destinationTest.Booking>> GetBookings(Query query = null)
        {
            using var context = dbContextFactory.CreateDbContext();

            var items = context.Bookings
                .Include(i => i.Property)
                .Include(i => i.TblService)
                .Include(i => i.PropertySource)
                .Include(i => i.BookingStatus)
                .Include(i => i.Tenant)
                .AsQueryable();

            if (query != null)
            {
                if (!string.IsNullOrEmpty(query.Expand))
                {
                    var propertiesToExpand = query.Expand.Split(',');
                    foreach (var p in propertiesToExpand)
                    {
                        items = items.Include(p.Trim()); // Don't combine with .Where
                    }

                    items = items.Where(x => x.Datefrom >= new DateTime(2024, 5, 5));
                }

                ApplyQuery(ref items, query);
            }

            return await items.ToListAsync(); // Materialize the query here
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


        public class PagedResult<T>
        {
            public List<T> Items { get; set; }
            public int Count { get; set; }
        }


        public void ApplyQuery<T>(ref IQueryable<T> items, Query query = null)
        {
            if (query != null)
            {
                if (!string.IsNullOrEmpty(query.Filter))
                {
                    if (query.FilterParameters != null)
                    {
                        items = items.Where(query.Filter, query.FilterParameters);
                    }
                    else
                    {
                        items = items.Where(query.Filter);
                    }
                }

                if (!string.IsNullOrEmpty(query.OrderBy))
                {
                    items = items.OrderBy(query.OrderBy);
                }

                if (query.Skip.HasValue)
                {
                    items = items.Skip(query.Skip.Value);
                }

                if (query.Top.HasValue)
                {
                    items = items.Take(query.Top.Value);
                }
            }
        }
    }
}
