using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Destination.Models.destinationTest
{
    [Table("Property_Expenses_Deleted", Schema = "dbo")]
    public partial class PropertyExpensesDeleted
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("propexpid")]
        public int Propexpid { get; set; }

        [Column("propid")]
        public int? Propid { get; set; }

        public string Type { get; set; }

        public string Description { get; set; }

        [Column("expense")]
        public double? Expense { get; set; }

        [Column("dateentered")]
        public DateTime? Dateentered { get; set; }

        [Column("status")]
        public string Status { get; set; }

        [Column("comments")]
        public string Comments { get; set; }

        [Column("vendorid")]
        public int? Vendorid { get; set; }

        [Column("bookingid")]
        public int? Bookingid { get; set; }

        public bool? Priority { get; set; }

        [Column("datecompleted")]
        public DateTime? Datecompleted { get; set; }

        [Column("empid")]
        public int? Empid { get; set; }

        [Column("hot")]
        public string Hot { get; set; }

        [Column("dontshow")]
        public bool? Dontshow { get; set; }

        [Column("department")]
        public string Department { get; set; }

        [Column("tookcall")]
        public int? Tookcall { get; set; }

        [Column("tenantreport")]
        public bool? Tenantreport { get; set; }

        [Column("processed")]
        public bool? Processed { get; set; }

        [Column("reviewed")]
        public bool? Reviewed { get; set; }

        [Column("datetocomp")]
        public DateTime? Datetocomp { get; set; }

        [Column("cleanerreport")]
        public bool? Cleanerreport { get; set; }

        [Column("mgrid")]
        public int? Mgrid { get; set; }

        [Column("dbbloss")]
        public double? Dbbloss { get; set; }

        public bool? RequestService { get; set; }

        [Column("color")]
        public string Color { get; set; }

        [Column("avoidable")]
        public bool? Avoidable { get; set; }

        public bool? Amenity { get; set; }

        public decimal? Collected { get; set; }

        [Column("contributionstatus")]
        public string Contributionstatus { get; set; }

        [Column("SR")]
        public bool? Sr { get; set; }

        public bool? TenantDamage { get; set; }

        [Column("Planned_Date")]
        public DateTime? PlannedDate { get; set; }

        public bool? OwnerCritical { get; set; }

        public string FromSource { get; set; }
    }
}