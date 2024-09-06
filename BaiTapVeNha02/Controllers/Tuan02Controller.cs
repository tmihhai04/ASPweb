using Microsoft.AspNetCore.Mvc;

namespace BaiTapVeNha02.Controllers
{
    public class Tuan02Controller : Controller
    {
        public IActionResult Index()
        {
            ViewBag.HoTen = "Tran Minh Hai";
            ViewBag.MSSV = "1822041114";
            ViewBag.Nam = "Nam 2024";
            return View();
        }
    }
}
