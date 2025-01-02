using LibraryManager.Application.Interface;
using LibraryManager.Infrastructure.Entities;
using LibraryManager.Infrastructure.Interface;

namespace LibraryManager.Application.Service
{
    public class BorrowRecordService : IBorrowRecordService
    {
        private readonly IBorrowRecordRepository _borrowRecordRepository;

        public BorrowRecordService(IBorrowRecordRepository borrowRecordRepository)
        {
            _borrowRecordRepository = borrowRecordRepository;
        }

        public async Task<IEnumerable<BorrowRecord>> GetAllRecordsAsync()
        {
            return await _borrowRecordRepository.GetAllAsync();
        }

        public async Task<BorrowRecord> GetRecordByIdAsync(int id)
        {
            return await _borrowRecordRepository.GetByIdAsync(id);
        }

        public async Task AddRecordAsync(BorrowRecord record)
        {
            await _borrowRecordRepository.AddAsync(record);
        }

        public async Task UpdateRecordAsync(BorrowRecord record)
        {
            await _borrowRecordRepository.UpdateAsync(record);
        }

        public async Task DeleteRecordAsync(int id)
        {
            await _borrowRecordRepository.DeleteAsync(id);
        }
    }
}
