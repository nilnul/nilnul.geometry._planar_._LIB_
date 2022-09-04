using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.geometry.planar.sub_.directed_.connected_.gon
{
	static public class _GradsX
	{
		/// <summary>
		/// 
		/// </summary>
		/// <param name="headedPoints"></param>
		/// <returns></returns>
		/// <remarks>see: Eval_byMod</remarks>
		static public IEnumerable<point.Co> PointCoS(this nilnul.geometry.planar.point.StrI headedPoints)
		{
			var count = headedPoints.Count();
			for (int i = 0, j = 1; i < count; i++, j++)
			{
				yield return new point.Co(
					headedPoints.ElementAt(i), headedPoints.ElementAt(j % count)
				);
			}
		}
		static public IEnumerable<point.Co> PointCoS(this IEnumerable<Point1> _headed)
		{
			var count = _headed.Count();
			for (int i = 0, j = 1; i < count; i++, j++)
			{
				yield return new point.Co(
					_headed.ElementAt(i), _headed.ElementAt(j % count)
				);
			}
		}


		static public IEnumerable<planar.Grad> Grads_ifDwelt(this IEnumerable<PointI1> points_maybeEmpty)
		{
			if (points_maybeEmpty.Any())
			{
				for (int i = 1, j = 0; i < points_maybeEmpty.Count(); i++, j++)
				{
					yield return new Grad(points_maybeEmpty.ElementAt(j), points_maybeEmpty.ElementAt(i));
				}
				yield return new Grad(points_maybeEmpty.Last(), points_maybeEmpty.First());
			}
			else
			{
				yield break;
			}
		}

		static public IEnumerable<planar.Grad> Grads(IEnumerable<PointI1> _points_maybeEmpty)
		{

			var enumerator = _points_maybeEmpty.GetEnumerator();
			if (enumerator.MoveNext())
			{
				
				var _current = enumerator.Current;
				var first = _current;

				while (enumerator.MoveNext())
				{
					yield return new planar.Grad(_current, enumerator.Current);
					_current = enumerator.Current;

				}
				yield return new Grad(
					_current, first
				);
			}
			;
		}

		static public IEnumerable<planar.Grad> Grads(IEnumerable<Point1> points)
		{

			var enumerator = points.GetEnumerator();
			if (enumerator.MoveNext())
			{
				
				var _current = enumerator.Current;
				var first = _current;

				while (enumerator.MoveNext())
				{
					yield return new planar.Grad(_current, enumerator.Current);
					_current = enumerator.Current;

				}
				yield return new Grad(
					_current, first
				);

			}
			;

		}

		static public IEnumerable<planar.grad_.Step4dbl> Grads(IEnumerable<Point4dblI> points)
		{

			var enumerator = points.GetEnumerator();
			if (enumerator.MoveNext())
			{
				
				var _current = enumerator.Current;
				var first = _current;

				while (enumerator.MoveNext())
				{
					yield return new planar.grad_.Step4dbl(_current, enumerator.Current);
					_current = enumerator.Current;

				}
				yield return new grad_.Step4dbl(
					_current, first
				);

			}
			;

		}

		static public IEnumerable<planar.grad_.Step4dbl> Grads(IEnumerable<Point4dbl> points)
		{

			var enumerator = points.GetEnumerator();
			if (enumerator.MoveNext())
			{
				
				var _current = enumerator.Current;
				var first = _current;

				while (enumerator.MoveNext())
				{
					yield return new planar.grad_.Step4dbl(_current, enumerator.Current);
					_current = enumerator.Current;

				}
				yield return new grad_.Step4dbl(
					_current, first
				);

			}
			;

		}
		static public IEnumerable<planar.grad_.skid_.ByPoints4Dbl> _Arrows_assumeCompressed(this IEnumerable<Point4dbl> _points_distinct)
		{
			var enumerator = _points_distinct.GetEnumerator();
			if (enumerator.MoveNext())
			{
				
				var _current = enumerator.Current;
				var first = _current;

				while (enumerator.MoveNext())
				{
					yield return new planar.grad_.skid_.ByPoints4Dbl(_current, enumerator.Current);
					_current = enumerator.Current;
				}
				yield return new planar.grad_.skid_.ByPoints4Dbl(
					_current, first
				);
			}
			;
		}

		static public IEnumerable<planar.grad_.IArrow> _Arrows_assumeCompressed(this IEnumerable<PointI1> _points_distinct)
		{
			var enumerator = _points_distinct.GetEnumerator();
			if (enumerator.MoveNext())
			{
				
				var _current = enumerator.Current;
				var first = _current;

				while (enumerator.MoveNext())
				{
					yield return new planar.grad_.Arrow(_current, enumerator.Current);
					_current = enumerator.Current;
				}
				yield return new planar.grad_.Arrow(
					_current, first
				);
			}
			;
		}


		///// <summary>
		///// 
		///// </summary>
		//public IEnumerable<point.Co> Moves_(this IEnumerable<Point1> points)
		//{
		//	for (var i = 0; i < points.Count()-1; i++)
		//	{
		//		yield return new point.Co(points.ElementAt(i), points.ElementAt(i + 1));
		//	}
		//		if (val.ElementAt(i) == end)    ///if it's monogon, only one path, the closing path will be returned.
		//		{
		//			yield return closingPath;
		//			yield break;
		//		}
		//}
	}
}