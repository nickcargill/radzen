using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Destination.Models.destinationTest
{
    [Table("AgreementHistory", Schema = "dbo")]
    public partial class AgreementHistory
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Required]
        public int BookingId { get; set; }

        public Booking Booking { get; set; }

        public int? ContentId { get; set; }

        public string ContentText { get; set; }

        public DateTime CreatedDate { get; set; }

        public bool? IsSendOffer { get; set; }

        public bool? IsNewsletter { get; set; }

        public bool? IsPropertyWarning { get; set; }
    }
}