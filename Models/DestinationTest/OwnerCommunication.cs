using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Destination.Models.destinationTest
{
    [Table("Owner_communication", Schema = "dbo")]
    public partial class OwnerCommunication
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("id")]
        public int Id { get; set; }

        [Column("ownercomm")]
        public string Ownercomm { get; set; }

        [Column("ownerid")]
        public int? Ownerid { get; set; }

        public Agent Agent1 { get; set; }

        [Column("type")]
        public string Type { get; set; }

        [Column("cdate")]
        public DateTime? Cdate { get; set; }

        [Column("agent")]
        public int? Agent { get; set; }

        public string Emailtemplate { get; set; }

        public bool? ActionReq { get; set; }

        public int? AssignedTo { get; set; }

        public string Department { get; set; }

        [Column("PropID")]
        public int? PropId { get; set; }

        public bool? ShowOnRates { get; set; }

        public bool? OwnerFlag { get; set; }
    }
}