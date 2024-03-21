using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using MyPortfolio.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace MyPortfolio.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        private readonly List<Portfolio> _portfolios = new List<Portfolio>
        {
            new Portfolio()
            {
                id = 1, title = "Liver", description = "اولین اپلیکیشن من", image = "01.jpg"
            },
            new Portfolio()
            {
                id = 2, title = "Kombat", description = "بازی خشن با درجه سنی بزرگسال", image = "02.jpg"
            },
            new Portfolio()
            {
                id = 3, title = "Puzzle", description = "بازی فکری برای کودکان", image = "03.jpg"
            },
            new Portfolio()
            {
                id = 4, title = "کافه نادری", description = "سفارش قهوه و کیک", image = "04.jpg"
            },

        };
        
        

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }
        
        public IActionResult Index()
        {
            ViewData["HeadingText"] = "به اولین وبسایت مهدی عباسی خوش آمدید";
            ViewBag.DescriptionText = "این وبسایت با استفاده از asp.net core 5 ساخته شده است. ";
            
            return View(_portfolios);
        }

        public IActionResult Contact()
        {
            var contact = new Contact();
            contact.PhoneNumber = "09360325019";
            contact.Email = "mahdiabasi.315@gmail.com";
            contact.Github = "github.com/oosmahdi80";
            return View(contact);
        }

        public IActionResult Shop()
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
