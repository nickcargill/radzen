namespace Destination.Shared.DTO
{
    public class OwnerCommunicationByAgentDTO
    {
        public int Id { get; set; }
        public string Ownercomm { get; set; }
        public int? Ownerid { get; set; }
        public string Type { get; set; }
        public DateTime? Cdate { get; set; }
        public int? Agent { get; set; }
        public string Emailtemplate { get; set; }
        public bool? ActionReq { get; set; }
        public int? AssignedTo { get; set; }
        public string Department { get; set; }
        public int? PropId { get; set; }
        public bool? ShowOnRates { get; set; }
        public bool? OwnerFlag { get; set; }

        // Related tenant data
        public int? TenantId { get; set; }
        public string Initials { get; set; }

        // Related property data
        public string PropertyName { get; set; }
        public int? PptID { get; set; }
    }
}
