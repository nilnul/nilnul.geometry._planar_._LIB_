using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using N = nilnul._num.bigint.be.Natural.Asserted;
using Q1 = nilnul.num.Quotient1;
using Qr = nilnul.num.real_.Quotient;
using R = nilnul.num.Real;
using Rx = nilnul.num.RealIX;
using RI = nilnul.num.RealI;

using nilnul.num;

namespace nilnul.geometry.planar
{
	
	public class Vector1 : nilnul.num.real.Co
		,VectorI
		,IVector
	{
		public R x =>   R.Ov(Item1);

		public R y => R.Ov(Item2);

		public Point1 point => new Point1(x,y);

		public Vector1(PointI1 point):this(point.x,point.y)
		{
		}

		public Vector1(R a, R b) : base(a, b)
		{
		}
		public Vector1(R a, RI b) : base(a, b)
		{
		}
		public Vector1(RI a, R b) : base(a, b)
		{
		}
		public Vector1(RI a, RI b) : base(a, b)
		{
		}


		public Vector1(VectorI vector):this(vector.x, vector.y)
		{
		}

		public Vector1(IVector vector):this(vector.point)
		{
		}

		static public Vector1 CreateFroPoint(Point1 p) {
			return new Vector1(
				
					p.x
				
				
				,
				
					p.y
				
			);
		}

		static public Vector1 operator -(Vector1 v, Vector1 b) {
			return new Vector1(v.x.ToReal() - b.x.ToReal(), v.y.ToReal()-b.y.ToReal());
		}

		static public implicit operator Vector1(Point1 p) { return CreateFroPoint(p); }

		static public implicit operator Point1(Vector1 v) { return new Point1(v.Item1,v.Item2); }
		static public Vector1 CreateFroPointDuo(point.Co duo) {
			return CreateFroPoint(
				duo.end - duo.begin
			);
		}
		static public Vector1 CreateFroPointDuo(point.ICo duo) {
			return CreateFroPoint(
				duo.component1 - duo.component
			);
		}



		
	}
}
