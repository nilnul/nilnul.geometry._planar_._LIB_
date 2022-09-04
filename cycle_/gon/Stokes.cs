using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.geometry.planar.cycle_.gon
{
	static public class _StokesX
	{
		static public double Stokes(Polygon4dbl polygon) {

			return planar.coil_.gon._SurroundedX.Stokes(

				polygon.ee

			);

		}

		public static double Stokes(Triangle4dblI obj)
		{
			return planar.coil_.gon._SurroundedX.Stokes(

				obj.vertexes

			);

		}

		public static double _Stokes_assumeCycle(IEnumerable<Point4dblI> enumerable)
		{
			return planar.coil_.gon._SurroundedX.Stokes(

				enumerable

			);

		}
	}
}
