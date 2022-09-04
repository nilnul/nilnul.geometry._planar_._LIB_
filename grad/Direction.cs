using nilnul.geometry.planar.rotation_;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.geometry.planar.grad
{
	static public class _DirectionX
	{

	


		public static double Direction(planar.Grad4dblI stop)
		{
			return planar.vect._DirectionX._Ge0LtTau(
				stop.vect
			);

		}

		/// <summary>
		/// when vect is nil, return 0. 
		/// </summary>
		/// <param name="stop"></param>
		/// <returns></returns>
		public static double GtNegPiLePi(planar.Grad4dblI stop)
		{
			return planar.vect._AzimuthX.GtNegPiLePi(
				stop.vect
			);

		}

		public static double GtNegPiLePi(planar.Grad4dbl_byPointsI stop)
		{
			return planar.vect._AzimuthX.GtNegPiLePi(
				stop.Vect()
			);

		}


		public static double Direction(Point4dblI point, Point4dblI point4turn)
		{
			return Direction(
				new planar.grad_.Step4dbl(point,point4turn)
			);
			;
		}
		public static double GtNegPiLePi(Point p1, Point p2)
		{

			return GtNegPiLePi(
				new planar.Grad4dbl_byPoints(p1,p2)
			);
		}

	}
}
