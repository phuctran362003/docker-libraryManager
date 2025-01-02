using LibraryManager.Infrastructure.Entities;

namespace LibraryManager.Application.Interface
{
    public interface IBorrowRecordService
    {
        Task<IEnumerable<BorrowRecord>> GetAllRecordsAsync();
        Task<BorrowRecord> GetRecordByIdAsync(int id);
        Task AddRecordAsync(BorrowRecord record);
        Task UpdateRecordAsync(BorrowRecord record);
        Task DeleteRecordAsync(int id);
    }

}
