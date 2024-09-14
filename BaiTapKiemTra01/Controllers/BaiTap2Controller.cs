using BaiTapKiemTra01.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace BaiTapKiemTra01.Controllers
{
    public class BaiTap2Controller : Controller
    {
        public IActionResult Index()
        {
           

           
            return View();

        }
        public IActionResult BaiTap2(SanPhamViewModel sanPham)
        {
            var sanpham = new SanPhamViewModel()
            {
                TenSanPham = "Laptop Dell XPS 13",
                GiaBan = 30000000,  // 30 triệu VND
                AnhMoTa = "/images/dell_xps_13.jpg"
            };


            return View(sanpham);
        }
    }
}
