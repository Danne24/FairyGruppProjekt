using FairyGruppProjekt.Data;
using FairyGruppProjekt.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;
using System.Data;
using System.Drawing.Text;
using System.Dynamic;
using System.Net;
using System.Net.Http.Headers;
using System.Runtime;

namespace FairyGruppProjekt.Controllers
{
    public class ExchangeRateController : Controller
    {
        private ExchangesRate _Exobj;
        private UsedCurrency _usedCurrency;
        private readonly ApplicationDbContext _appDbContext;

        public ExchangeRateController(ApplicationDbContext appDbContext, ExchangesRate Exobj, UsedCurrency usedCurrency)
        {
            _Exobj = Exobj;
            _usedCurrency = usedCurrency;
            _appDbContext = appDbContext;
        }
        public IActionResult Index()
        {
            using (WebClient webClient = new WebClient())
            {
                var json = webClient.DownloadString("https://v6.exchangerate-api.com/v6/c67ae8eb6c9f6ee6fdadd98b/latest/SEK");
                var ExObj = JsonConvert.DeserializeObject<ExchangesRate>(json);
                return View(ExObj);
            }
        }
        public IActionResult UpdateCurrency( int Id)
        {
            using (WebClient webClient = new WebClient())
            {
                var json = webClient.DownloadString("https://v6.exchangerate-api.com/v6/c67ae8eb6c9f6ee6fdadd98b/latest/SEK");
                var ExObj = JsonConvert.DeserializeObject<ExchangesRate>(json);
                var usedCurr=_appDbContext.usedCurrencies.FirstOrDefault(c => c.TempKey == 1);

                if (Id == 0)
                {

                    usedCurr.CurName = "SEK";
                    usedCurr.CurValue = ExObj.conversion_rates.SEK;
                    //_appDbContext.Entry(usedCurr).State = EntityState.Modified;
                    _appDbContext.SaveChanges();
                }
                if (Id == 1)
                {
                    usedCurr.CurName = "USD";
                    usedCurr.CurValue = ExObj.conversion_rates.USD;
                    //_appDbContext.Entry(usedCurr).State = EntityState.Modified;
                    _appDbContext.SaveChanges();
                }
                if (Id == 2)
                {
                    usedCurr.CurName = "EUR";
                    usedCurr.CurValue = ExObj.conversion_rates.EUR;
                    //_appDbContext.Entry(usedCurr).State = EntityState.Modified;
                    _appDbContext.SaveChanges();
                }
                if (Id == 3)
                {
                    usedCurr.CurName = "GBP";
                    usedCurr.CurValue = ExObj.conversion_rates.GBP;
                    //_appDbContext.Entry(usedCurr).State = EntityState.Modified;
                    _appDbContext.SaveChanges();
                }
                if (Id == 4)
                {
                    usedCurr.CurName = "JPY";
                    usedCurr.CurValue = ExObj.conversion_rates.JPY;
                    //_appDbContext.Entry(usedCurr).State = EntityState.Modified;
                    _appDbContext.SaveChanges();
                }
                if (Id == 5)
                {
                    usedCurr.CurName = "CNY";
                    usedCurr.CurValue = ExObj.conversion_rates.CNY;
                    //_appDbContext.Entry(usedCurr).State = EntityState.Modified;
                    _appDbContext.SaveChanges();
                }


                return View(usedCurr);
            }
        }
    }
    
}
