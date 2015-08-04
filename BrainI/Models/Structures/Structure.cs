using System;
using System.Collections.Generic;
using System.Drawing;



namespace BrainI.Models.Structures
{
	public class Structure
	{
		
		public int 			Id			{ get; }		
		public string 		Name		{ get; }
		public List<Point> 	CsvData		{ get; }
		public string 		Description { get; }

		public Structure (int id, string name,  List<Point> csvData, string description)
							 //#todo -> connection
		{
			this.Id = id;
			this.Name = name;
			this.CsvData = csvData;
			this.Description = description;
		}
	}
}

