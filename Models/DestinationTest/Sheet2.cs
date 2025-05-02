using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Destination.Models.destinationTest
{
    [Table("Sheet2", Schema = "dbo")]
    public partial class Sheet2
    {
        [Column("ID")]
        public double? Id { get; set; }

        public string Name { get; set; }

        public string Address { get; set; }

        public string City { get; set; }

        [Column("Zip Code")]
        public double? ZipCode { get; set; }

        [Column("Link to hotel")]
        public string LinkToHotel { get; set; }

        [Column("PropID")]
        public int? PropId { get; set; }
    }
}