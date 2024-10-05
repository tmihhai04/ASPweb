using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Project1.Data;
using Project1.Models;
using Project1.Data;
using Project1.Models;
using System.Diagnostics;

namespace Project1.Controllers
{
	[Area("Customer")]
	public class HomeController : Controller
	{
		private readonly ILogger<HomeController> _logger;
		private readonly ApplicationDbContext _db;

		public HomeController(ILogger<HomeController> logger, ApplicationDbContext db)
		{
			_logger = logger;
			_db = db;
		}

		public IActionResult Index()
		{
			IEnumerable<SanPham> sanpham = _db.SanPham.Include("TheLoai").ToList();
			return View(sanpham);
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