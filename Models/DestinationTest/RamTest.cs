using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Destination.Models.destinationTest
{
    [Table("RamTest", Schema = "dbo")]
    public partial class RamTest
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("TestID")]
        public int TestId { get; set; }

        public string TestName { get; set; }

        public ICollection<RamTestUser> RamTestUsers { get; set; }
    }
}