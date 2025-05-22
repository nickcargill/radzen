using Destination.Data;
using Destination.Models.destinationTest;
using Microsoft.EntityFrameworkCore;
using Radzen;
using System.Linq.Dynamic.Core;
using static Destination.Shared.DTO.MainResponse;

namespace Destination.Services
{
    public class PropertyService
    {
        private readonly IDbContextFactory<destinationTestContext> dbContextFactory;

        public PropertyService(IDbContextFactory<destinationTestContext> dbContextFactory)
        {
            this.dbContextFactory = dbContextFactory;
        }

        public async Task<PagedResult<Property>> GetPropertiesPagedAsync(Query query)
        {
            using var context = dbContextFactory.CreateDbContext();

            var items = context.Properties
                .Include(i => i.Agent)
                .Include(i => i.PropertyCleaner)
                .Include(i => i.Status1)
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

            var data = await filteredItems.Where(x => x.Name !=null).ToListAsync();

            return new PagedResult<Property>
            {
                Items = data,
                Count = count
            };
        }
    }
}
