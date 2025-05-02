using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Destination.Models.destinationTest
{
    [Table("Agent", Schema = "dbo")]
    public partial class Agent
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("AgID")]
        public int AgId { get; set; }

        [Column("First_Name")]
        public string FirstName { get; set; }

        [Column("Last_Name")]
        public string LastName { get; set; }

        [Column("Office_Number")]
        public string OfficeNumber { get; set; }

        public string Cell { get; set; }

        [Column("Toll_Free")]
        public string TollFree { get; set; }

        [Column("email")]
        public string Email { get; set; }

        [Column("website")]
        public string Website { get; set; }

        [Column("message")]
        public string Message { get; set; }

        [Column("brokerid")]
        public int? Brokerid { get; set; }

        [Column("password")]
        public string Password { get; set; }

        [Column("bio")]
        public string Bio { get; set; }

        [Column("photo")]
        public string Photo { get; set; }

        public string Role { get; set; }

        [Column("address")]
        public string Address { get; set; }

        [Column("city")]
        public string City { get; set; }

        [Column("state")]
        public string State { get; set; }

        [Column("zip")]
        public int? Zip { get; set; }

        [Column("status")]
        public string Status { get; set; }

        public string Source { get; set; }

        public string PropertyAddress { get; set; }

        [Column("lasttouched")]
        public DateTime? Lasttouched { get; set; }

        [Column("touched")]
        public DateTime? Touched { get; set; }

        public int? Homerate { get; set; }

        [Column("rate")]
        public double? Rate { get; set; }

        [Column("familyphoto")]
        public string Familyphoto { get; set; }

        public int? EnteredBy { get; set; }

        public DateTime? EnteredOn { get; set; }

        public string AgentBedrooms { get; set; }

        public string AgentBathrooms { get; set; }

        [Column("newstatus")]
        public int? Newstatus { get; set; }

        [Column("actionrequired")]
        public bool? Actionrequired { get; set; }

        public DateTime? DateCreated { get; set; }

        public ICollection<OwnerCommunication> OwnerCommunications { get; set; }

        public ICollection<Property> Properties { get; set; }
    }
}