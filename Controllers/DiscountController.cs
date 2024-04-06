using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DiscountSystem.Controllers
{
    public class DiscountController : Controller
    {
        // GET: Discount
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Discount()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Discount(DiscountSystem.Models.Discount discount)
        {
            discount.Subtotal = discount.Sub();
            discount.DiscRate = discount.Disc();
            discount.TotalAmt = discount.Tot();
            discount.Vat = discount.VatAmt();
            discount.FinalDue = discount.Final();
            return View(discount);
        }
    }
}