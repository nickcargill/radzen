using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Destination.Models.destinationTest
{
    [Table("controllog", Schema = "dbo")]
    public partial class Controllog
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("id")]
        public int Id { get; set; }

        [Column("propid")]
        public int? Propid { get; set; }

        [Column("controlid")]
        public int? Controlid { get; set; }

        [Column("who")]
        public int? Who { get; set; }

        [Column("completed")]
        public bool? Completed { get; set; }

        [Column("completeddate")]
        public DateTime? Completeddate { get; set; }

        [Column("notes")]
        public string Notes { get; set; }
    }
}