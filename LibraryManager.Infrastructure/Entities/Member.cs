namespace LibraryManager.Infrastructure.Entities
{
    public class Member
    {
        public int MemberId { get; set; } // ID của người mượn
        public string FullName { get; set; } // Tên đầy đủ
        public string Email { get; set; } // Email
        public string PhoneNumber { get; set; } // Số điện thoại

        // Liên kết với BorrowRecords
        public ICollection<BorrowRecord> BorrowRecords { get; set; }
    }
}
