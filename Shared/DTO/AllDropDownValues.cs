namespace Destination.Shared.DTO
{
    public static class AllDropDownValues
    {
        public class PropertyDropDownData
        {
            public int? Propid { get; set; }
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

        public class AgentDropDownValues
        {
            public int? AgID { get; set; }
            public string Name { get; set; }
        }

        public class AgentStatusDropDownValues
        {
            public int? StatusId { get; set; }
            public string StatusName { get; set; }
        }

        public class PropertyTypeDropDownValues
        {
            public int? TypeId { get; set; }
            public string Type { get; set; }
        }

        public class PropertyCleanerDDValues
        {
            public int? CleanerId { get; set; }
            public string Name { get; set; }
        }

        public class OwnerLoginDDValues
        {
            public int? TenantId { get; set; }
            public string OwnerName { get; set; }
        }
    }
}
