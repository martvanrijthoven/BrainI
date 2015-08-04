using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Mvc.Ajax;
using System.IO;
using BrainI.Models;
using System.Drawing;
using BrainI.Models.Structures;
using BrainI.Models.Planes;
using BrainI.Content;
using System.Threading.Tasks;
using System.Net;



namespace BrainI.Controllers
{
	public class HomeController : Controller
	{
		
		public static readonly string _PLANES = "Models/Data/Planes/"; 
		public ActionResult Index ()
		{
			return View ();
		}



		public ActionResult IndexPde ()
		{	
			return View (new HomeContent());
		}




		public String Test (string id)
		{
			//return View ("~/Views/StructureMaker/Index.cshtml");
			return id;
		}


		[HttpPost]
		public String Upload()
		{
			foreach (string upload in Request.Files)
			{
				string filename = Path.GetFileName(Request.Files[upload].FileName);
				Request.Files[upload].SaveAs(Path.Combine(_PLANES, filename));
				return "gelukt";
			}
			return "?";
		}

		[HttpPost]
		public ActionResult a()
		{
			//foreach (int [] i in m.Name)
			//	foreach (int p in i)
				//	System.Diagnostics.Debug.WriteLine(p);
			return Json(new { success = true});
		}



	}
}

