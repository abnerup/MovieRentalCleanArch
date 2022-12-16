using App.Domain.Entities;

namespace App.Application.Service.Interface
{
    public interface IMemberService
    {
        Task<List<Member>> GetAllMembers();
        Task<List<Member>> CreateMember(Member req);
    }
}
