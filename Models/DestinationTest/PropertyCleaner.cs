using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Destination.Models.destinationTest
{
    [Table("property_cleaner", Schema = "dbo")]
    public partial class PropertyCleaner
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("cleanerid")]
        public int Cleanerid { get; set; }

        [Column("firstname")]
        public string Firstname { get; set; }

        [Column("lastname")]
        public string Lastname { get; set; }

        [Column("email")]
        public string Email { get; set; }

        [Column("phone")]
        public string Phone { get; set; }

        [Column("address")]
        public string Address { get; set; }

        [Column("city")]
        public string City { get; set; }

        [Column("state")]
        public string State { get; set; }

        [Column("zip")]
        public string Zip { get; set; }

        [Column("rate")]
        public double? Rate { get; set; }

        [Column("lastraise")]
        public DateTime? Lastraise { get; set; }

        [Column("ranking")]
        public int? Ranking { get; set; }

        [Column("notes")]
        public string Notes { get; set; }

        [Column("status")]
        public string Status { get; set; }

        [Column("occupation")]
        public string Occupation { get; set; }

        [Column("active")]
        public bool? Active { get; set; }

        [Column("lastcontact")]
        public DateTime? Lastcontact { get; set; }

        [Column("resume")]
        public string Resume { get; set; }

        public int? Nicksranking { get; set; }

        [Column("sms")]
        public string Sms { get; set; }

        [Column("login")]
        public string Login { get; set; }

        [Column("password")]
        public string Password { get; set; }

        [Column("photo")]
        public string Photo { get; set; }

        [Column("workunderid")]
        public int? Workunderid { get; set; }

        public bool? Live { get; set; }

        public bool? Covidcertified { get; set; }

        [Column("DBBEmployee")]
        public bool? Dbbemployee { get; set; }

        public string CompanyName { get; set; }

        [Column("IsReceivedSMS")]
        public bool? IsReceivedSms { get; set; }

        [Column("Bus_lic")]
        public string BusLic { get; set; }

        public bool? IsActive { get; set; }

        public ICollection<Property> Properties { get; set; }
    }
}