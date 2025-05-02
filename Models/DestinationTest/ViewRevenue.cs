using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Destination.Models.destinationTest
{
    [Table("View_Revenue", Schema = "dbo")]
    public partial class ViewRevenue
    {
        [Column("propid")]
        [Required]
        public int Propid { get; set; }

        public string Name { get; set; }

        public string Bedrooms { get; set; }

        public string Baths { get; set; }

        public string Sleeps { get; set; }

        [Column("propertyid")]
        [Required]
        public int Propertyid { get; set; }

        [Column("datefrom")]
        [Required]
        public DateTime Datefrom { get; set; }

        [Column("rentalamount")]
        [Required]
        public double Rentalamount { get; set; }

        [Column("mgtfee")]
        [Required]
        public double Mgtfee { get; set; }

        [Required]
        public double Collected { get; set; }

        [Column("dateto")]
        [Required]
        public DateTime Dateto { get; set; }

        [Required]
        public double Expr1 { get; set; }

        [Column("nights")]
        [Required]
        public int Nights { get; set; }

        [Column("id")]
        [Required]
        public int Id { get; set; }
    }
}