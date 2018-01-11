using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcMusicStore.Controllers
{
    public class GenreController : Controller
    {
        Maticsoft.BLL.genre genrebll = new Maticsoft.BLL.genre();
        //
        // GET: /Genre/
     //   public mymusicEntities myEntiy = new mymusicEntities();

        [CustomAuthorizeAttribute]
        public ActionResult Index()
        {
         //   var genres = myEntiy.genre.ToList();
            var genres = genrebll.GetModelList("1=1");
            return View(genres);
        }

        //
        // GET: /Genre/Details/5

        public ActionResult Details(int id)
        {
            var genre = genrebll.GetModel(id);
            return View(genre);
        }

        //
        // GET: /Genre/Create

        public ActionResult Create()
        {

            return View();
        } 

        //
        // POST: /Genre/Create

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include="GenreId,Name,Description")] Maticsoft.Model.genre gmodel)
        {
            try
            {
                // TODO: Add insert logic here
                bool bflag=genrebll.Add(gmodel);
                return RedirectToAction("Index");
            }
            catch (Exception e)
            {
                
                return View(e.Message);
            }
        }
        
        //
        // GET: /Genre/Edit/5
 
        public ActionResult Edit(int id)
        {
            if (id == null) return new HttpStatusCodeResult(400,"无法获取编码");
           
            var genre = genrebll.GetModel(id);
            if (genre == null) return HttpNotFound();
            return View(genre);
        }

        //
        // POST: /Genre/Edit/5

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "GenreId,Name,Description")] Maticsoft.Model.genre gmodel)
        {
            try
            {
                // TODO: Add update logic here
                if (ModelState.IsValid)
                {
                    genrebll.Update(gmodel);

                }
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        //
        // GET: /Genre/Delete/5
 
        public ActionResult Delete(int id)
        {
            if (id == null)
            {

                return new HttpStatusCodeResult((int)System.Net.HttpStatusCode.BadRequest);
            }
            var genre = genrebll.GetModel(id);
            if (genre == null) return HttpNotFound();
            return View();
        }

        //
        // POST: /Genre/Delete/5

        [HttpPost,ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            try
            {
                // TODO: Add delete logic here
                genrebll.Delete(id);
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
