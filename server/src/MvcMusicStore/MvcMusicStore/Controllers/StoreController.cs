using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcMusicStore.Controllers
{
    public class StoreController : Controller
    {
        // GET: Store
        public string Index()
        {
            return "StoreController.Index";
        }

	    public string Browse(string data)
	    {
		    string message = HttpUtility.HtmlEncode("Store.Browse, data =" + data);
		    return message;
	    }
    }
}