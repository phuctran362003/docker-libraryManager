﻿using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace LibraryManager.Infrastructure.Entities
{
    public class LibraryDbContext : DbContext
    {
        public DbSet<Book> Books { get; set; } // Table Books
        public DbSet<Member> Members { get; set; } // Table Members
        public DbSet<BorrowRecord> BorrowRecords { get; set; } // Table BorrowRecords

        public static string GetConnectionString(string connectionStringName)
        {
            var config = new ConfigurationBuilder()
                .SetBasePath(AppDomain.CurrentDomain.BaseDirectory)
                .AddJsonFile("appsettings.json")
                .Build();

            return config.GetConnectionString(connectionStringName);
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
            => optionsBuilder.UseSqlServer(GetConnectionString("DefaultConnection"));

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Thiết lập quan hệ
            modelBuilder.Entity<BorrowRecord>()
                .HasOne(br => br.Book)
                .WithMany(b => b.BorrowRecords)
                .HasForeignKey(br => br.BookId);

            modelBuilder.Entity<BorrowRecord>()
                .HasOne(br => br.Member)
                .WithMany(m => m.BorrowRecords)
                .HasForeignKey(br => br.MemberId);

            // Index hoặc cấu hình thêm ở đây nếu cần
        }
    }
}