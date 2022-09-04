using nilnul.geometry.planar.point;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.geometry.planar.curve_.bezier_._cubic_.parameterized_
{
	/// <summary>
	/// transform the formula into SumOfProduct
	/// </summary>
	/// <remarks>
	/// </remarks>
	static public class _Sop
	{
		/// <summary>
		/// </summary>
		/// <param name="t"></param>
		/// <param name="complement"></param>
		/// <returns></returns>
		static public Point4dbl _Interpolate_assumeProbPair(
			Quo4dbl boxed
			,
			double t
		)
		{
			var tSq = nilnul.num.real.op_.unary_.Square.Singleton.op(t);
			//var tComplementSq = nilnul.num.real.op_.unary_.Square.Singleton.op(complement);
			var tCubed = tSq * t;

			return

				tCubed

				 * (
					 boxed.d.ToOrthogonal()
					 - 3 * boxed.c.ToOrthogonal()
					 + 3 * boxed.b.ToOrthogonal()
					 - boxed.a.ToOrthogonal()
				 )
				+
				tSq *
				(
					3 * boxed.c.ToOrthogonal()
					- 6 * boxed.b.ToOrthogonal()
					+ 3 * boxed.a.ToOrthogonal()
				)
				+
				t *
				(
					3 * boxed.b.ToOrthogonal()
					- 3 * boxed.a.ToOrthogonal()
				)
				+
				(
					boxed.a.ToOrthogonal()
				)
			;
		}

		/// <summary>
		/// dx/dt, dy/dt
		/// </summary>
		/// <param name="boxed"></param>
		/// <param name="t"></param>
		/// <param name="complement"></param>
		/// <returns></returns>
		static public Vect4dbl _DerivativeOnTime_assumeProbPair(
			Quo4dbl boxed
			,
			double t
		)
		{
			var tSq = nilnul.num.real.op_.unary_.Square.Singleton.op(t);
			//var tComplementSq = nilnul.num.real.op_.unary_.Square.Singleton.op(complement);
			//var tCubed = tSq * t;

			return new geometry.planar.Vect4dbl(
				3 * tSq
				 * (
					 boxed.d.ToOrthogonal()
					 - 3 * boxed.c.ToOrthogonal()
					 + 3 * boxed.b.ToOrthogonal()
					 - boxed.a.ToOrthogonal()
				 )
				+
				2 * t *
				(
					3 * boxed.c.ToOrthogonal()
					- 6 * boxed.b.ToOrthogonal()
					+ 3 * boxed.a.ToOrthogonal()
				)
				+
				(
					3 * boxed.b.ToOrthogonal()
					- 3 * boxed.a.ToOrthogonal()
				)
			);
		}
	}
}