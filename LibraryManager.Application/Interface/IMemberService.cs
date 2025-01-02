﻿using LibraryManager.Infrastructure.Entities;

namespace LibraryManager.Application.Interface
{
    public interface IMemberService
    {
        Task<IEnumerable<Member>> GetAllMembersAsync();
        Task<Member> GetMemberByIdAsync(int id);
        Task AddMemberAsync(Member member);
        Task UpdateMemberAsync(Member member);
        Task DeleteMemberAsync(int id);
    }
}