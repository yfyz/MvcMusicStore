using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Maticsoft.Model;
namespace MvcMusicStore.Controllers
{
    public class HomeController : Controller
    {
        //
        // GET: /Home/

        public ActionResult Index()
        {
            var albums = GetTopSellingAlbums(5);
            return View(albums);
        }
        private List<album> GetTopSellingAlbums(int count)
        {
            Maticsoft.BLL.album albumbll = new Maticsoft.BLL.album();

            return albumbll.GetTopSellingAlbums(count);
        }
    }
}
