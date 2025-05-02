using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Destination.Models.destinationTest
{
    [Table("InspectionPlan", Schema = "dbo")]
    public partial class InspectionPlan
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("ID")]
        public int Id { get; set; }

        [Column("URL")]
        public string Url { get; set; }

        [Column("InspectorID")]
        public int? InspectorId { get; set; }

        public DateTime EnteredDate { get; set; }

        public string Phone { get; set; }
    }
}