using FGA_HelpDesk.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using FGA_DAL;

namespace FGA_HelpDesk.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            //Test DB
            string sql = "update [FGA_WIPTransfer_T] set Transtatus = 'Checked' where tid ='10000267' ";
            int count = FGA_DAL.Base.SQLServerHelper_FGA.ExecuteSql(sql);

            return View();
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