using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Destination.Models.destinationTest
{
    [Table("RamTestUsers", Schema = "dbo")]
    public partial class RamTestUser
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("ID")]
        public int Id { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string PhoneNumber { get; set; }

        public string Email { get; set; }

        [Column("RamTestID")]
        public int? RamTestId { get; set; }

        public RamTest RamTest { get; set; }

        public ICollection<RamTestResult> RamTestResults { get; set; }

        public ICollection<RamTestUserResult> RamTestUserResults { get; set; }
    }
}