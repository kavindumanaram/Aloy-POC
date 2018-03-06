using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MvcMusicStore.Models;

namespace MvcMusicStore.Controllers
{
    public class StoreController : Controller
    {
		MusicStoreEntities storeDB = new MusicStoreEntities();

        // GET: Store
        public ActionResult Index()
        {
			 List<Genre> genres = storeDB.Genres.ToList();
			return View(genres);
		}

	    public ActionResult Details(int id)
	    {
		   // var album = new Album { Title = "Album " + id };
		    var album = storeDB.Albums.Find(id);
		    return View(album);
	    }

	    public ActionResult Browse(string genre)
	    {
		    var generalModel = storeDB.Genres.Include("Albums").Single(g => g.Name == genre);
		    return View(generalModel);
	    }
    }
}