using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Destination.Models.destinationTest
{
    [Table("PropertyVisitCount", Schema = "dbo")]
    public partial class PropertyVisitCount
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("ID")]
        public int Id { get; set; }

        public int? PropId { get; set; }

        public Property Property { get; set; }

        public DateTime VisitedOn { get; set; }

        public DateTime? DateFrom { get; set; }

        public DateTime? DateTo { get; set; }

        [Column("IPAddress")]
        public string Ipaddress { get; set; }

        [Column("AffiliateID")]
        public int? AffiliateId { get; set; }
    }
}