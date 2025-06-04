namespace Destination.Shared.DTO
{
    public class BookingHistoryResultDto
    {
        public int IntHistoryId { get; set; }
        public int? IntBookingId { get; set; }
        public DateTime? DtCreated { get; set; }
        public int? IntPropertyId { get; set; }
        public string StrTemplateName { get; set; }

        public DateTime? DateFrom { get; set; }
        public DateTime? DateTo { get; set; }
        public int? Nights { get; set; }
        public double? RentalAmount { get; set; }
        public double? ProcessingFee { get; set; }
        public double? PetFee { get; set; }
        public double? CleaningFee { get; set; }
        public double? GrossAmount { get; set; }
        public double? Tax { get; set; }
        public double? Deposit { get; set; }
        public double? PetDeposit { get; set; }
        public double? Outstanding { get; set; }
        public double? Due { get; set; }

        // From Property table
        public int PropId { get; set; }
        public string Name { get; set; }

        // From BookingHistory
        public int? AgentId { get; set; }
        public int? TenantId { get; set; }

        // From tenant table
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Initials { get; set; }
        public int? Agent { get; set; }
    }

}
