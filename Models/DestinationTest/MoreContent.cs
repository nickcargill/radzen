using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Destination.Models.destinationTest
{
    [Table("MoreContent", Schema = "dbo")]
    public partial class MoreContent
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("MoreContentID")]
        public int MoreContentId { get; set; }

        [Column("ContentID")]
        [Required]
        public int ContentId { get; set; }

        [Column("image")]
        public string Image { get; set; }

        [Column("description")]
        public string Description { get; set; }

        public string Title { get; set; }

        public string Link { get; set; }

        public string Type { get; set; }
    }
}