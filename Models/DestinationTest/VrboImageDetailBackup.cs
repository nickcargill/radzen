using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Destination.Models.destinationTest
{
    [Table("VrboImageDetail_Backup", Schema = "dbo")]
    public partial class VrboImageDetailBackup
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ImageId { get; set; }

        public int? PropId { get; set; }

        public string ImagePath { get; set; }

        public int? ImageName { get; set; }

        public int? ExternalId { get; set; }

        public bool? IsDeleted { get; set; }

        public DateTime? LastUpdated { get; set; }

        public DateTime? FileLastWriteTime { get; set; }
    }
}