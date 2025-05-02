using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Destination.Models.destinationTest
{
    [Table("BookingEmailSettings", Schema = "dbo")]
    public partial class BookingEmailSetting
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("ID")]
        public int Id { get; set; }

        [Column("EmailID")]
        public string EmailId { get; set; }

        public int? BookingsInOneDay { get; set; }

        public int? BookingsInMultipledays { get; set; }

        public int? MultipleDays { get; set; }
    }
}