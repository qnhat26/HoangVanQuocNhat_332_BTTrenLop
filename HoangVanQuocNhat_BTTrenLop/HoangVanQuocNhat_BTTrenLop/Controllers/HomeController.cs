using HoangVanQuocNhat_BTTrenLop.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace HoangVanQuocNhat_BTTrenLop.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            SinhVien sv = new SinhVien()
            {
                ten = "Hoàng Văn Quốc Nhật",
                msv = "2415053122332"
            };
            return View(sv);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
