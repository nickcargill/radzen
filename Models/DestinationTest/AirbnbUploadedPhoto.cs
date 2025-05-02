using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Destination.Models.destinationTest
{
    [Table("AirbnbUploadedPhotos", Schema = "dbo")]
    public partial class AirbnbUploadedPhoto
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("ID")]
        public int Id { get; set; }

        [Column("PropID")]
        public int? PropId { get; set; }

        [Column("AirbnbListingID")]
        public long? AirbnbListingId { get; set; }

        [Column("PhotoID")]
        public string PhotoId { get; set; }

        [Column("PhotoURL")]
        public string PhotoUrl { get; set; }
    }
}