using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Destination.Models.destinationTest
{
    [Table("tblInterest", Schema = "dbo")]
    public partial class TblInterest
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("ID")]
        public int Id { get; set; }

        [Column("BookingID")]
        public int? BookingId { get; set; }

        public decimal? Budget { get; set; }

        public bool? Antiques { get; set; }

        [Column("ArtGalleriesORShows")]
        public bool? ArtGalleriesOrshows { get; set; }

        [Column("BBQContests")]
        public bool? Bbqcontests { get; set; }

        public bool? BikingAmgen { get; set; }

        public bool? BikingMountain { get; set; }

        public bool? BikingRoad { get; set; }

        public bool? Boating { get; set; }

        public bool? ChiliCookoff { get; set; }

        public bool? ClassicCar { get; set; }

        public bool? Concerts { get; set; }

        public bool? Events { get; set; }

        [Column("FilmsORMovies")]
        public bool? FilmsOrmovies { get; set; }

        public bool? FireworksAnytime { get; set; }

        public bool? Fishing { get; set; }

        public bool? Helicopter { get; set; }

        public bool? Hiking { get; set; }

        public bool? HorsebackRiding { get; set; }

        [Column("JeepExperienceOROffRoadTrails")]
        public bool? JeepExperienceOroffRoadTrails { get; set; }

        [Column("JetBoatingORJetSki")]
        public bool? JetBoatingOrjetSki { get; set; }

        public bool? KidsActivities { get; set; }

        public bool? Kayaking { get; set; }

        public bool? Oktoberfest { get; set; }

        public bool? ParaSailing { get; set; }

        public bool? Restaurants { get; set; }

        public bool? Running { get; set; }

        public bool? Shopping { get; set; }

        public bool? SittingattheLake { get; set; }

        public bool? SittingintheVillage { get; set; }

        public bool? Skiing { get; set; }

        public bool? Sledding { get; set; }

        public bool? Snowboarding { get; set; }

        public bool? Spa { get; set; }

        public bool? Walking { get; set; }

        public bool? WineWalk { get; set; }

        public bool? Yoga { get; set; }

        public bool? Zipline { get; set; }
    }
}