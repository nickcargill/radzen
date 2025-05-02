using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Destination.Models.destinationTest
{
    [Table("AirbnbAPICredentials", Schema = "dbo")]
    public partial class AirbnbApicredential
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("ID")]
        public int Id { get; set; }

        public string IntegrationType { get; set; }

        [Column("IntegrationTypeID")]
        public int? IntegrationTypeId { get; set; }

        [Column("ClientID")]
        public string ClientId { get; set; }

        public string ClientSecret { get; set; }

        public string AccessToken { get; set; }

        public string ExpiresAt { get; set; }

        public string RefreshToken { get; set; }

        [Column("UserID")]
        public long? UserId { get; set; }

        public string UserIdString { get; set; }
    }
}