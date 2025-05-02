using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Destination.Models.destinationTest
{
    [Table("TaskDesc", Schema = "dbo")]
    public partial class TaskDesc
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("taskdesc")]
        public int Taskdesc1 { get; set; }

        [Column("taskdescvalue")]
        public string Taskdescvalue { get; set; }

        public string Type { get; set; }

        public string Department { get; set; }

        public string Priority { get; set; }

        public string Status { get; set; }

        public string Hot { get; set; }

        [Column("MGrid")]
        public string Mgrid { get; set; }

        [Column("color")]
        public string Color { get; set; }

        [Column("TaskMgrID")]
        public int? TaskMgrId { get; set; }
    }
}