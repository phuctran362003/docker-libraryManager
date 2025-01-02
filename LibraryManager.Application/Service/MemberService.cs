using LibraryManager.Application.Interface;
using LibraryManager.Infrastructure.Entities;
using LibraryManager.Infrastructure.Interface;

namespace LibraryManager.Application.Service
{
    public class MemberService : IMemberService
    {
        private readonly IMemberRepository _memberRepository;

        public MemberService(IMemberRepository memberRepository)
        {
            _memberRepository = memberRepository;
        }

        public async Task<IEnumerable<Member>> GetAllMembersAsync()
        {
            return await _memberRepository.GetAllAsync();
        }

        public async Task<Member> GetMemberByIdAsync(int id)
        {
            return await _memberRepository.GetByIdAsync(id);
        }

        public async Task AddMemberAsync(Member member)
        {
            await _memberRepository.AddAsync(member);
        }

        public async Task UpdateMemberAsync(Member member)
        {
            await _memberRepository.UpdateAsync(member);
        }

        public async Task DeleteMemberAsync(int id)
        {
            await _memberRepository.DeleteAsync(id);
        }
    }
}
