using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Destination.Models.destinationTest
{
    [Table("AgreementContent", Schema = "dbo")]
    public partial class AgreementContent
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ContentId { get; set; }

        public int? AreaId { get; set; }

        public int? SortOrder { get; set; }

        public string ContentTitle { get; set; }

        public string Content { get; set; }
    }
}