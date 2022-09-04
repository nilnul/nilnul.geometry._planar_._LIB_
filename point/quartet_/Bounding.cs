using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.geometry.planar.point.quartet_
{
	/// <summary>
	/// all the same; or a rect
	/// </summary>
	public class Bounding
		:Quartet
	{

		private Bounding(PointI1 a, PointI1 b, PointI1 c, PointI1 d)
			:base(a,b,c,d)
		{

		}

		static public Bounding GetBoundingBox(IEnumerable<nilnul.geometry.planar.PointI1> _points_started) {


			var minX = nilnul.num.real.aggregate_.Min.Eval(_points_started.Select( p => p.x));

			var minY = nilnul.num.real.aggregate_.Min.Eval(_points_started.Select( p => p.y));

			var maxX = nilnul.num.real.aggregate_.Max.Eval(_points_started.Select( p => p.x));

			var maxY = nilnul.num.real.aggregate_.Max.Eval(_points_started.Select( p => p.y));

			return new Bounding(
				new Point1(
					minX,minY
				)
				,
				new Point1(
					maxX,minY
				)
				,
				new Point1(
					minX,maxY
				)
				,
				new Point1(
					maxX,maxY
				)
			);

		}
	}
}
