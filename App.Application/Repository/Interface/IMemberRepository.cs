

using App.Domain.Entities;

namespace App.Application.Repository.Interface
{
    public interface IMemberRepository
    {
        Task<List<Member>> GetAllMembers();
        Task<List<Member>> CreateMember(Member req);
    }
}
