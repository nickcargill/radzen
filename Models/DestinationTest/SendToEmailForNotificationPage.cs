using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Destination.Models.destinationTest
{
    [Table("SendToEmailForNotificationPages", Schema = "dbo")]
    public partial class SendToEmailForNotificationPage
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("ID")]
        public int Id { get; set; }

        [Column("PageURL")]
        public string PageUrl { get; set; }

        public string PageName { get; set; }

        public string EmailTo { get; set; }
    }
}