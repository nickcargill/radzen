using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Destination.Models.destinationTest
{
    [Table("propertycontenttype", Schema = "dbo")]
    public partial class Propertycontenttype
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("propconttypeid")]
        public int Propconttypeid { get; set; }

        [Column("contenttype")]
        public string Contenttype { get; set; }
    }
}