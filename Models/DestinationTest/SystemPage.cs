using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Destination.Models.destinationTest
{
    [Table("SystemPages", Schema = "dbo")]
    public partial class SystemPage
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("PageID")]
        public int PageId { get; set; }

        [Column("PageURL")]
        public string PageUrl { get; set; }

        public string PageName { get; set; }

        public string PageDescription { get; set; }

        public TimeOnly? ExecuteTime { get; set; }

        [Column("status")]
        public string Status { get; set; }

        [Column("type")]
        public string Type { get; set; }

        public string Audience { get; set; }

        public string Process { get; set; }

        public bool? CreatedThruFilter { get; set; }

        [Column("FilterID")]
        public int? FilterId { get; set; }

        public string How { get; set; }

        public string Interval { get; set; }
    }
}