using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Destination.Models.destinationTest
{
    [Table("vw_unbalanced", Schema = "dbo")]
    public partial class VwUnbalanced
    {
        public double? NetPayments { get; set; }

        public double? DueNow { get; set; }

        public double? Expr2 { get; set; }

        public decimal? Expr3 { get; set; }

        public decimal? Expr6 { get; set; }

        public double? Outstanding { get; set; }

        [Column("OweToUS")]
        public decimal? OweToUs { get; set; }

        public double? CompFee { get; set; }

        [Column("datefrom")]
        public DateTime? Datefrom { get; set; }

        [Column("statusid")]
        public int? Statusid { get; set; }

        [Column("id")]
        [Required]
        public int Id { get; set; }

        public double? DamageWaiver { get; set; }

        [Column("sourceid")]
        public int? Sourceid { get; set; }

        public double? Petdeposit { get; set; }

        [Column("deposit")]
        public double? Deposit { get; set; }

        [Column("mgtfee")]
        public double? Mgtfee { get; set; }

        [Column("petfee")]
        public double? Petfee { get; set; }

        public double? Expr4 { get; set; }

        public double? ProcessingFee { get; set; }

        public double? CleaningFee { get; set; }

        [Column("OriginalCF")]
        public double? OriginalCf { get; set; }

        public double? TaxableFees { get; set; }

        public double? NewTax { get; set; }

        public double? Tax { get; set; }

        public bool? DepositReturned { get; set; }

        [Column("depositdate")]
        public DateTime? Depositdate { get; set; }

        public double? ReturnedAmount { get; set; }
    }
}