using App.Application.Repository.Interface;
using App.Domain.Entities;
using App.Infra.Context;

namespace App.Infra.Repository
{
    public class MemberRepository : IMemberRepository
    {
        private readonly DataContext _context;

        public MemberRepository(DataContext context)
        {
            _context = context;
        }

        public async Task<List<Member>> CreateMember(Member req)
        {
            _context.Members.Add(req);
            await _context.SaveChangesAsync();
            return await GetAllMembers();
        }

        public async Task<List<Member>> GetAllMembers()
        {
            var list = await _context.Members.ToListAsync();
            return list;
        }
    }
}
