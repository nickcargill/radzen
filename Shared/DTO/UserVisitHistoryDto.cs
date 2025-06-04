namespace Destination.Shared.DTO
{
    public class UserVisitHistoryDto
    {
        public int ID { get; set; }

        public int? BookingID { get; set; }

        public int? TenantID { get; set; }

        public DateTime? VisitedOn { get; set; }

        public int? PropID { get; set; }

        public DateTime? FromDate { get; set; }

        public DateTime? ToDate { get; set; }

        public string PageUrl { get; set; }

        // From Property table
        public string Name { get; set; }
        public int? Property_propid { get; set; }

        // From Bookings table
        public int? Bookings_id { get; set; }
        public double? RentalAmount { get; set; }
    }

}
