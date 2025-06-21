using Destination.Data;
using Destination.Models.destinationTest;
using Destination.Shared.DTO;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;
using Radzen;
using System.Linq;
using System.Linq.Dynamic.Core;
using static Destination.Shared.DTO.MainResponse;

namespace Destination.Services
{
    public class OwnerService
    {
        private readonly IDbContextFactory<destinationTestContext> dbContextFactory;
        public OwnerService(IDbContextFactory<destinationTestContext> dbContextFactory)
        {
            this.dbContextFactory = dbContextFactory;
        }

        public async Task<PagedResult<Agent>> GetownersPagedAsync(Query query, OwnerDto? filterModel = null)
        {
            using var context = dbContextFactory.CreateDbContext();

            var items = context.Agents.AsQueryable();

            // Apply filtering, sorting, skip, and take
            var filteredItems = items;

            if (!string.IsNullOrEmpty(query.Filter))
            {
                filteredItems = filteredItems.Where(query.Filter, query.FilterParameters);
            }

            if (filterModel != null)
            {

                if (!string.IsNullOrWhiteSpace(filterModel.FirstName))
                {
                    filteredItems = filteredItems.Where(b => b.FirstName.Contains(filterModel.FirstName));
                }

                if (!string.IsNullOrWhiteSpace(filterModel.LastName))
                {
                    filteredItems = filteredItems.Where(b => b.LastName.Contains(filterModel.LastName));
                }

                if (!string.IsNullOrWhiteSpace(filterModel.Cell))
                {
                    filteredItems = filteredItems.Where(b => b.Cell.Contains(filterModel.Cell));
                }

                if (!string.IsNullOrWhiteSpace(filterModel.Address))
                {
                    filteredItems = filteredItems.Where(b => b.Address.Contains(filterModel.Address));
                }

                if (!string.IsNullOrWhiteSpace(filterModel.Email))
                {
                    filteredItems = filteredItems.Where(b => b.Email.Contains(filterModel.Email));
                }

                if (!string.IsNullOrWhiteSpace(filterModel.Source))
                {
                    filteredItems = filteredItems.Where(b => b.Source.Contains(filterModel.Source));
                }

                if (filterModel.Newstatus > 0)
                {
                    filteredItems = filteredItems.Where(b => b.Newstatus == filterModel.Newstatus);
                }

                if (filterModel.Touched.HasValue && filterModel.Lasttouched.HasValue)
                {
                    filteredItems = filteredItems.Where(b => b.Touched >= filterModel.Touched.Value && b.Touched <= filterModel.Lasttouched.Value);
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

            return new PagedResult<Agent>
            {
                Items = data,
                Count = count
            };
        }
    }
}
