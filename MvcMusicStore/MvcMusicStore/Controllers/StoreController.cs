using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Maticsoft.Model;
using System.Data.Entity;
using Maticsoft.BLL;
using System.Data;

namespace MvcMusicStore.Controllers
{
    public class StoreController : Controller
    {
     //   MusicStoreEntities storeDb = new MusicStoreEntities();
     //   mymusicEntities mydb = new mymusicEntities();
        //
        // GET: /Store/
        Maticsoft.BLL.genre genrebll = new Maticsoft.BLL.genre();
        public ActionResult Index()
        {
         //   Database.SetInitializer(new DropCreateDatabaseIfModelChanges<MusicStoreEntities>());
            /*
            var genres = new List<Genre>{
                new Genre{Name="Disco"},
                new Genre{Name="Jazz"},
                new Genre{Name="Rock"}
            };
             */
        //    storeDb.Genres.Add(new Genre{Name="小李子" ,Description="演员"});
       //     storeDb.SaveChanges();
           
         //   var genres = storeDb.Genres.ToList();
           // var genres = mydb.genre.ToList();
          
            var genres = genrebll.GetModelList("1=1");

            return View(genres);
           
        }
        public ActionResult Browse(string genre)
        {
        //    string message = HttpUtility.HtmlEncode("store.browse,Genre=" + genre);
          //  var genreModel = new genre { Name = genre };
            string sqlcmd = String.Format(@"Name='{0:s}'", genre);
            var genreModel = genrebll.GetgenreWithAlbum(sqlcmd);
            return View(genreModel);
        }
        public ActionResult Details( int id)
        {
          //  string message = "Store.Details.id=" + id;
       //     var album = new album { Title = "Album" + id };
            Maticsoft.BLL.album albumbll = new Maticsoft.BLL.album();
            var Album= albumbll.GetModelAll(id);
            return View(Album);
        }
        [ChildActionOnly]
        public ActionResult GenreMenu()
        {
            var genres = genrebll.GetModelList("1=1");
            /*
            var genres = new List<Maticsoft.Model.genre>{
                new Maticsoft.Model.genre{GenreId=1,Name="Disco"},
                new Maticsoft.Model.genre{GenreId=2,Name="Jazz"},
                new Maticsoft.Model.genre{GenreId=4,Name="Rock"}
              };*/
            return PartialView(genres);
        }

    }
}
