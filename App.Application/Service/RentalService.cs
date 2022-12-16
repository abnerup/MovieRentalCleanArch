using App.Application.Repository.Interface;
using App.Application.Service.Interface;
using App.Domain.Entities;

namespace App.Application.Service
{
    public class RentalService : IRentalService
    {
        private readonly IRentalRepository _rentalRepository;

        public RentalService(IRentalRepository rentalRepository) 
        {
            _rentalRepository = rentalRepository;
        }

        public async Task<List<Rental>> CreateRental(Rental req)
        {
            await _rentalRepository.CreateRental(req);
            return await GetAllRentals();
        }

        public async Task<List<Rental>> GetAllRentals()
        {
            var list = await _rentalRepository.GetAllRentals();
            return list;
        }
    }
}
