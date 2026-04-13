using System.ComponentModel.DataAnnotations;

namespace HoangVanQuocNhat_BTTrenLop.Models
{
    public class SinhVien
    {
        [Key]
        public string msv { get; set; }
        public string ten { get; set; }
        public ICollection<DangKyKhoaHoc> DangKyKhoaHocs { get; set; }
    }
}