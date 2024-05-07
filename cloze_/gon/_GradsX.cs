using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.geometry.planar.cloze_.gon
{
	/// don't place as extension to <see cref="planar.point.str_.started"/>, as this is a cloze, not a simple curve. The last point shall be connected to the first point.
	/// <summary>
	/// 
	/// </summary>
	/// <seealso cref="sub_.directed_.connected_._polygon.vertexes._GradsX"/>
	static public class _GradsX
	{
		/// <summary>
		/// 
		/// </summary>
		/// <param name="headedPoints"></param>
		/// <returns></returns>
		/// <remarks>see: Eval_byMod</remarks>
		static public IEnumerable<point.Co> Moves_byPickLast(this nilnul.geometry.planar.point.str_.seq_.Started headedPoints)
		{

			for (int i = 0; i < headedPoints.Count() - 1; i++)
			{
				yield return new point.Co(
					headedPoints.ElementAt(i), headedPoints.ElementAt(i + 1)
				);
			}

			yield return new point.Co(headedPoints.Last(), headedPoints.First());
		}

		static public IEnumerable<point.Co> Moves(this nilnul.geometry.planar.point.str_.seq_.Started headedPoints)
		{
			var count = headedPoints.Count();

			for (int i = 0, j = 1; i < count; i++, j++)
			{
				yield return new point.Co(
					headedPoints.ElementAt(i), headedPoints.ElementAt(j % count)
				);
			}

		}
		static public IEnumerable<point.Co> _Moves(
			this IEnumerable<Point1> _headed
		)
		{
			var count = _headed.Count();

			for (int i = 0, j = 1; i < count; i++, j++)
			{
				yield return new point.Co(
					_headed.ElementAt(i), _headed.ElementAt(j % count)    /// count must be positive
				);
			}

		}
		public static IEnumerable<(Complex start, Complex stop)> _Grads_0started(
			params Complex[] a
		)
		{

			return _Grads_0started(
				(IEnumerable<Complex>)a
			);
		}

		public static IEnumerable<(Complex start, Complex stop)> _Grads_0started(
			IEnumerable<Complex> a
		)
		{

			return _CoEs_0dwelt(a.GetEnumerator());
		}
		public static IEnumerable<((double,double) start, (double,double) stop)> _Grads_0started(
			IEnumerable<(double,double)> a
		)
		{

			return _CoEs_0dwelt(a.GetEnumerator());
		}

		//static public IEnumerable<(T start, T end)> _CoEs_0dwelt<T>(
		//	IEnumerable<T> vertices
		//) {
		//	return _CoEs_0dwelt(
		//		vertices.GetEnumerator()
		//	);

		//}

		static public IEnumerable<(T start, T end)> _CoEs_0dwelt<T>(
				IEnumerator<T> vertices
			)
		{
			vertices.MoveNext();


			var point0 = vertices.Current;

			var first = point0;

			while (vertices.MoveNext())
			{
				yield return (point0, point0 = vertices.Current);
			}
			yield return (point0, first);

		}


	}
}