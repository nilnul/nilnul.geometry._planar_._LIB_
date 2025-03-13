using nilnul.geometry.planar.point;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.geometry.planar.curve_.algebraic_.bezier_.cubic.interpolate_
{

	static public class _OnDistanceX
	{

		/// <summary>
		/// this will convert progression of distance to the progression of time. And then get the point over time.
		/// </summary>
		/// <param name="boxed"></param>
		/// <param name="timeSlices_positive"></param>
		/// <param name="progressionOfLength"></param>
		/// <returns></returns>
		static public double _ProgressionOfTime_timespansAssumePositive_lengthProgressionAssumeProb(

				Quo4dbl boxed, int timeSlices_positive, double progressionOfLength)
		{
			var distances = length_._FlattenOvTimeX._Arcs_slicesAssumeStarted(
					boxed
					,
					timeSlices_positive
				).ToArray();

			var cumulated = new nilnul.num.real.str.op_.unary_._add.Ret4dbl(distances).ToArray();

			return collective_.real.family_.field_.sigma_.borel.measure.cumulus._InverseX._Prob_assumeProbEquiPartite(
				cumulated
				,
				progressionOfLength
				*
				cumulated.Last()
			);


		}
		static public double _ProgressionOfTime_timespansAssumePositive_lengthProgressionAssumeProb(
			bezier_.Cubic4dbl bezier
			,
			int timeSlices_positive
			,
			double progressionOfLength
		)
		{
			var distances = length_._FlattenOvTimeX._Arcs_slicesAssumeStarted(
				bezier
				,
				timeSlices_positive
			).ToArray();

			var cumulated = new nilnul.num.real.str.op_.unary_._add.Ret4dbl(distances).ToArray();

			return collective_.real.family_.field_.sigma_.borel.measure.cumulus._InverseX._Prob_assumeProbEquiPartite(
				cumulated
				,
				progressionOfLength
				*
				cumulated.Last()
			);











		}
	}
}
