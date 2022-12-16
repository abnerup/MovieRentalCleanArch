using System.ComponentModel.DataAnnotations;

namespace App.Domain.Entities
{
    public class Member
    {
        public int Id { get; set; }
        public string FirstName { get; set; } = string.Empty;
        public string LastName { get; set; } = string.Empty;
        [EmailAddress]
        public string Email { get; set; } = string.Empty;

        public int RentalId { get; set; }

        public Rental? Rental { get; set; }
    }
}