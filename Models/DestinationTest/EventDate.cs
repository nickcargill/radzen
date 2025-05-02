using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Destination.Models.destinationTest
{
    [Table("Event_Dates", Schema = "dbo")]
    public partial class EventDate
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("id")]
        public int Id { get; set; }

        [Column("event")]
        [Required]
        public string Event { get; set; }

        [Column("startDate")]
        [Required]
        public DateTime StartDate { get; set; }

        [Column("endDate")]
        [Required]
        public DateTime EndDate { get; set; }

        [Column("specialEvent")]
        public bool SpecialEvent { get; set; }

        [Column("intNights")]
        public int? IntNights { get; set; }

        public int? ValueBy { get; set; }
    }
}