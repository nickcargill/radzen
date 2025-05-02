using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Destination.Models.destinationTest
{
    [Table("HotHomes", Schema = "dbo")]
    public partial class HotHome
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("id")]
        public int Id { get; set; }

        [Column("PropID")]
        public int? PropId { get; set; }

        public string Why { get; set; }
    }
}