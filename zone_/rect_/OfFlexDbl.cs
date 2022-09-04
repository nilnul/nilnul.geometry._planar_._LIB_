using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Point = nilnul.geometry.planar.Point4dbl;
using EdgeD = nilnul.geometry.planar.tend_.EdgeD;

using DistinctPoints = nilnul.geometry.planar.point.trio.be_.distinct.vow.Ee;
using Point1 = nilnul.geometry.planar.Point4dbl;
using PointD = nilnul.geometry.planar.Point4dbl;
using nilnul.geometry.planar.zone_.trigon_;
using nilnul.geometry.planar.tend_;
//using nilnul.geometry.planar.zone_.polygon_.tri_.perpend_;
//using nilnul.geometry.planar.zone_.polygon_.tri_;

namespace nilnul.geometry.planar.zone_.rect_
{
	/// <summary>
	/// of a flex triangle
	/// </summary>
	public class OfFlexDbl
		: nilnul.obj.Box1<
			planar.zone_.trigon_.Perpend_byFlexQuarterDbl
		>
		,
		zone_.Polygon4dblI
	{
		public OfFlexDbl(Perpend_byFlexQuarterDbl val) : base(val)
		{
		}

		public PointD a
		{
			get { return boxed.ee.ee.a; }
		}


		public PointD b
		{
			get { return boxed.ee.ee.b; }
		}

		public PointD c
		{
			get { return boxed.ee.ee.c; }
		}


		public PointD d
		{
			get
			{

				return a + c - b;

			}
		}
		public IEnumerable<grad_.skid_.ByPoints4Dbl> arrows
		{
			get
			{
				yield return new grad_.skid_.ByPoints4Dbl(a, b);
				yield return new grad_.skid_.ByPoints4Dbl(b, c);
				yield return new grad_.skid_.ByPoints4Dbl(c, d);
				yield return new grad_.skid_.ByPoints4Dbl(d, a);
			}
		}

		public IEnumerable<Point4dblI> vertexes => new Point4dblI[] { a,b,c,d};

		public IEnumerable<Grad4dbl_byPointsI> grads => arrows;

		static public OfFlexDbl _Create(IEnumerable<PointD> points)
		{
			return new OfFlexDbl(
			  new Perpend_byFlexQuarterDbl(points)
			);

		}

		



	}
}
