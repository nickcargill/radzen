using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Destination.Models.destinationTest
{
    [Table("paypal", Schema = "onefournine")]
    public partial class OnefourninePaypal
    {
        [Column("partner")]
        public string Partner { get; set; }

        [Column("login")]
        public string Login { get; set; }

        [Column("type")]
        public string Type { get; set; }

        [Key]
        [Column("di")]
        [Required]
        public int Di { get; set; }
    }
}