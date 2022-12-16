using System.Text.Json.Serialization;

namespace App.Domain.Entities
{
    public class Rental
    {
        public int Id { get; set; }
        public DateTime RentalDate { get; set; }
        public DateTime ExpiryDate { get; set; }
        public decimal TotalCost { get; set; }
        [JsonIgnore]
        public List<Member>? Members { get; set; }
    }
}