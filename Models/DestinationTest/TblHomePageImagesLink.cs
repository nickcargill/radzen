using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Destination.Models.destinationTest
{
    [Table("tblHomePageImagesLinks", Schema = "dbo")]
    public partial class TblHomePageImagesLink
    {
        [Column("ID")]
        public int? Id { get; set; }

        public string ImageLink { get; set; }

        public string Title { get; set; }

        public string ShortDescription { get; set; }
    }
}