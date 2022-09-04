using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.geometry.planar.sub_.directed_.connected_
{
	/// <summary>
	/// </summary>
	public class Polygon :
		nilnul.obj.Box<
			nilnul.geometry.planar.point.str_.Seq
			>
		,
		PolygonI
	{

		static public IEnumerable<planar.PointI1> AdjacentDedup(IEnumerable<planar.PointI1> points)
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
		public Polygon(nilnul.geometry.planar.point.str_.Seq val) : base(val)
		{
		}

		public Polygon(IEnumerable<PointI1> points):this(new point.str_.Seq(points))
		{

		}

		public nilnul.geometry.planar.point.str_.Seq points
		{
			get { return boxed; }
		}

		public IEnumerable<PointI1> vertexes => points;

		/// <summary>
		/// remove adjacent repeated points
		/// </summary>
		public void cannonize()
		{
			this.boxed = new point.str_.Seq( AdjacentDedup(this.boxed) );
		}




	}
}
