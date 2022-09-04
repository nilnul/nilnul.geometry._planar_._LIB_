using nilnul.geometry.planar.point;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.geometry.planar.curve_.algebraic_.bezier_.cubic.length_
{
	static public class _FlattenOvTimeX
	{
		static public IEnumerable<double> _Arcs_slicesAssumeStarted(
			Quo4dbl bezier
			,
			int _numberOfDivisions_positive
		)
		{
			int maxPoint = _numberOfDivisions_positive + 1;

			// _formula.GetPoint(t) is assumed to take a parameter t and return 
			// a point using the Bézier formula.  The _formula object would 
			// have the Bézier coefficients to calculate this.

			var previousPoint = cubic._InterpolateX._Interpolate_assumeProb(bezier,0);


			for (int i = 1; i <= maxPoint; i++)
			{
				var p =
					cubic._InterpolateX._Interpolate_assumeProb(bezier, (double)i / maxPoint);

					//bezier._interpolate_assumeProb(i / maxPoint);
				yield return 
					geometry.planar.tend._DistanceX.Distance(previousPoint, p);
				previousPoint = p;
			}

			

		}

		static public IEnumerable<double> _Arcs_slicesAssumeStarted(
			bezier_.Cubic4dbl bezier
			,
			int _numberOfDivisions_positive
		)
		{
			;
			int maxPoint = _numberOfDivisions_positive + 1;

			// _formula.GetPoint(t) is assumed to take a parameter t and return 
			// a point using the Bézier formula.  The _formula object would 
			// have the Bézier coefficients to calculate this.

			var previousPoint = bezier._interpolate_assumeProb(0);  // for Bézier == P0 control point


			for (int i = 1; i <= maxPoint; i++)
			{
				var p = bezier._interpolate_assumeProb((double) i / maxPoint);
				yield return 
					geometry.planar.tend._DistanceX.Distance(previousPoint, p);
				previousPoint = p;
			}

			

		}


		/// <summary>
		/// 
		/// </summary>
		/// <param name="_numberOfDivisions_positive">Some empirical investigation showed that around 100 divisions would yield estimates with less than .001 error, which would be half a pixel for a 500 pixel long curve. Close enough for the purpose at hand.</param>
		static public double _Length_slicesAssumeStarted(
			bezier_.Cubic4dbl bezier
			,
			int _numberOfDivisions_positive
		)
		{
			;
			int maxPoint = _numberOfDivisions_positive + 1;

			// _formula.GetPoint(t) is assumed to take a parameter t and return 
			// a point using the Bézier formula.  The _formula object would 
			// have the Bézier coefficients to calculate this.

			var previousPoint = bezier._interpolate_assumeProb(0);  // for Bézier == P0 control point

			double sum = 0;

			for (int i = 1; i <= maxPoint; i++)
			{
				var p = bezier._interpolate_assumeProb((double) i / maxPoint);
				sum +=
					geometry.planar.tend._DistanceX.Distance(previousPoint, p);
				previousPoint = p;
			}

			return sum;

		}


	}
}
