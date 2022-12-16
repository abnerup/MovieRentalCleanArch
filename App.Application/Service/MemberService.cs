using App.Application.Repository.Interface;
using App.Application.Service.Interface;
using App.Domain.Entities;

namespace App.Application.Service
{
    public class MemberService:IMemberService
    {
        private readonly IMemberRepository _memberRepository;

        public MemberService(IMemberRepository memberRepository)
        {
            _memberRepository = memberRepository;
        }

        public async Task<List<Member>> CreateMember(Member req)
        {
           var list = await _memberRepository.CreateMember(req);
           return list;
        }

        public async Task<List<Member>> GetAllMembers()
        {
            var list = await _memberRepository.GetAllMembers();
            return list;
        }
    }
}
