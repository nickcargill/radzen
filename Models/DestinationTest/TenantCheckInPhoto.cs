using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Destination.Models.destinationTest
{
    [Table("TenantCheckInPhotos", Schema = "dbo")]
    public partial class TenantCheckInPhoto
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("ID")]
        public int Id { get; set; }

        [Column("BookingID")]
        public int? BookingId { get; set; }

        [Column("IDType")]
        public string Idtype { get; set; }

        public string FilePath { get; set; }

        public DateTime? UploadedOn { get; set; }
    }
}