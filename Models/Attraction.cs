namespace TravelGuide.Models
{
    public class Attraction
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string History { get; set; }
        public string PhotoPath { get; set; }
        public string WorkingHours { get; set; }
        public decimal? EntranceFee { get; set; } // Может быть null (бесплатно)

        public int CityId { get; set; }
        public City City { get; set; }
    }
}
