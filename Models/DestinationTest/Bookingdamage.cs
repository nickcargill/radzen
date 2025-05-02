using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Destination.Models.destinationTest
{
    [Table("bookingdamages", Schema = "dbo")]
    public partial class Bookingdamage
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("id")]
        public int Id { get; set; }

        [Column("bookingid")]
        public int? Bookingid { get; set; }

        [Column("photo")]
        public string Photo { get; set; }

        [Column("photodesc")]
        public string Photodesc { get; set; }

        public string UploadedBy { get; set; }

        [Column("UploaderID")]
        public int? UploaderId { get; set; }

        public string FromPage { get; set; }

        [Column("TaskID")]
        public int? TaskId { get; set; }

        [Column("CleanerID")]
        public int? CleanerId { get; set; }

        [Column("TenantID")]
        public int? TenantId { get; set; }

        public DateTime? UploadedOn { get; set; }

        public bool? IsReviewed { get; set; }
    }
}