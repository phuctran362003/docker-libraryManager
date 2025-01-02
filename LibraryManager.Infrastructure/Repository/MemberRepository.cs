using LibraryManager.Infrastructure.Entities;
using LibraryManager.Infrastructure.Interface;

namespace LibraryManager.Infrastructure.Repository
{
    public class MemberRepository : BaseRepository<Member>, IMemberRepository
    {
        public MemberRepository(LibraryDbContext context) : base(context) { }
    }
}
