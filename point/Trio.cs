
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using P = nilnul.geometry.planar.PointI1;
using System.Collections;
using R = nilnul.num.RealI;

namespace nilnul.geometry.planar.point
{
	public  class Trio
		:IEnumerable<P>
	{
		private P _a;

		public P a
		{
			get { return _a; }
			set { _a = value; }
		}
		private P _b;

		public P b
		{
			get { return _b; }
			set { _b = value; }
		}

		private P _c;

		public P c
		{
			get { return _c; }
			set { _c = value; }
		}

		public Trio(P a, P b, P c)
		{
			_a = a;
			_b = b;
			_c = c;
		}

		public Trio toReverse() {
			return _Create(
				this.Reverse()	
			);
		}

		static public Trio _Create(IEnumerable<P> points)
		{
			nilnul.obj.s.b.Trio<P>.Assert.Assert(points);

			return new Trio(points.First(), points.ElementAt(1), points.ElementAt(2));



		}

		public IEnumerator<P> GetEnumerator()
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

		public IEnumerable<R> edgeLength_s() {
			yield return tend._DistanceX.Distance(a, b);
			yield return tend._DistanceX.Distance(b, c);
			yield return tend._DistanceX.Distance(c, a);

		}

		public R edgeLength_ab() {
			 return tend._DistanceX.Distance(a, b);

		}

		public R edgeLength_bc() {
			 return tend._DistanceX.Distance(b, c);

		}
		public R edgeLength_ca() {
			 return tend._DistanceX.Distance(c, a);

		}

	}
}
