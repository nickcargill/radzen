using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Destination.Models.destinationTest
{
    [Table("PageEmailRecipients", Schema = "dbo")]
    public partial class PageEmailRecipient
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("ID")]
        public int Id { get; set; }

        [Column("PageID")]
        public int? PageId { get; set; }

        [Column("RecipientUserID")]
        public int? RecipientUserId { get; set; }
    }
}