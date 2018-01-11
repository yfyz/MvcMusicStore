using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcMusicStore.Controllers
{
    [Authorize(Roles="Administrator")]
    public class StoreManageController : Controller
    {
        //
        // GET: /StoreManage/
        private Maticsoft.BLL.album albumbll = new Maticsoft.BLL.album();
        Maticsoft.BLL.genre genrebll = new Maticsoft.BLL.genre();
        Maticsoft.BLL.artist artistbll = new Maticsoft.BLL.artist();
        public ActionResult Index()
        {
            var albumlist = albumbll.GetAllList("1=1");
            return View(albumlist);
        }

        //
        // GET: /StoreManage/Details/5

        public ActionResult Details(int id)
        {
            var album = albumbll.GetModelAll(id);
            return View(album);
           
        }

        //
        // GET: /StoreManage/Create

        public ActionResult Create()
        {
          

            /*
            var genrelist = genrebll.GetModelList("1=1");
            var artistlist = artistbll.GetModelList("1=1");
            var genreselectList = new List<SelectListItem>
            {
                new SelectListItem{Text="--请选择--",Selected=true,Value=""}
            };
            genreselectList.AddRange(genrelist.Select(genremodel=>new SelectListItem{
            Text=genremodel.Name,
            Selected=true,
            Value=genremodel.GenreId.ToString()
            
            }));
            ViewBag.GenreList = genreselectList;

            var artistselectList = new List<SelectListItem>
            {
                new SelectListItem{Text="--请选择--",Selected=true,Value=""}
            };
            artistselectList.AddRange(artistlist.Select(artistmodel => new SelectListItem
            {
                Text = artistmodel.Name,
                Selected = true,
                Value = artistmodel.ArtistId.ToString()

            }));
            ViewBag.ArtistList = artistselectList;
            */
            ViewBag.ArtistList = new SelectList(artistbll.GetModelList("1=1"), "ArtistId", "Name");
            ViewBag.GenreList = new SelectList(genrebll.GetModelList("1=1"), "GenreId", "Name");
            return View();
        } 

        //
        // POST: /StoreManage/Create

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include="AlbumId,GenreId,ArtistId,Title,Price,AlbumArtUrl")] Maticsoft.Model.album albummodel)
        {
            try
            {
                // TODO: Add insert logic here
                bool bflag = albumbll.Add(albummodel);
                ViewBag.ArtistList = new SelectList(artistbll.GetModelList("1=1"), "ArtistId", "Name", albummodel.ArtistId);
                ViewBag.GenreList = new SelectList(genrebll.GetModelList("1=1"), "GenreId", "Name", albummodel.GenreId);
                return RedirectToAction("Index");
         

            }
            catch (Exception e)
            {

                return View(e.Message);
            }
        }
        
        //
        // GET: /StoreManage/Edit/5
 
        public ActionResult Edit(int id)
        {
            if (id == null) return new HttpStatusCodeResult(400, "无法获取编码");

            var album = albumbll.GetModel(id);
            if (album == null) return HttpNotFound();
            ViewBag.ArtistList = new SelectList(artistbll.GetModelList("1=1"), "ArtistId", "Name",album.ArtistId);
            ViewBag.GenreList = new SelectList(genrebll.GetModelList("1=1"), "GenreId", "Name",album.GenreId);
            return View(album);
          
        }

        //
        // POST: /StoreManage/Edit/5

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "AlbumId,GenreId,ArtistId,Title,Price,AlbumArtUrl")] Maticsoft.Model.album albummodel)
        {
            try
            {
                // TODO: Add update logic here
                if (ModelState.IsValid)
                {
                    albumbll.Update(albummodel);

                }
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        //
        // GET: /StoreManage/Delete/5
 
        public ActionResult Delete(int id)
        {
            if (id == null)
            {

                return new HttpStatusCodeResult((int)System.Net.HttpStatusCode.BadRequest);
            }
            var album = albumbll.GetModelAll(id);
            if (album == null) return HttpNotFound();
            return View(album);
        }

        //
        // POST: /StoreManage/Delete/5

        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            try
            {
                // TODO: Add delete logic here
                albumbll.Delete(id);
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
