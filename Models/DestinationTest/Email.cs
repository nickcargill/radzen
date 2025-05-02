using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Destination.Models.destinationTest
{
    [Table("Emails", Schema = "dbo")]
    public partial class Email
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("emailid")]
        public int Emailid { get; set; }

        [Column("name")]
        public string Name { get; set; }

        [Column("emailbody")]
        public string Emailbody { get; set; }
    }
}