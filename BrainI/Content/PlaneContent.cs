using System.Collections.Generic;
using System.Drawing;
using BrainI.Models;
using BrainI.Models.Planes;
using BrainI.Models.Structures;
using BrainI.Models.Data;

namespace BrainI.Content
{
	public class PlaneContent{

		public static readonly string _PLANES = "Models/Data/Planes/";
		public static readonly string _STRUCTURES	= "Models/Data/Structures/"; 

		public List<Structure>  structures 	{ get; }
		public Plane 			plane		{ get; }
		 

		public PlaneContent(string p){
			structures = new List<Structure> ();
			createStructures (p);
			plane = new Plane(p,("/~/"+_PLANES + p + ".Plane.png"));
		}

		private void createStructures(string plane){
			string[] names = Files.getDirNames (_STRUCTURES);
			string[] descriptions = Files.getDescriptions (_STRUCTURES,names);

			if (names.Length > 0) 
				for (int i = 0; i < names.Length; i++) { 
					List<Point> points = new List<Point> ();;
					string csvDir = _STRUCTURES+names[i]+"/csv/"+plane+"."+names[i]+".csv";
					if(Files.CsvsToPoints (csvDir,ref points))
						structures.Add (new Structure (i, names [i], points, descriptions[i]));
				}
		}
	}
}
