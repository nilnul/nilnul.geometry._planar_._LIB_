using nilnul.trigonometry;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.geometry.planar.angle
{
	static public class AngleX
	{


		static public double Degree2Radian(double degree)
		{
			return degree / 180 * Math.PI;
		}
		static public double Radian2Degree(double radian)
		{
			return radian / Math.PI * 180;
		}


		static public double Eval_0to2pi(double x, double y)
		{
			return Eval_0to2pi(new PointD(x,y));



		}


		static public double Eval_0to2pi(PointD p)
		{

			if (p.x == 0 && p.y == 0)
			{
				throw new Exception();

			}

			///the norm is computed with minimum rounding as M * sqrt(1 + m / M) 
			///
			///according to https://msdn.microsoft.com/en-us/library/vstudio/system.math.atan2(v=vs.100).aspx, the returned values of atan2 is in (-pi, pi]. Note the discrepancy there between the summary and detail.
			///
			var atan2 = Math.Atan2(p.y, p.x);


			return atan2 >= 0 ? atan2 : -atan2 + Math.PI;

		}




	}
}
