namespace LibraryManager.Infrastructure.Entities
{
    public class Book
    {
        public int BookId { get; set; } // ID của sách
        public string Title { get; set; } // Tựa đề
        public string Author { get; set; } // Tác giả
        public string ISBN { get; set; } // Mã ISBN
        public int Quantity { get; set; } // Số lượng sách còn

        // Liên kết với BorrowRecords
        public ICollection<BorrowRecord> BorrowRecords { get; set; }
    }
}
