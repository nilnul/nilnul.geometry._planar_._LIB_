//using nilnul.geometry.planar.point.str_.started;
//using nilnul.geometry.planar.trail_.cloze_.polygon_.points;
//using nilnul.num;

using System.Collections.Generic;
using System.Numerics;

namespace nilnul.geometry.planar.cloze_.trigon
{
	interface IParallelogram { }

	static public class _ParallelogramX
	{

		static public IEnumerable<Complex> Parallelogram(
			Complex a
			,
			Complex b
			,
			Complex c
		) {
			yield return a
				;
			yield return b;

			yield return c;

			yield return a+c - b ;
		}
	}
}
