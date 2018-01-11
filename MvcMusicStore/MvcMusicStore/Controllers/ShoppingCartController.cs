using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcMusicStore.Controllers
{
    public class ShoppingCartController : Controller
    {
        //
        // GET: /ShoppingCart/
        public ActionResult Index()
        {
            var Cart = MvcMusicStore.Models.ShoppingCart.GetCart(this.HttpContext);
            var viewModel = new MvcMusicStore.ViewModels.ShoppingCartViewModel
            {
                CartItems=Cart.GetCartItems(),
                CartTotal =Cart.GetTotal()

            };
         
           
            return View(viewModel);
        }
        //Get:/Store/AddToCart/5
        public ActionResult AddToCart(int id)
        {
            Maticsoft.BLL.album albumbll =new Maticsoft.BLL.album();

            var addedAlbum = albumbll.GetModel(id);
            var Cart = MvcMusicStore.Models.ShoppingCart.GetCart(this.HttpContext);
            Cart.AddToCart(addedAlbum);
            return RedirectToAction("Index");
        }
        //Ajax:/ShoppingCart/RemoveFromCart/5
        [HttpPost]
        public ActionResult RemoveFromCart(int id)
        {
            var Cart = MvcMusicStore.Models.ShoppingCart.GetCart(this.HttpContext);
            Maticsoft.BLL.album albumbll =new Maticsoft.BLL.album();
            Maticsoft.BLL.cart cartbll = new Maticsoft.BLL.cart();
            string albumName = albumbll.GetModel(cartbll.GetModel(id).AlbumId).Title;
            int itemCount = Cart.RemoveFromCart(id);
            var results = new MvcMusicStore.ViewModels.ShoppingCartRemoveViewModel
            {
                Message = Server.HtmlEncode(albumName) + " has been removed from your shopping cart.",
                CartTotal = Cart.GetTotal(),
                CartCount = Cart.GetCount(),
                ItemCount = itemCount,
                DeleteId = id
            };
            return Json(results);
        }
        //Get:/ShoppingCart/CartSummary/
        [ChildActionOnly]
        public ActionResult CartSummary()
        {
            var Cart = MvcMusicStore.Models.ShoppingCart.GetCart(this.HttpContext);
            ViewData["CartCount"] = Cart.GetCount();
            return PartialView("CartSummary");
        }
	}
}