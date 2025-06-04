namespace Destination.Shared.DTO
{
    public class CommunicationHistoryDto
    {
        public int Commid { get; set; }

        public int? BookingID { get; set; }

        public DateTime? CommDate { get; set; }

        public string CommDesc { get; set; }

        public string CommText { get; set; }
    }

}
