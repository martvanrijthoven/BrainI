using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using BrainI.Models.Planes;

namespace BrainI.Models.Data
{
	public static class Files
	{
		

		public static string [] getDirNames(string dir){
			// TODO error empty
			string[] dir_names = Directory.GetDirectories (dir);
			for(int i=0; i<dir_names.Length; i++)
				dir_names [i] = dir_names [i].Remove (0, dir.Length);
			return dir_names;
		}
			

		/*
		*	Takes a directory(dir) and an extension(ext)
		*	Returns all the filenames and paths in the directory dir with extension ext
		*	in a Dictionary where the Key is the filename splited by '.'
		*				and where the Value is the the path of the file  
		*/

		public static  Dictionary<string, string>  getFiles_Path(string file_dir, string ext){
			
			string[] filenames  = Directory.GetFiles (file_dir, ext);
			Dictionary<string, string> files = new Dictionary<string, string>();
			foreach (string _f in filenames) {
				string f = Path.GetFileName (_f);
				files.Add (f.Split('.')[0], "/~/"+_f);
			}
			return files;			
		}
			
		public static bool CsvsToPoints(string csvDir, ref List<Point> points){
			StreamReader reader;
			try {
				reader = new StreamReader (File.OpenRead (csvDir));
			}catch{ return false; }
				
			while (!reader.EndOfStream) {
				string[] values = reader.ReadLine ().Split (',');
				points.Add (new Point (Convert.ToInt32 (values [0]), Convert.ToInt32 (values [1])));
			}	
			return true;
		}
			

		public static string [] getDescriptions(string path, string[] name){
			string[] descriptions = new string[name.Length];
			for(int i=0; i<name.Length; i++){
				try {
				descriptions [i] = File.ReadAllText(path + name[i] + "/Descriptions/" + name[i] + ".txt");
				}
				catch { break; } // TODO error 
				if(descriptions[i].Length > 0)
					descriptions [i] = descriptions [i].Substring (0, descriptions [i].Length - 1);
			}
			return descriptions;
		}

	}
}	