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

namespace nilnul.geometry.planar.zone_
{
	public class Rect
		: nilnul.obj.Box1<
			planar.zone_.trigon_.Perpend
		>
	{
		public Rect(Perpend val) : base(val)
		{
		}

		public PointI1 a
		{
			get { return boxed.pointsApexFirst.Last(); }
		}


		public PointI1 b
		{
			get { return boxed.pointsApexFirst.First(); }
		}

		public PointI1 c
		{
			get { return boxed.pointsApexFirst.Skip(1).First(); }
		}


		public Point1 d
		{
			get
			{

				return a.ToPoint() + c - b;

			}
		}
		public IEnumerable<grad_.Arrow> arrows
		{
			get
			{
				yield return new grad_.Arrow(a, b);
				yield return new grad_.Arrow(b, c);
				yield return new grad_.Arrow(c, d);
				yield return new grad_.Arrow(d, a);
			}
		}


		static public Rect _Create(IEnumerable<PointI1> points)
		{
			return new Rect(
			  new Perpend (points)
			);

		}

		



	}
}
