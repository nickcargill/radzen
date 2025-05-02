using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Destination.Models.destinationTest
{
    [Table("tblAirbnbExportTemp", Schema = "dbo")]
    public partial class TblAirbnbExportTemp
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("ID")]
        public int Id { get; set; }

        [Column("PropID")]
        public int? PropId { get; set; }

        public int? Airbnb { get; set; }

        public string Name { get; set; }

        [Column("startDate")]
        public DateTime? StartDate { get; set; }

        public DateTime? EndDate { get; set; }

        public decimal? WeekdayPrice { get; set; }

        public decimal? WeekendPrice { get; set; }

        public int? Nights { get; set; }
    }
}