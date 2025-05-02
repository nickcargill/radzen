using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Destination.Models.destinationTest
{
    [Table("Searches", Schema = "dbo")]
    public partial class Search
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("intSearchId")]
        public int IntSearchId { get; set; }

        [Column("intTenantId")]
        public int? IntTenantId { get; set; }

        [Column("strSearchURL")]
        public string StrSearchUrl { get; set; }

        public bool? IsDeleted { get; set; }

        [Column("dtCreated")]
        public DateTime? DtCreated { get; set; }
    }
}