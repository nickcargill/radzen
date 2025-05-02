using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Destination.Models.destinationTest
{
    [Table("PinkSheetNotes", Schema = "dbo")]
    public partial class PinkSheetNote
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("ID")]
        public int Id { get; set; }

        [Column("PropID")]
        public int? PropId { get; set; }

        public DateTime? EnteredOn { get; set; }

        public string Notes { get; set; }

        public int? InspectedBy { get; set; }

        [Column("InspectorTenantID")]
        public int? InspectorTenantId { get; set; }
    }
}