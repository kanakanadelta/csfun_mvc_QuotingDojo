using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using QuotingDojo.Models;

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

        [HttpGet("quotes")]
        public IActionResult Quotes()
        {
            List<Dictionary<string, object>> AllQuotes = DbConnector.Query("SELECT * FROM quotes");
            ViewBag.Quotes = AllQuotes;
            return View();
        }

        [HttpPost]
        [Route("create")]
        public IActionResult Create(Quote quote)
        {

            if(ModelState.IsValid)
            {
                quote.CreatedAt = DateTime.Now;
                string dateFormat = "yyyy-MM-dd HH:mm:ss";
                quote.Date = DateTime.Now.ToString(dateFormat);

                string query = "INSERT INTO quotes (Name, Comment, Date) VALUES ('" + quote.Name + "', '" + quote.Comment + "', NOW())";
                DbConnector.Execute(query);
                return RedirectToAction("Quotes");
            }
            else
            {
                return View("Index");
            }
            
        }
    }
}