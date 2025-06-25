namespace Destination.Shared.DTO
{
    public class BookingFilterModel
    {
        public int FilterModelId { get; set; }
        public DateTime? DateFrom1 { get; set; }
        public DateTime? DateFrom2 { get; set; }

        public DateTime? DateTo1 { get; set; }
        public DateTime? DateTo2 { get; set; }

        public DateTime? BookedFrom1 { get; set; }
        public DateTime? BookedFrom2 { get; set; }

        public int? PropertyId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int? Status { get; set; }
        public string Phone { get; set; }
        public string RR { get; set; }
        public string CO { get; set; }
        public int Sleeps1 { get; set; }
        public int Sleeps2 { get; set; }
        public int Source { get; set; }
        public string Cleaning { get; set; }
        public string BackToBack { get; set; }
        public string Email { get; set; }
        public string City { get; set; }
    }
    public class QueryParamFilterModel
    {
        public string Source { get; set; }
        public List<string> queryParamStatuses { get; set; }
    }
}