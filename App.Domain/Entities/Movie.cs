using System.Text.Json.Serialization;

namespace App.Domain.Entities
{
    public class Movie
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public decimal RentalCost { get; set; }
        public int RentalDuration { get; set; }
        [JsonIgnore]
        public List<MovieRental>? MovieRentals { get; set; }
    }
}