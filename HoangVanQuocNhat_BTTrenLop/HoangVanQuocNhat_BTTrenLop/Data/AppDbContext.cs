using HoangVanQuocNhat_BTTrenLop.Models;
using Microsoft.EntityFrameworkCore;

namespace HoangVanQuocNhat_BTTrenLop.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) 
        {
        }
        public DbSet<SinhVien> SinhViens { get; set; }
        public DbSet<KhoaHoc> KhoaHocs { get; set; }
        public DbSet<DangKyKhoaHoc> DangKyKhoaHocs { get; set; }
    }
}
