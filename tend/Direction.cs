using nilnul.geometry.planar.rotation_;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.geometry.planar.tend
{
	static public class _AlignmentX
	{

		public static double GtNegPiLePi(Point4dblI point, Point4dblI point4turn)
		{
			return planar.vect._AzimuthX.GtNegPiLePi(
				nilnul.geometry.planar.grad._DisplaceX.Vect(point,point4turn)
			);
		}

		/// <summary>
		/// when vect is nil, return 0. 
		/// </summary>
		/// <param name="stop"></param>
		/// <returns></returns>
		public static double GtNegPiLePi(planar.Tend4dblI stop)
		{
			return GtNegPiLePi(
				stop.points.component
				,
				stop.points.component1
			);

		}


	}
}
