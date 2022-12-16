using App.Domain.Entities;

namespace App.Application.Repository.Interface
{
    public interface IRentalRepository
    {
        Task<List<Rental>> GetAllRentals();
        Task<List<Rental>> CreateRental(Rental req);
    }
}
