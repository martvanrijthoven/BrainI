using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using BrainI.Models;
using BrainI.Models.Structures;
using System.Drawing;
using BrainI.Content;


namespace BrainI.Controllers
{
    public class StructuresController : Controller
	{			

			
		public ActionResult Index(string id)
		{
			//if (id == null )
				return View ("~/Views/Shared/Error.cshtml");
			string structure = id;
			//return View (new StructureContent (model.structures [structure].name, model.structures [structure].description));
		}
			
	
    }
}
