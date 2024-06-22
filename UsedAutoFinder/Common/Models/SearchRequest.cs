namespace Common.Models
{
    public class SearchRequest
    {
        public string? State { get; set; }
        public int? ZipCode { get; set; }
        public string? Make { get; set; }
        public string? Model { get; set; }
        public int? Year { get; set; }
        public int? Mileage { get; set; }
        public float? PriceHigh { get; set; }
        public float? PriceLow { get; set; }
    }
}
