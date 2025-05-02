using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Destination.Models.destinationTest
{
    [Table("ContractTable", Schema = "dbo")]
    public partial class ContractTable
    {
        public DateTime? InsEffDate { get; set; }

        [Column("InsEXPDate")]
        public DateTime? InsExpdate { get; set; }

        public DateTime? InsDateRcvd { get; set; }

        public decimal? PersInjAmt { get; set; }

        public bool? ContractOnFile { get; set; }

        public DateTime? ContDateSigned { get; set; }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("ID")]
        public int Id { get; set; }

        [Column("propid")]
        public int? Propid { get; set; }
    }
}