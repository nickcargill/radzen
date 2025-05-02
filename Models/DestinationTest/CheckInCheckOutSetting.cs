using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Destination.Models.destinationTest
{
    [Table("CheckInCheckOutSettings", Schema = "dbo")]
    public partial class CheckInCheckOutSetting
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("ID")]
        public int Id { get; set; }

        public DateTime? StartDate { get; set; }

        public DateTime? EndDate { get; set; }

        public string CheckInTime { get; set; }

        public string CheckOuttime { get; set; }

        public string ElseCheckInTime { get; set; }

        public string ElseCheckOutTime { get; set; }
    }
}