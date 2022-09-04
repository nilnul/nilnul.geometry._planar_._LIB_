using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using E = nilnul.geometry.planar.Tend4dblI;
using D = nilnul.geometry.planar.point.Co;

namespace nilnul.geometry.planar.point.co.s.headed
{
	static public class MinX
	{


		static public D _Min(this IEnumerable<D> edges_headed) {

			var r = edges_headed.First();

			if (edges_headed.Skip(1).Count()==0)
			{
				return r;
			}
			else
			{
				return geometry.planar.tend.co.band_._MinX.Min(r,  _Min(edges_headed.Skip(1)) );
			}

			
		}
	}
}
