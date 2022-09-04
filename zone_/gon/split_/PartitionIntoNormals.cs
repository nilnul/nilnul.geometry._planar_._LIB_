using nilnul.geometry._2d.point;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.geometry._2d.polygon.s.op
{
	public partial class PartitionIntoNormals
	{

		static public IEnumerable<Polygon> Eval(Polygon polygon) {

			//
			List<Polygon> r = new List<Polygon>();

			List<PointInDouble> c = new List<PointInDouble>();	//always open


			//check to see if one point, if not the start point,  emerge twice


			foreach (var path in polygon.paths)
			{


				//check whether it interset with previous paths.


				
			}

			throw new NotImplementedException();
		
		}
	}
}
