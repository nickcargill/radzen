using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Destination.Models.destinationTest
{
    [Table("LandingPages", Schema = "dbo")]
    public partial class LandingPage
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("ID")]
        public int Id { get; set; }

        [Column("PageURL")]
        public string PageUrl { get; set; }

        public string Description { get; set; }

        public bool? IsActive { get; set; }

        public string PageName { get; set; }

        [Column("ImageURL")]
        public string ImageUrl { get; set; }

        public string ShortDesc { get; set; }
    }
}