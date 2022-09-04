using nilnul.geometry.planar.tend_;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.geometry.planar.tend_.edge.str_.started.subsume_
{
	static public class _MaxX
	{
	


		public static EdgeD _Max(IEnumerable<EdgeD> edges_headed)
		{

			var r = edges_headed.First();
			var tail = edges_headed.Skip(1);

			if (tail.Count() == 0)
			{
				return r;
			}
			else
			{
				return geometry.planar.tend_.edge.co.band_._MaxX.Max(r, _Max(tail));
			}

		}
	}
}
