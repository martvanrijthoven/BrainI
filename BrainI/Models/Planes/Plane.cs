using System;
using System.Collections.Generic;

namespace BrainI.Models.Planes
{
	public class Plane
	{
		public string Name		{ get; }
		public string ImgDir	{ get; }

		public Plane(string name, string imgDir ){
			this.Name 	= name;
			this.ImgDir = imgDir;
		}
	}
}

