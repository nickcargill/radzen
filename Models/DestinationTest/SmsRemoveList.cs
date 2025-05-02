using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Destination.Models.destinationTest
{
    [Table("SmsRemoveList", Schema = "dbo")]
    public partial class SmsRemoveList
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("id")]
        public int Id { get; set; }

        [Column("removedate")]
        public DateTime? Removedate { get; set; }

        public string Phone { get; set; }

        public string ByMeans { get; set; }

        [Column("TenantID")]
        public int? TenantId { get; set; }
    }
}