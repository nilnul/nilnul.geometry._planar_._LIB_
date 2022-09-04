using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.geometry.planar.sub_.directed_.connected_.chain.of_
{
	static public class _VertexesX
	{
		static public IEnumerable<planar.Grad4dbl_byPoints> Grads(
			planar.Point4dblI initial
			,
			IEnumerator<planar.Point4dblI> points
		) {

			while (points.MoveNext())
			{
				yield return new Grad4dbl_byPoints(initial,points.Current);
				initial = points.Current;

			}
		}

		static public IEnumerable<planar.Grad4dbl_byPoints> Grads(
			planar.Point4dblI initial
			,
			IEnumerable<planar.Point4dblI> points
		) {

			return Grads(initial,points.GetEnumerator());
		}

		public static IEnumerable<Grad4dbl_byPoints> Grads(
			(Point4dblI, IEnumerable<Point4dblI>) p
		)
		{
			return Grads(
				p.Item1
				,
				p.Item2
			);
		}
		static public IEnumerable<planar.Grad4dbl_byPoints> Grads(
			this IEnumerable<planar.Point4dblI> points
		) {
			if (points.Any())
			{
				return Grads( nilnul.obj.str_.started._Head1torsoX.Head1torso(points) );

			}
			return new planar.Grad4dbl_byPoints[0];
		}


	}
}
