using Microsoft.AspNetCore.Mvc;
using Nhung_FootBall.Models;
using System.Diagnostics;

namespace Nhung_FootBall.Controllers
{
    public class HomeController : Controller
    {
        QlgiaiBongDaKiemTraContext db = new QlgiaiBongDaKiemTraContext();
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            var lstTrongTai = db.Trongtais.ToList();
            var selectedTrongTai = new List<Trongtai>(); 

            for (int i = 0; i < 12 && i < lstTrongTai.Count; i++)
            {
                selectedTrongTai.Add(lstTrongTai[i]);
            }

            return View(selectedTrongTai);
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
