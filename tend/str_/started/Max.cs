using nilnul.geometry.planar.tend_;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.geometry.planar.tend.str_.started
{
	static public class MaxX
	{
		static public point.CoD _Max(this IEnumerable<planar.point.CoD> edges_headed)
		{

			var r = edges_headed.First();

			if (edges_headed.Skip(1).Count() == 0)
			{
				return r;
			}
			else
			{
				return geometry.planar.tend.co.band_._MaxX.Max(r, _Max(edges_headed.Skip(1)));
			}


		}
		static public Tend4dblI _Max(IEnumerable<Tend4dblI> edges_headed) {


			var r = edges_headed.First();

			if (edges_headed.Skip(1).Count() == 0)
			{
				return r;
			}
			else
			{
				return geometry.planar.tend.co.band_._MaxX.Max(r, _Max(edges_headed.Skip(1)));
			}

				;
		}

		static public Tend4dbl _Max(IEnumerable<Tend4dbl> edges_headed) {


			var r = edges_headed.First();

			if (edges_headed.Skip(1).Count() == 0)
			{
				return r;
			}
			else
			{
				return geometry.planar.tend.co.band_._MaxX.Max(r, _Max(edges_headed.Skip(1)));
			}

				;
		}

		public static Tend4dblI _Max(IEnumerable<EdgeD> edges_headed)
		{

			var r = edges_headed.First();
			var tail = edges_headed.Skip(1);

			if (tail.Count() == 0)
			{
				return r;
			}
			else
			{
				return geometry.planar.tend.co.band_._MaxX.Max(r, _Max(tail));
			}

		}
	}
}
