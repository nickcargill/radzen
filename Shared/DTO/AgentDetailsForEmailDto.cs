namespace Destination.Shared.DTO
{
    public class AgentDetailsForEmailDto
    {
        public int AgID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string OfficeNumber { get; set; }
        public string Cell { get; set; }
        public string TollFree { get; set; }
        public string Email { get; set; }
        public string Website { get; set; }
        public string Message { get; set; }
        public int BrokerId { get; set; }
        public string Password { get; set; }
        public string Bio { get; set; }
        public string Photo { get; set; }
        public string Role { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public int Zip { get; set; }
        public string Status { get; set; }
        public string Source { get; set; }
        public string PropertyAddress { get; set; }
        public string LastTouched { get; set; } // VARCHAR(50) in SP
        public string Touched { get; set; }     // VARCHAR(50) in SP
        public int HomeRate { get; set; }
        public double Rate { get; set; }
        public string FamilyPhoto { get; set; }

        // Template & communication fields
        public string StrSubject { get; set; }
        public string Code { get; set; }
        public string StrTemplateContent { get; set; }
        public string StrTopContent { get; set; }
        public string StrBottomContent { get; set; }
        public bool StrCheck { get; set; }
        public string StrFrom { get; set; }
        public bool IsActionRequired { get; set; }
    }
}
