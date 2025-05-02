using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Destination.Models.destinationTest
{
    [Table("SpaTransactions", Schema = "dbo")]
    public partial class SpaTransaction
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("ID")]
        public int Id { get; set; }

        public int? PropertyCleaner { get; set; }

        public DateTime? DateCleaned { get; set; }

        [Column("PropID")]
        public int? PropId { get; set; }

        [Column("LoginID")]
        public int? LoginId { get; set; }
    }
}