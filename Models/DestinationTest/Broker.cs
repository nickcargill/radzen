using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Destination.Models.destinationTest
{
    [Table("Broker", Schema = "dbo")]
    public partial class Broker
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("BID")]
        public int Bid { get; set; }

        public string Name { get; set; }

        public string Address { get; set; }

        [Column("city")]
        public string City { get; set; }

        [Column("zip")]
        public string Zip { get; set; }

        [Column("main_number")]
        public string MainNumber { get; set; }

        [Column("website")]
        public string Website { get; set; }

        [Column("email")]
        public string Email { get; set; }
    }
}