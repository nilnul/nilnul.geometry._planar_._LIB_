using nilnul.geometry.planar.point;
using nilnul.geometry.planar.point.trio.be_.tripod.vow;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.geometry.planar.cycle_
{

	

	public  class Triangle
		:
		planar.point.trio.be_.tripod.vow.Ee
		,

		TrigonI
	{

		public Triangle(PointI1 b, PointI1 a, PointI1 c):this(new Trio(b,a,c))
		{
		}

		public Triangle(Trio val) : base(val)
		{
		}
		public Triangle(TrigonI obj):this( obj.pointTrio)
		{

		}

		public Triangle(IEnumerable<PointI1> points):this(new Trio(points.First(), points.ElementAt(1), points.ElementAt(2)))
		{
		}

		public Triangle(int v1, int v2, int v3, int v4, int v5, int v6):this(
			new Point1(v1,v2)
			,
			new Point1(v3,v4)
			,
			new Point1(v5,v6)

		)
		{
		}

		public IEnumerable<planar.grad_.Arrow> arrows
		{
			get
			{
				yield return new grad_.Arrow(ee.a, this.ee.b);
				yield return new grad_.Arrow(ee.b, ee.c);
				yield return new grad_.Arrow(ee.c, ee.a);
			}
		}

		public Ee pointTrio => this;

		public grad_.Arrow edge()
		{
			return new grad_.Arrow(ee.a, ee.b);
		}

		public grad_.Arrow edge1()
		{
			return new grad_.Arrow(ee.b, ee.c);
		}

		public grad_.Arrow edge2()
		{
			return new grad_.Arrow(ee.c, ee.a);
		}

		public IEnumerable<nilnul.num.RealI> lengths {
			get {
				yield return nilnul.geometry.planar.tend._DistanceX.Distance(
					edge()
				);
				yield return nilnul.geometry.planar.tend._DistanceX.Distance(
					edge1()
				);
				yield return nilnul.geometry.planar.tend._DistanceX.Distance(
					edge2()
				);

			}
		}

		public Triangle toReverse()
		{
			return new Triangle(
				ee.toReverse()
			);
		}

		static public Triangle _Create(IEnumerable<Point1> points)
		{
			return new Triangle(nilnul.geometry.planar.point.Trio._Create(points));
		}

		public Triangle toAntiClockwiseDirectionS()
		{

			var cPosition =  nilnul.geometry.planar.lead.vsPoint._LayoutX.LeewayFalse(
				new planar.Lead(this.ee.a, this.ee.b)
				,
				(this.ee.c)
			);

			if (cPosition ==true)
			{
				return this;

			}
			else
			{
				return new Triangle(this.ee.b, this.ee.a, this.ee.c);

			}


		}





	}

}
