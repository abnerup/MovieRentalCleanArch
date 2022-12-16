using App.Application.Repository.Interface;
using App.Domain.Entities;
using App.Infra.Context;

namespace App.Infra.Repository
{
    public class RentalRepository : IRentalRepository
    {
        private readonly DataContext _context;

        public RentalRepository(DataContext context)
        {
            _context = context;
        }

        public async Task<List<Rental>> CreateRental(Rental req)
        {
            _context.Rentals.Add(req);
            await _context.SaveChangesAsync();
            return await GetAllRentals();
        }

        public async Task<List<Rental>> GetAllRentals()
        {
            var list = await _context.Rentals.ToListAsync();
            return list;
        }
    }
}
