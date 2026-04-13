using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HoangVanQuocNhat_BTTrenLop.Models
{
    public class DangKyKhoaHoc
    {
        [Key]
        public int Id { get; set; }
        public DateTime NgayDK { get; set; }
        public string msv { get; set; }
        [ForeignKey("msv")]
        public SinhVien SinhVien { get; set; }
        public string mkh { get; set; }
        [ForeignKey("mkh")]
        public KhoaHoc KhoaHoc { get; set; }
    }
}