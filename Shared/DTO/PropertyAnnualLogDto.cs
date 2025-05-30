namespace Destination.Shared.DTO
{
    public class PropertyAnnualLogDto
    {
        public int PropID { get; set; }

        public string Name { get; set; }

        public string TypeName { get; set; }

        public int AnnualTypeID { get; set; }

        public string Notes { get; set; }

        public string LastUpdated { get; set; } // formatted as varchar(10) in the procedure, e.g., "MM/dd/yyyy"

        public int TaskID { get; set; }

        public string OpenClosedStatus { get; set; } // "Open" or "Closed"

        public int ID { get; set; }
    }
}
