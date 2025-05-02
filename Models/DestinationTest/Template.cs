using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Destination.Models.destinationTest
{
    [Table("Templates", Schema = "dbo")]
    public partial class Template
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("intTemplateId")]
        public int IntTemplateId { get; set; }

        [Column("strTemplateName")]
        public string StrTemplateName { get; set; }

        [Column("strSubject")]
        public string StrSubject { get; set; }

        [Column("intCommCode")]
        public int? IntCommCode { get; set; }

        public bool? IsActive { get; set; }

        [Column("dtCreated")]
        public DateTime? DtCreated { get; set; }

        [Column("last_updated")]
        public DateTime? LastUpdated { get; set; }

        [Column("strTemplateContent")]
        public string StrTemplateContent { get; set; }

        [Column("intMode")]
        public int? IntMode { get; set; }

        [Column("strstatus")]
        public int? Strstatus { get; set; }

        [Column("intTopIncludeId")]
        public int? IntTopIncludeId { get; set; }

        [Column("intbottomIncludeId")]
        public int? IntbottomIncludeId { get; set; }

        [Column("strType")]
        public string StrType { get; set; }

        public int? IsDoubleBookingCheck { get; set; }

        public bool? IsActionrequired { get; set; }

        [Column("strmessage")]
        public string Strmessage { get; set; }

        [Column("useemail")]
        public string Useemail { get; set; }

        [Column("strFrom")]
        public string StrFrom { get; set; }

        [Column("intcat")]
        public int? Intcat { get; set; }

        public ICollection<FilterDataForBulkSmsMail> FilterDataForBulkSmsMails { get; set; }
    }
}