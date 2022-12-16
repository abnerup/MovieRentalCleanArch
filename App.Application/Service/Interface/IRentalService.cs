using App.Domain.Entities;

namespace App.Application.Service.Interface
{
    public interface IRentalService
    {
        Task<List<Rental>> GetAllRentals();
        Task<List<Rental>> CreateRental(Rental req);
    }
}
