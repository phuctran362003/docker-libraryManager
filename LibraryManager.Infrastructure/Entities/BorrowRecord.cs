namespace LibraryManager.Infrastructure.Entities
{
    public class BorrowRecord
    {
        public int BorrowRecordId { get; set; } // ID của lịch sử mượn
        public int BookId { get; set; } // FK tới Book
        public int MemberId { get; set; } // FK tới Member
        public DateTime BorrowDate { get; set; } // Ngày mượn
        public DateTime? ReturnDate { get; set; } // Ngày trả (nullable nếu chưa trả)

        // Điều hướng
        public Book Book { get; set; }
        public Member Member { get; set; }
    }
}
