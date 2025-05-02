using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Destination.Models.destinationTest
{
    [Table("Property_source", Schema = "dbo")]
    public partial class PropertySource
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("id")]
        public int Id { get; set; }

        public string Source { get; set; }

        [Column("website")]
        public byte[] Website { get; set; }

        public string Phone { get; set; }

        public string Notes { get; set; }

        public ICollection<Booking> Bookings { get; set; }

        public ICollection<FilterDataForBulkSmsMail> FilterDataForBulkSmsMails { get; set; }
    }
}