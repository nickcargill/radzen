using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Destination.Models.destinationTest
{
    [Table("AirbnbAPIReservations_JSON", Schema = "dbo")]
    public partial class AirbnbApireservationsJson
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("ID")]
        public int Id { get; set; }

        public string JsonObject { get; set; }

        public DateTime? InsertedOn { get; set; }

        public string CaseText { get; set; }

        public string JsonText { get; set; }
    }
}