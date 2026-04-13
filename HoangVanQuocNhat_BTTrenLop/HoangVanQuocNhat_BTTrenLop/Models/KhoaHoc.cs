using System.ComponentModel.DataAnnotations;

namespace HoangVanQuocNhat_BTTrenLop.Models
{
    public class KhoaHoc
    {
        [Key]
        public string mkh { get; set; }
        public string tenKH { get; set; }
        public ICollection<DangKyKhoaHoc> DangKyKhoaHocs { get; set; }
    }
}