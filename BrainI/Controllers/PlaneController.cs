using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using BrainI.Models;
using System.Drawing;
using BrainI.Models.Structures;
using BrainI.Content;

namespace BrainI.Controllers
{
    public class PlaneController : Controller
    {
		
		public ActionResult Index(String id)
        {
			if (id == null)
				return View ("~/Views/Shared/Error.cshtml");
			//TODO if plane not exsist? --> getCsvData error
			return View (new PlaneContent(id));
        }



		[HttpPost]
		public String ArrayUpload(List<String> values)
		{
			return "yes";

		}


    }
}
