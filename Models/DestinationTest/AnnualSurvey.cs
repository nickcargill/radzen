using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Destination.Models.destinationTest
{
    [Table("AnnualSurvey", Schema = "dbo")]
    public partial class AnnualSurvey
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("ID")]
        public int Id { get; set; }

        [Required]
        public int PropId { get; set; }

        public Property Property { get; set; }

        public string PropertyName { get; set; }

        public DateTime? SubmissionTime { get; set; }

        public string Email { get; set; }

        [Column("Os_Utm_Source")]
        public string OsUtmSource { get; set; }

        public string HomeCleaning { get; set; }

        public string CarpetsCleaning { get; set; }

        public string YardCleaning { get; set; }

        public string WindowsCleaning { get; set; }

        public string DecksOrPatios { get; set; }

        public string GovernmentGuidelines { get; set; }

        public string AnyQuestions { get; set; }

        public string Closing { get; set; }

        public TimeOnly? TimeToComplete { get; set; }

        public DateTime CreatedDate { get; set; }
    }
}