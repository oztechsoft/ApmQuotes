using ApmQuotes.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace ApmQuotes.Controllers
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
            var quote = new QuoteModel(); 
            return View(quote);
        }

        [HttpPost]
        public ActionResult Index(QuoteModel quote)
        {
            var length = quote.RoomLength;
            var width = quote.RoomWidth;

            var area = length * width;
            var CutOff = area % 5;

            if(CutOff != 0)
            {
                var ExtraRoll = 5 - CutOff;
                area = area + ExtraRoll;
            }

            var labourCost = area * 20;
            var CarpetCost = area * 50;

            quote.FinalCost = (labourCost + CarpetCost) * GetSeriesMultiplier(quote.SeriesUpgrade);

            return View(quote);
        }

        public double GetSeriesMultiplier(SeriesUpgrade SelectedSeriesUpgrade)
        {
            if (SelectedSeriesUpgrade == SeriesUpgrade.SeriesOne)
            {
                return 1.0;
            }
            else if (SelectedSeriesUpgrade == SeriesUpgrade.SeriesTwo)
            {
                return 1.2;
            }
            else if (SelectedSeriesUpgrade == SeriesUpgrade.SeriesThree)
            {
                return 1.5;
            }
            else if (SelectedSeriesUpgrade == SeriesUpgrade.SeriesFour)
            {
                return 2.0;
            }
            else
            {
                return 0.0;
            }
        }

        public IActionResult Privacy()
        {
            return View();
        }

    }
}