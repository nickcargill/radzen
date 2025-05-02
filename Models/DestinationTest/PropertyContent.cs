using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Destination.Models.destinationTest
{
    [Table("property_content", Schema = "dbo")]
    public partial class PropertyContent
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("ContentID")]
        public int ContentId { get; set; }

        public string Title { get; set; }

        public int? Type { get; set; }

        public int? Status { get; set; }

        public string Description { get; set; }

        [Column("imagepath")]
        public string Imagepath { get; set; }

        [Column("parentid")]
        public int? Parentid { get; set; }

        [Column("address")]
        public string Address { get; set; }

        [Column("city")]
        public string City { get; set; }

        [Column("phone")]
        public string Phone { get; set; }

        [Column("website")]
        public string Website { get; set; }

        public DateTime? Date { get; set; }

        [Column("teaser")]
        public string Teaser { get; set; }

        [Column("contenttype")]
        public string Contenttype { get; set; }

        public string Stat { get; set; }

        [Column("morelink")]
        public string Morelink { get; set; }

        [Column("email")]
        public string Email { get; set; }

        public int? Sort { get; set; }

        public string Contact { get; set; }

        public string ContactNum { get; set; }

        public string Contactemail { get; set; }

        [Column("ptitle")]
        public string Ptitle { get; set; }

        [Column("pmetad")]
        public string Pmetad { get; set; }

        [Column("pmetak")]
        public string Pmetak { get; set; }

        [Column("linkto")]
        public string Linkto { get; set; }

        [Column("linktonotes")]
        public string Linktonotes { get; set; }

        [Column("lasttouched")]
        public DateTime? Lasttouched { get; set; }

        [Column("pageauthority")]
        public int? Pageauthority { get; set; }
    }
}