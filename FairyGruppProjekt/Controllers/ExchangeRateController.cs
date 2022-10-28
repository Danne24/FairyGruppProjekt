using FairyGruppProjekt.Models;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System.Data;
using System.Drawing.Text;
using System.Net;
using System.Net.Http.Headers;
using System.Runtime;

namespace FairyGruppProjekt.Controllers
{
    public class ExchangeRateController : Controller
    {
       
       
        public IActionResult Index()
        {
            using (WebClient webClient = new WebClient())
            {
                var json = webClient.DownloadString("https://v6.exchangerate-api.com/v6/c67ae8eb6c9f6ee6fdadd98b/latest/SEK");
                var ExObj = JsonConvert.DeserializeObject<ExchangesRate>(json);
                return View(ExObj);
            }
        }
        public IActionResult UpdateCurrency(ExchangesRate ExObj)
        {
           
            return View();
        }

    }
    
}
