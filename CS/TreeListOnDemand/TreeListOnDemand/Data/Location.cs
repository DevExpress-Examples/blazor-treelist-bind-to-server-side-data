namespace TreeListOnDemand.Data {
    public class Location {
        public string? Name { get; set; }
        public string? City { get; set; }
        public string? Country { get; set; }
        public decimal Population { get; set; }
        public int ID { get; set; }
        public int ParentID { get; set; }
        public string? CityType { get; set; }
        public string? RecordType { get; set; }
        public int? Year { get; set; }
        public bool HasChildren { get; set; }
    }
}
