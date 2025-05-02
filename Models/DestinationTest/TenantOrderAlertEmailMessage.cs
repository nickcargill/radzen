using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Destination.Models.destinationTest
{
    [Table("TenantOrderAlertEmailMessages", Schema = "dbo")]
    public partial class TenantOrderAlertEmailMessage
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("id")]
        public long Id { get; set; }

        [Column("strType")]
        public string StrType { get; set; }

        [Column("strMessage")]
        public string StrMessage { get; set; }

        [Column("strTemplate")]
        public string StrTemplate { get; set; }

        [Column("dtCreated")]
        public DateTime? DtCreated { get; set; }
    }
}