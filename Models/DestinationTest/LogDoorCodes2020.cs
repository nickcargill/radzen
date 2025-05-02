using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Destination.Models.destinationTest
{
    [Table("LogDoorCodes2020", Schema = "dbo")]
    public partial class LogDoorCodes2020
    {
        public double? Key { get; set; }

        public string Name { get; set; }

        public string Area { get; set; }

        public string OwnerName { get; set; }

        public string Address { get; set; }

        [Column("OldLockBox ")]
        public string OldLockBox { get; set; }

        public double? NewLockBox { get; set; }

        public DateTime? DateChanged { get; set; }

        public string Alarm { get; set; }

        [Column("PropID")]
        public int? PropId { get; set; }
    }
}