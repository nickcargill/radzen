using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Destination.Models.destinationTest
{
    [Table("InntopiaAudit", Schema = "dbo")]
    public partial class InntopiaAudit
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("ID")]
        public int Id { get; set; }

        [Column("TransactioID")]
        public string TransactioId { get; set; }

        public string RequestStatus { get; set; }

        public DateTime? RequestDateTime { get; set; }

        [Column("RequestURL")]
        public string RequestUrl { get; set; }

        public string RequestFor { get; set; }

        public string RequestBody { get; set; }

        public string RequestResponse { get; set; }

        [Column("GetOTAResponse")]
        public string GetOtaresponse { get; set; }
    }
}