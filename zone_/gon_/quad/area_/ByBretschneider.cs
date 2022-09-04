using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.geometry.planar.zone_.gon_.quad.area_
{
	class ByBretschneider
	{
		/// <summary>
		/// of four edge lengths.
		/// </summary>
		/// <param name="a"></param>
		/// <param name="b"></param>
		/// <param name="c"></param>
		/// <param name="d"></param>
		/// <param name="sumOfOppositeAngle">
		/// for a pair of opposite angles.
		/// we would,not here, but later, halve this.
		/// </param>
		/// <returns></returns>
		static public double _Area_assumeEdges1OppositeAngleSum(double a,double b,double c,double d, double sumOfOppositeAngle) {

			var s = (a + b + c + d) / 2;
			var cos = Math.Cos(
				sumOfOppositeAngle/2
			);
			return Math.Sqrt(
				(s-a)
				*
				(s-b)
				*
				(s-c)
				*
				(s-d)
				-
				a*b*c*d* cos*cos
			);
		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="a"></param>
		/// <param name="b"></param>
		/// <param name="c"></param>
		/// <param name="d"></param>
		/// <param name="sumOfOppositeAngle"></param>
		/// <returns></returns>
		static public double _AreaByNotHalfAngle_assumeEdges1OppositeAngleSum(double a,double b,double c,double d, double sumOfOppositeAngle) {

			var s = (a + b + c + d) / 2;
			return Math.Sqrt(
				(s-a)
				*
				(s-b)
				*
				(s-c)
				*
				(s-d)
				-
				a*b*c*d* ( 1+Math.Cos(sumOfOppositeAngle))/2  // in trignometry: cos(t)**2 = (1+cos(2t))/2
			);
		}

	}
}
