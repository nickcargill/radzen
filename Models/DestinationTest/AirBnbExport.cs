using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Destination.Models.destinationTest
{
    [Table("AirBnbExports", Schema = "dbo")]
    public partial class AirBnbExport
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("ID")]
        public int Id { get; set; }

        public string ConfirmationCode { get; set; }

        public string Status { get; set; }

        public string Guestname { get; set; }

        public string Contact { get; set; }

        public int? NumberOfAdults { get; set; }

        public int? NumberOfChildren { get; set; }

        public int? NumberOfInfants { get; set; }

        public DateTime? Startdate { get; set; }

        public DateTime? Enddate { get; set; }

        public int? NumberOfNights { get; set; }

        public DateTime? Booked { get; set; }

        public string Listing { get; set; }

        public decimal? Earnings { get; set; }
    }
}