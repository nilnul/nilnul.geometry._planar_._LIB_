using nilnul.geometry.planar.point;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.geometry.planar.curve_.algebraic_.bezier_
{
	/// <summary>
	/// note the mid points is not on the path; it is a control/clamping point.
	/// </summary>
	/// <remarks>
	///For some choices of P1 and P2 the curve may intersect itself, or contain a cusp.
	/// </remarks>
	public class Cubic4dbl
		:
		nilnul.obj.Box1<

		planar.point.Quo4dbl
			>
	{
		public Cubic4dbl(Quo4dbl val) : base(val)
		{
		}


		public Point4dblI _interpolate_assumeProb(double t)
		{

			var complement = 1 - t;

			return complement * new bezier_.Quadratic(
				boxed.enumerate().Take(3)
			).__interpolate_assumeProbPair(t, complement)
				+
			t * new bezier_.Quadratic(
				boxed.enumerate().Skip(1)
			).__interpolate_assumeProbPair(t, complement)
			;
		}

		/// <summary>
		/// by flatten.
		/// </summary>
		/// <param name="numberOfDivisions"></param>
		/// <returns></returns>
		public double length(int numberOfDivisions )
		{
			int maxPoint = numberOfDivisions + 1;

			// _formula.GetPoint(t) is assumed to take a parameter t and return 
			// a point using the Bézier formula.  The _formula object would 
			// have the Bézier coefficients to calculate this.

			var previousPoint = _interpolate_assumeProb(0);  // for Bézier == P0 control point

			var sum = 0d;

			for (int i = 1; i <= maxPoint; i++)
			{
				var  p = _interpolate_assumeProb(i / (double)maxPoint);
				sum += nilnul.geometry.planar.tend._DistanceX.Distance(previousPoint, p);
				previousPoint = p;
			}

			return sum;
			
		}






	}
}
