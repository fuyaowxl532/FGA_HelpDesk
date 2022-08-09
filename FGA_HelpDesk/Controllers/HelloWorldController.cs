using Microsoft.AspNetCore.Mvc;

namespace FGA_HelpDesk.Controllers
{
    public class HelloWorldController : Controller
    {
        //public IActionResult Index()
        //{
        //    return View();
        //}

        public string Index() 
        {
            return "This is my default action...";
        }

        public string Welcome()
        {
            return "This is the Welcome action method...";
        }

    }
}
