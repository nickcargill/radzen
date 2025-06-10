using Destination.Components.Pages.TenantComponents;
using Destination.Data;
using Destination.Models.destinationTest;
using Microsoft.EntityFrameworkCore;
using static Destination.Shared.DTO.AllDropDownValues;

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

    }
}
