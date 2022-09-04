using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using R = nilnul.num.RealI;
using r = nilnul.num.real;

namespace nilnul.geometry.planar.point.deviation_
{
	public static  class _ApproxiateX
	{


		/// <summary>
		/// distance to origin
		/// </summary>
		/// <param name="p"></param>
		/// <returns></returns>
		static public double Deviation(Point4dbl p)
		{

			var m = Math.Min(p.x, p.y);
			var M = Math.Max(p.x, p.y);

			var mOverM = m / M;


			///the norm is computed with minimum rounding as M * sqrt(1 + m / M) 
			///

			return M * Math.Sqrt(1 + mOverM * mOverM);

		}


	}
}
