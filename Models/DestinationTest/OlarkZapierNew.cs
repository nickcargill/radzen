using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Destination.Models.destinationTest
{
    [Table("OlarkZapier_New", Schema = "dbo")]
    public partial class OlarkZapierNew
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("ID")]
        public int Id { get; set; }

        public DateTime? EnteredOn { get; set; }

        public string VisitorName { get; set; }

        [Column("EmailID")]
        public string EmailId { get; set; }

        public string Phone { get; set; }

        public string ChatText { get; set; }

        public string OperatorName { get; set; }

        public string OperatorUserName { get; set; }

        public string OperatorsInfo { get; set; }

        public bool? Status { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        [Column("TenantID")]
        public int? TenantId { get; set; }

        [Column("BookingID")]
        public int? BookingId { get; set; }
    }
}