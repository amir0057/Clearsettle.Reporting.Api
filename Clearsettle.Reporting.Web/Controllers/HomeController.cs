using System;
using System.Threading.Tasks;
using System.Web.Mvc;
using Clearsettle.Reporting.Web.Models;

namespace Clearsettle.Reporting.Web.Controllers
{
    public class HomeController : Controller
    {
        
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Report()
        {
            return View();
        }
        public ActionResult Merchant()
        {
            return View();
        }
        public ActionResult Transaction()
        {
            return View();
        }
        public ActionResult Client()
        {
            return View();
        }

        [HttpPost]
        [ActionName("GetReport")]
        public async Task<ActionResult> GetReport(string from, string to)
        {
            var fromDate = DateTime.ParseExact(from,"yyyy-MM-dd", null);
            var toDate = DateTime.ParseExact(to, "yyyy-MM-dd", null);
            var report = await ClearsettleApiService.GetReport(fromDate, toDate);
            return PartialView("_report", report);
        }

        [HttpGet]
        [ActionName("GetTransaction")]
        [Route("Home/GetTransaction")]
        public async Task<ActionResult> GetTransaction(string transactionId)
        {
            var transaction = await ClearsettleApiService.GetTransaction(transactionId);
            return PartialView("_transaction", transaction);
        }

        [HttpGet]
        [ActionName("GetMerchant")]
        public async Task<ActionResult> GetMerchant(string transactionId)
        {
           var merchant = await ClearsettleApiService.GetMerchant(transactionId);
           return PartialView("_merchant", merchant);
        }

        [HttpGet]
        [ActionName("GetClient")]
        public async Task<ActionResult> GetClient(string transactionId)
        {
            var client = await ClearsettleApiService.GetClient(transactionId);
            return PartialView("_client", client);
        }
    }
}