using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Destination.Models.destinationTest
{
    [Table("AirbnbAPI_AutoSyncContents", Schema = "dbo")]
    public partial class AirbnbApiAutoSyncContent
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("ID")]
        public int Id { get; set; }

        [Column("PropID")]
        public int? PropId { get; set; }

        public string ContentType { get; set; }

        public DateTime ChangedOn { get; set; }

        public bool? IsSynced { get; set; }

        public DateTime? SyncedOn { get; set; }

        public string ResponseStatus { get; set; }

        public string ResponseContent { get; set; }
    }
}