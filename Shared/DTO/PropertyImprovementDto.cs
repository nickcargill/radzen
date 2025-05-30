namespace Destination.Shared.DTO
{
    public class PropertyImprovementDto
    {
        public int Propimproveid { get; set; }

        public string ImprovementDesc { get; set; }

        public int? Resource { get; set; }

        public bool? Completed { get; set; }

        public int? Priority { get; set; }

        public int? Propid { get; set; }

        public DateTime? DateOpen2 { get; set; }

        public string Imptype { get; set; }

        public string Name { get; set; }  // From Property table

        public string ResourceName { get; set; } // PC.FirstName + ' ' + PC.LastName
    }

}
