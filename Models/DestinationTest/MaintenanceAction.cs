using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Destination.Models.destinationTest
{
    [Table("MaintenanceAction", Schema = "dbo")]
    public partial class MaintenanceAction
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("intMaintenanceActionId")]
        public int IntMaintenanceActionId { get; set; }

        [Column("intAgentId")]
        public int? IntAgentId { get; set; }

        [Column("intCleanerId")]
        public int? IntCleanerId { get; set; }

        [Column("intPropExpId")]
        public int? IntPropExpId { get; set; }

        [Column("strMemoField")]
        public string StrMemoField { get; set; }

        [Column("dtCreated")]
        public DateTime? DtCreated { get; set; }

        public string EmailTemplate { get; set; }

        public bool? IsReviewed { get; set; }

        public bool? IsOwnerResponse { get; set; }
    }
}