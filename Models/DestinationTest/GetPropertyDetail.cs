using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Destination.Models.destinationTest
{
    public partial class GetPropertyDetail
    {
        public int propid { get; set; }

        public string Name { get; set; }

        public string address { get; set; }

        public string Bedrooms { get; set; }

        public string Baths { get; set; }

        public string Floors { get; set; }

        public bool? gametable { get; set; }

        public string Sleeps { get; set; }

        public string Parking_Spaces { get; set; }

        public bool? spa { get; set; }

        public bool? luxury { get; set; }

        public string BBCity { get; set; }

        public string zip { get; set; }
    }
}