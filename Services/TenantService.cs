using Destination.Components.Pages.TenantComponents;
using Destination.Data;
using Destination.Models.destinationTest;
using Destination.Shared.DTO;
using DocumentFormat.OpenXml.InkML;
using Microsoft.EntityFrameworkCore;
using Radzen;
using System.Linq;
using System.Linq.Dynamic.Core;
using static Destination.Shared.DTO.AllDropDownValues;
using static Destination.Shared.DTO.MainResponse;

namespace Destination.Services
{
    public class TenantService
    {
        private readonly IDbContextFactory<destinationTestContext> dbContextFactory;

        public TenantService(IDbContextFactory<destinationTestContext> dbContextFactory)
        {
            this.dbContextFactory = dbContextFactory;
        }

        public async Task<Tenant> GetTenantInfoByBookingId(int id)
        {
            using var context = dbContextFactory.CreateDbContext();

            var booking = await context.Bookings.Where(x => x.Id == id).FirstOrDefaultAsync();

            Tenant tenant = null;

            if (booking != null)
            {
                tenant = await context.Tenants.Where(x => x.Tenantid == booking.Tenantid).FirstOrDefaultAsync();
            }

            return tenant;
        }

        public async Task<List<int?>> GetUserRoles()
        {
            using var context = dbContextFactory.CreateDbContext();

            var roles = await context.Tenants
                .Select(t => t.Role)
                .Distinct()
                .ToListAsync();

            return roles;
        }

        public async Task<PagedResult<Tenant>> GetTenantsPagedAsync(Query query, TenantFilterModel? filterModel = null)
        {
            using var context = dbContextFactory.CreateDbContext();

            var items = context.Tenants.AsQueryable();

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
                    filteredItems = filteredItems.Where(b => b.Firstname.Contains(filterModel.FirstName));
                }

                if (!string.IsNullOrWhiteSpace(filterModel.LastName))
                {
                    filteredItems = filteredItems.Where(b => b.Lastname.Contains(filterModel.LastName));
                }

                if (!string.IsNullOrWhiteSpace(filterModel.Phone))
                {
                    filteredItems = filteredItems.Where(b => b.Phone.Contains(filterModel.Phone));
                }

                if (!string.IsNullOrWhiteSpace(filterModel.Email))
                {
                    filteredItems = filteredItems.Where(b => b.Email.Contains(filterModel.Email));
                }

                if (filterModel.Role > 0)
                {
                    filteredItems = filteredItems.Where(b => b.Role == filterModel.Role);
                }
            }

            filteredItems = filteredItems.Where(x => x.Role >= 25);

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

            return new PagedResult<Tenant>
            {
                Items = data,
                Count = count
            };
        }

    }
}
