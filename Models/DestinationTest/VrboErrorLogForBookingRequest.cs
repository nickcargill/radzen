using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Destination.Models.destinationTest
{
    [Table("VRBO_ErrorLogForBookingRequest", Schema = "dbo")]
    public partial class VrboErrorLogForBookingRequest
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("ID")]
        public int Id { get; set; }

        public string Errormsg { get; set; }

        public DateTime? ErrorTime { get; set; }

        public int? Step { get; set; }

        public string ReqBody { get; set; }
    }
}