using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Destination.Models.destinationTest
{
    [Table("ColumnSelectionProfiles", Schema = "devuser")]
    public partial class DevuserColumnselectionprofiles
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Required]
        public int TenantId { get; set; }

        [Required]
        public string ProfileName { get; set; }

        [Required]
        public string ParentTableName { get; set; }

        [Required]
        public string TableUsed { get; set; }

        [Required]
        public string Query { get; set; }

        [Required]
        public string SelectedColumns { get; set; }

        [Required]
        public string ChildTableJoin { get; set; }

        [Required]
        public string WhereClauseJson { get; set; }

        [Required]
        public string MapColumnHeading { get; set; }

        public DateTime? CreatedAt { get; set; }
    }
}