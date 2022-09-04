using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Point = nilnul.geometry.planar.Point4dbl;
using Point1 = nilnul.geometry.planar.Point4dbl;

using PointD = nilnul.geometry.planar.Point4dbl;

namespace nilnul.geometry.planar.point.be_.nonnil.vow
{



	public class Asserted
		//: nilnul.bit.be.Asserted<planar.PointD, Be>
	{

		static public double _Angle_nonZeroPoint(double x, double y)
		{

			var atan2 = Math.Atan2(y, x);
			return atan2 >= 0 ? atan2 : -atan2 + Math.PI;

		}



		

		/// <summary>
		/// [0,2Pi)
		/// </summary>
		/// <returns></returns>
		static public  double angle(Point4dbl val)
		{

			var atan2 = Math.Atan2(val.y, val.x);
			return atan2 >= 0 ? atan2 : -atan2 + Math.PI;

		}
	}


}
