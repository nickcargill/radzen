using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Destination.Models.destinationTest
{
    [Table("PropertyFulltime", Schema = "dbo")]
    public partial class PropertyFulltime
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("ID")]
        public int Id { get; set; }

        [Column("PropID")]
        public int? PropId { get; set; }

        public string Rents { get; set; }

        public DateTime? When { get; set; }

        public string Communication { get; set; }
    }
}