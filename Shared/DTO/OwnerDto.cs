using Destination.Models.destinationTest;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Destination.Shared.DTO
{
    public class OwnerDto
    {
        public int AgId { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string OfficeNumber { get; set; }

        public string Cell { get; set; }

        public string TollFree { get; set; }

        public string Email { get; set; }

        public string Website { get; set; }

        public string Message { get; set; }

        public int? Brokerid { get; set; }

        public string Password { get; set; }

        public string Bio { get; set; }

        public string Photo { get; set; }

        public string Role { get; set; }

        public string Address { get; set; }

        public string City { get; set; }

        public string State { get; set; }

        public int? Zip { get; set; }

        public string Status { get; set; }

        public string Source { get; set; }

        public string PropertyAddress { get; set; }
        public DateTime? Lasttouched { get; set; }
        public DateTime? Touched { get; set; }

        public int? Homerate { get; set; }
        public double? Rate { get; set; }
        public string Familyphoto { get; set; }

        public int? EnteredBy { get; set; }

        public DateTime? EnteredOn { get; set; }

        public string AgentBedrooms { get; set; }

        public string AgentBathrooms { get; set; }
        public int? Newstatus { get; set; }
        public bool? Actionrequired { get; set; }

        public DateTime? DateCreated { get; set; }

    }
}
