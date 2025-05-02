using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Destination.Models.destinationTest
{
    [Table("Favorites", Schema = "dbo")]
    public partial class Favorite
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("intFavId")]
        public int IntFavId { get; set; }

        [Column("intTenantId")]
        public int? IntTenantId { get; set; }

        [Column("intPropId")]
        public int? IntPropId { get; set; }

        public bool? IsDeleted { get; set; }

        [Column("dtCreated")]
        public DateTime? DtCreated { get; set; }

        [Column("dateFrom")]
        public DateTime? DateFrom { get; set; }

        [Column("dateTo")]
        public DateTime? DateTo { get; set; }

        public bool? IsEmail { get; set; }

        public bool? IsLike { get; set; }
    }
}