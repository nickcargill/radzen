using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Destination.Models.destinationTest
{
    [Table("NoWords", Schema = "dbo")]
    public partial class NoWord
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("ID")]
        public int Id { get; set; }

        public string Content { get; set; }

        public DateTime? EnteredOn { get; set; }

        public string DuplicateKeywords { get; set; }
    }
}