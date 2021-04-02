using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using BridgeMonitor.Models;
using Newtonsoft.Json;
using System.Net.Http;

namespace BridgeMonitor.Controllers
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
            List<BoatModel> boats = GetBoats();
            boats.Sort((s1, s2) => DateTimeOffset.Compare(s1.ClosingDate, s2.ClosingDate));

            foreach (var boatModel in boats)
            {
                if (DateTimeOffset.Compare(DateTimeOffset.Now, boatModel.ClosingDate) < 0)
                {
                    ViewData["Boat"] = boatModel;
                    break;
                }
            }

            return View();
        }

        public IActionResult All()
        {
            ViewData["Boats"] = GetBoats();
            return View();
        }

      

        public static List<BoatModel> GetBoats()
        {
            using (var client = new HttpClient())
            {
                var response = client.GetAsync("https://api.alexandredubois.com/pont-chaban/api.php");
                var stringResult = response.Result.Content.ReadAsStringAsync();
                var result = JsonConvert.DeserializeObject<List<BoatModel>>(stringResult.Result);
                return result;
            }
        }
    }
}
