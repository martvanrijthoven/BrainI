using System.Collections.Generic;
using BrainI.Models.Planes;
using BrainI.Models;
using BrainI.Models.Data;

namespace BrainI.Content
{
	public class HomeContent
	{
		public static readonly string _PLANES = "Models/Data/Planes/"; 
		public List<Plane> planes { get; }

		public HomeContent ()
		{
			planes = new List<Plane> ();
			Dictionary<string,string> img = Files.getFiles_Path (_PLANES, "*.png");
			foreach (KeyValuePair<string, string> entry in img) {
				planes.Add (new Plane (entry.Key, entry.Value));
			}
		}
	}
}