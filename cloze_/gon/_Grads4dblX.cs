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
	static public class _Grads4dblX
	{
	
		static public IEnumerable<planar.Grad4dbl_byPoints> _Grads_ofStarted(
			this IEnumerable<Point4dblI> _headed
		) {

			return _CoEs_0dwelt(_headed).Select(x=> new Grad4dbl_byPoints(x));
		}
		static public IEnumerable<planar.Grad4dbl_byPoints> _Grad8pointEs_0started(
			this IEnumerable<Complex> _headed
		) {

			return _Grads_ofStarted(_headed.Select( c=> planar.PointX.ToPoint(c)));
		}


		static public IEnumerable<(T start, T end)> _CoEs_0dwelt<T>(
			IEnumerator<T> vertices
		) {
			vertices.MoveNext();


			var point0 = vertices.Current;

			var first = point0;

			while (vertices.MoveNext())
			{
				yield return (point0, point0 = vertices.Current);
			}
			yield return (point0, first);

		}
		static public IEnumerable<(Point4dbl start, Point4dbl end)> _CoEs_0dwelt(
			IEnumerator<Point4dbl> vertices
		) {
			return _CoEs_0dwelt<Point4dbl>(vertices);

		}

		static public IEnumerable<(T start, T end)> _CoEs_0dwelt<T>(
			IEnumerable<T> vertices
		) {
			return _CoEs_0dwelt(
				vertices.GetEnumerator()
			);

		}

		static public IEnumerable<(Point4dbl start, Point4dbl end)> _CoEs_0dwelt(
			IEnumerable<Point4dbl> vertices
		) {
			return _CoEs_0dwelt(
				vertices.GetEnumerator()
			);

		}


		[Obsolete(nameof(_CoEs_0dwelt))]
		static public IEnumerable<(Point4dblI, Point4dblI)> _PointCoEs_ofStarted(this IEnumerable<Point4dblI> _points_distinct)
		{


			var last = _points_distinct.Last();
			foreach (var item in _points_distinct)
			{
				yield return (last, item);
				last = item;
			}
		}

	
	}
}