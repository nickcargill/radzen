namespace Destination.Shared.DTO
{
    public class SmsOwnerRecordDto
    {
        public int? Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Cell { get; set; }

        public string Name { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string Zip { get; set; }
        public string PropHeadlines { get; set; }
        public string Bedrooms { get; set; }
        public string Baths { get; set; }

        public string StrSubject { get; set; }
        public string Code { get; set; }
        public string Content { get; set; }
        public string StrTopContent { get; set; }
        public string StrBottomContent { get; set; }
        public string StrFrom { get; set; }
        public int? PropId { get; set; }
    }
}
