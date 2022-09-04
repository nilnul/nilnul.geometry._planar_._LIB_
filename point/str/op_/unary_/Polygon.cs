using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.geometry.planar.point.str.op_.unary_
{
	/// <summary>
	/// </summary>
	static public class _DelNilGradEsX
	
	{
		/// <summary>
		///
		/// there might be same points but they are not adjacent.
		///  the start and the end might still be the same.
		///  
		/// </summary>
		/// <param name="points"></param>
		/// <returns>
		/// empty if input is empty
		/// nonempty if input is not empty
		/// </returns>
		static public IEnumerable<planar.PointI1> DelNilGradEs(this IEnumerable<planar.PointI1> points)
		{
			var enumerator = points.GetEnumerator();
			if (enumerator.MoveNext())
			{
				var current = enumerator.Current;
				yield return current;

				while (enumerator.MoveNext())
				{
					if (nilnul.geometry.planar.point.eq.Ne.Singleton.ne(enumerator.Current,current ) )
					{
						current = enumerator.Current;
						yield return current;
					}
				}
			}
		}

		static public IEnumerable<Point4dblI> DelNilGradEs(Point4dblI point,  IEnumerator<Point4dblI> vertexes) {
			yield return point;
			while (vertexes.MoveNext() )
			{
				if (!nilnul.geometry.planar.point.EqDbl.Singleton.Equals(point,vertexes.Current) )
				{
					point = vertexes.Current;
					yield return point;
				}
			}
		}

		static public IEnumerable<Point4dblI> DelNilGradEs( IEnumerator<Point4dblI> vertexes) {
			if (vertexes.MoveNext() )
			{
				return DelNilGradEs(vertexes.Current,vertexes);
			}
			return Enumerable.Empty<Point4dblI>();
		}

		static public IEnumerable<Point4dblI> DelNilGradEs(this IEnumerable<Point4dblI> vertexes) {
			return DelNilGradEs(vertexes.GetEnumerator());
		}
	}
}