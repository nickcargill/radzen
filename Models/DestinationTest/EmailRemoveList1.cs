using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Destination.Models.destinationTest
{
    [Table("EmailRemoveList1", Schema = "dbo")]
    public partial class EmailRemoveList1
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("id")]
        public int Id { get; set; }

        [Column("removedate")]
        public DateTime? Removedate { get; set; }

        [Column("email")]
        public string Email { get; set; }
    }
}