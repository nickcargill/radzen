using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Destination.Models.destinationTest
{
    [Table("WebPageTemplates", Schema = "dbo")]
    public partial class WebPageTemplate
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int TemplateId { get; set; }

        [Column("strTemplateName")]
        public string StrTemplateName { get; set; }

        public bool? IsActive { get; set; }

        [Column("dtCreated")]
        public DateTime? DtCreated { get; set; }

        [Column("last_updated")]
        public DateTime? LastUpdated { get; set; }

        [Column("strTemplateContent")]
        public string StrTemplateContent { get; set; }

        [Column("intCommCode")]
        public int? IntCommCode { get; set; }

        [Column("strType")]
        public string StrType { get; set; }

        [Column("strstatus")]
        public int? Strstatus { get; set; }

        public string Audience { get; set; }
    }
}