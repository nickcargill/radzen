using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Destination.Models.destinationTest
{
    [Table("Sheet1", Schema = "dbo")]
    public partial class Sheet1
    {
        [Column("  Neighborhood")]
        public string Neighborhood { get; set; }

        [Column("Name ")]
        public string Name { get; set; }

        [Column("Address ")]
        public string Address { get; set; }

        public double? Code { get; set; }

        [Column(" alarm")]
        public string Alarm { get; set; }

        public double? NewCode { get; set; }

        [Column("Date Changed")]
        public DateTime? DateChanged { get; set; }

        public string F8 { get; set; }

        public string F9 { get; set; }

        public string F10 { get; set; }

        [Column("propid")]
        public int? Propid { get; set; }
    }
}