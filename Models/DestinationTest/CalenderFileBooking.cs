using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Destination.Models.destinationTest
{
    [Table("CalenderFileBookings", Schema = "dbo")]
    public partial class CalenderFileBooking
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("ID")]
        public int Id { get; set; }

        public int? PropId { get; set; }

        [Column("ICalPath")]
        public string IcalPath { get; set; }

        public string Name { get; set; }
    }
}