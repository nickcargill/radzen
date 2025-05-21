using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Destination.Models.destinationTest
{
    [Table("MenuMaster", Schema = "dbo")]
    public partial class MenuMaster
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        public string MenuText { get; set; }

        public string MenuUrl { get; set; }

        public int? ParentId { get; set; }

        public int? MenuType { get; set; }

        public bool? IsActive { get; set; }

        public string UrlTarget { get; set; }

        public string Description { get; set; }

        public string Location { get; set; }

        [Column("querySchema")]
        public string QuerySchema { get; set; }

        public DateTime? LastUpdated { get; set; }

        public string SchemaText { get; set; }

        public int? Role { get; set; }

        public int? SortOrder { get; set; }

        public string PageTitle { get; set; }

        public ICollection<MenuManagement> MenuManagements { get; set; }
    }

    public partial class MenuMasterDTO
    {
        public int Id { get; set; }

        public string MenuText { get; set; }

        public string MenuUrl { get; set; }

        public int? ParentId { get; set; }

        public int? MenuType { get; set; }

        public bool? IsActive { get; set; }

        public string UrlTarget { get; set; }

        public bool IsExpanded { get; set; }

        public List<MenuMasterDTO> Children { get; set; } = new();
    }
}