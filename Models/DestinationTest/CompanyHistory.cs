using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Destination.Models.destinationTest
{
    [Table("CompanyHistory", Schema = "dbo")]
    public partial class CompanyHistory
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("id")]
        public int Id { get; set; }

        [Column("historydate")]
        public DateTime? Historydate { get; set; }

        public string Recap { get; set; }
    }
}