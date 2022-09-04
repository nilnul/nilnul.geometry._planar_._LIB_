using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.geometry.plane
{
	/// <summary>
	/// this will calculate the areas of the intersection of two circles.
	/// </summary>
	/// <remarks>
	/// http://mathworld.wolfram.com/Circle-CircleIntersection.html
	/// </remarks>
	public partial class CircleIntersection
	{
		/// <summary>
		/// 
		/// </summary>
		/// <param name="r1"></param>
		/// <param name="r2"></param>
		/// <param name="d">distance between the two circle centers.</param>
		/// <returns></returns>
		static public double Area(double r1,double r2,double d) {
			if (r1<0 || r2<0 || d<0)
			{
				throw new Exception("The radius or the distance cannot be negative.");
				
			}
			if (r1==0 || r2==0)
			{
				return 0;
				
			}

			if (d==0)
			{
				return Disc.Area(Math.Min(r1,r2));
				
			}


			if (d>=r1+r2)
			{
				return 0;
			}
			else
			{
				return _Area(r1, r2, d);
			}
		
		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="r1"></param>
		/// <param name="r2"></param>
		/// <param name="d"></param>
		/// <returns></returns>
		/// <remarks>
		///		r1+r2 le d
		///		
		///d !=0 
		///r!=0
		///R!=0
		/// </remarks>
		static private double _Area(double r1,double r2,double d) {
			double s=r1+r2+d;

			return r2*r2*Math.Acos(
					(d*d+r2*r2-r1*r1)/(2*d*r2)
				)
					+
				r1*r1*Math.Acos(
					(d*d+r1*r1-r2*r2)/(2*d*r1)
				)
					-
				.5*Math.Sqrt(
					(-d+r1+r2)*(d-r1+r2)*(d+r1-r2)*(d+r1+r2)
				);
		
		
		}
	}
}
