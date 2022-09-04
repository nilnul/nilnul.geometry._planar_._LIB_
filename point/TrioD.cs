using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Point1 = nilnul.geometry.planar.Point4dbl;
using PointD = nilnul.geometry.planar.Point4dbl;

using System.Collections;

namespace nilnul.geometry.planar.point
{
	public  class TrioD
		:IEnumerable<Point4dbl>
	{
		private Point4dbl _a;

		public Point4dbl a
		{
			get { return _a; }
			set { _a = value; }
		}
		private Point4dbl _b;

		public Point4dbl b
		{
			get { return _b; }
			set { _b = value; }
		}

		private Point4dbl _c;

		public Point4dbl c
		{
			get { return _c; }
			set { _c = value; }
		}

		public TrioD(Point4dbl a, Point4dbl b, Point4dbl c)
		{
			_a = a;
			_b = b;
			_c = c;
		}

		public TrioD(Point4dblI a, Point4dblI b, Point4dblI c)
		{
			_a = new Point4dbl( a);
			_b =new Point4dbl(  b);
			_c = new Point4dbl( c);
		}


		public TrioD(IEnumerable<Point4dbl> enumerable):this(
			enumerable.ElementAt(0)
			,enumerable.ElementAt(1)
			, enumerable.ElementAt(2)
		)
		{
		}

		public TrioD(IEnumerable<Point4dblI> enumerable):this(
			enumerable.ElementAt(0)
			,enumerable.ElementAt(1)
			, enumerable.ElementAt(2)
		)
		{
		}

		public TrioD toReverse() {
			return _Create(
				this.Reverse()	
			);
		}

		static public TrioD _Create(IEnumerable<Point4dbl> points)
		{
			nilnul.obj.s.b.Trio<Point4dbl>.Assert.Assert(points);

			return new TrioD(points.First(), points.ElementAt(1), points.ElementAt(2));



		}

		public IEnumerator<Point4dbl> GetEnumerator()
		{
			yield return a;
			yield return b;
			yield return c;

			//throw new NotImplementedException();
		}

		IEnumerator IEnumerable.GetEnumerator()
		{
			return GetEnumerator();
			throw new NotImplementedException();
		}

		public IEnumerable<double> edgeLength_s() {
			yield return planar.tend._DistanceX.Distance(a, b);
			yield return planar.tend._DistanceX.Distance(b, c);
			yield return planar.tend._DistanceX.Distance(c, a);

		}

		public double edgeLength_ab() {
			 return planar.tend._DistanceX.Distance(a, b);

		}

		public double edgeLength_bc() {
			 return planar.tend._DistanceX.Distance(b, c);

		}
		public double edgeLength_ca() {
			 return planar.tend._DistanceX.Distance(c, a);

		}

	}
}
