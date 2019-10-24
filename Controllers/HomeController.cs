using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;

namespace QuotingDojo.Controllers
{
    public class HomeController : Controller
    {
        [HttpGet("")]
        public IActionResult Index()
        {
            List<Dictionary<string, object>> AllQuotes = DbConnector.Query("SELECT * FROM quotes");
            ViewBag.Quotes = AllQuotes;
            return View();
        }
    }
}