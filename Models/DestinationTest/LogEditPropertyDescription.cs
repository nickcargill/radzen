using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Destination.Models.destinationTest
{
    [Table("Log_Edit_PropertyDescription", Schema = "dbo")]
    public partial class LogEditPropertyDescription
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("ID")]
        public int Id { get; set; }

        [Column("PropID")]
        public int? PropId { get; set; }

        [Column("UserID")]
        public int? UserId { get; set; }

        public DateTime UpdatedOn { get; set; }

        [Column("remarks")]
        public string Remarks { get; set; }
    }
}