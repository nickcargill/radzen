using Destination.Data;
using DocumentFormat.OpenXml.InkML;
using Microsoft.EntityFrameworkCore;

namespace Destination.Services
{
    public class BookingService
    {
        private readonly IDbContextFactory<destinationTestContext> dbContextFactory;

        public BookingService(IDbContextFactory<destinationTestContext> dbContextFactory)
        {
            this.dbContextFactory = dbContextFactory;
        }

        public async Task<List<Destination.Models.destinationTest.Booking>> GetBookings()
        {
            using var context = dbContextFactory.CreateDbContext(); // New instance per call
            var items = await context.Bookings.Where(x => x.Datefrom >= DateTime.Parse("06-06-2024")).Include(x => x.Property)
                .Include(i => i.TblService).Include(i => i.PropertySource)
                .Include(i => i.BookingStatus).Include(i => i.Tenant).ToListAsync();

            return items;
        }
    }
}
