using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Destination.Models.destinationTest
{
    [Table("InntopiaBookings", Schema = "dbo")]
    public partial class InntopiaBooking
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("ID")]
        public int Id { get; set; }

        [Column("BookingID")]
        public int? BookingId { get; set; }

        [Column("IntopiaID")]
        public string IntopiaId { get; set; }

        [Column("PropID")]
        public int? PropId { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string Email { get; set; }

        public string PhoneNumber { get; set; }

        public string Address { get; set; }

        public string City { get; set; }

        public string PostalCode { get; set; }

        public string State { get; set; }

        public string Country { get; set; }

        public DateTime? CheckInDate { get; set; }

        public DateTime? CheckOutDate { get; set; }

        public decimal? AmountBeforeTax { get; set; }

        public decimal? AmountAfterTax { get; set; }

        public int? BookingType { get; set; }

        public bool? IsConfirmed { get; set; }

        public bool? IsProcessed { get; set; }

        public DateTime? EnteredOn { get; set; }

        public int? NumberOfAdults { get; set; }

        public int? NumberOfChildren { get; set; }

        public DateTime? ModifiedOn { get; set; }
    }
}