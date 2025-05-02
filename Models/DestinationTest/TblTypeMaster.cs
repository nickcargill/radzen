using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Destination.Models.destinationTest
{
    [Table("tblTypeMaster", Schema = "dbo")]
    public partial class TblTypeMaster
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("TypeID")]
        public int TypeId { get; set; }

        public string TypeName { get; set; }

        [Column("TaskMgrID")]
        public int? TaskMgrId { get; set; }
    }
}