using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Maticsoft.Model;
using MvcMusicStore.Models;

namespace MvcMusicStore.Controllers
{
    [Authorize]
    public class CheckoutController : Controller
    {
        const string PromoCode = "Free";
        //
        // GET: /Checkout/
        public ActionResult AddressAndPayMent()
        {
            return View();
        }
        [HttpPost]
        public ActionResult AddressAndPayMent(FormCollection values)
        {
            var order = new musicorder();
            TryUpdateModel(order);
            try
            {
                 if(string.Equals(values["PromoCode"],PromoCode,StringComparison.OrdinalIgnoreCase)==false)
                {
                    return View(order);
                }
                 else
                 {
                     order.Username = User.Identity.Name;
                     order.OrderDate = DateTime.Now;
                     //保存订单
                     Maticsoft.BLL.musicorder orderbll = new Maticsoft.BLL.musicorder();
                     if (orderbll.Add(order))
                     {
                        int orderid= orderbll.GetMaxId()-1;
                         var cart = ShoppingCart.GetCart(this.HttpContext);
                         order.OrderId = orderid;
                         cart.CreateOrder(order);
                     }
                
                     return RedirectToAction("Complete", new { id = order.OrderId });
                 }
            }
            catch (Exception e)
            {

                return View(e);
            }
        }

        public ActionResult Complete(int id)
        {
            bool isValid = true;
            Maticsoft.BLL.musicorder orderbll = new Maticsoft.BLL.musicorder();
            isValid= orderbll.Exists(id);
            if (isValid)
            {
                return View(id);
            }
            else
            {
                return View("Error");
            }
        }
	}
}