using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Destination.Models.destinationTest
{
    [Table("Inntopia_CallLog", Schema = "dbo")]
    public partial class InntopiaCallLog
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("ID")]
        public int Id { get; set; }

        public DateTime? CreatedDate { get; set; }

        public string RequestType { get; set; }

        public string RequestBody { get; set; }

        public string ResponseBody { get; set; }
    }
}