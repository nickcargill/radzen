namespace Destination.Shared.DTO
{
    public static class AllDropDownValues
    {
        public class PropertyDropDownData
        {
            public int Propid { get; set; }
            public string Name { get; set; }
        }

        public class BookingStatusDropDownData
        {
            public int Id { get; set; }
            public string Status { get; set; }
        }

        public class TenantDropDownData
        {
            public int Tenantid { get; set; }
            public string FirstName { get; set; }
        }
    }
}
