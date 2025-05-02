using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Destination.Models.destinationTest
{
    [Table("MenuManagement", Schema = "dbo")]
    public partial class MenuManagement
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        public int? MenuId { get; set; }

        public MenuMaster MenuMaster { get; set; }

        [Column("RoleID")]
        public int? RoleId { get; set; }

        public bool? IsActive { get; set; }
    }
}