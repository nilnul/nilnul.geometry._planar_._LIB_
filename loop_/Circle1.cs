using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using N = nilnul._num.bigint.be.Natural.Asserted;
using Q1 = nilnul.num.Quotient1;
using Qr = nilnul.num.real_.Quotient;
using R = nilnul.num.RealI;
using Rx = nilnul.num.RealIX;



namespace nilnul.geometry.planar.loop_
{

	public class Circle1
		: loop_.simple_.convex_.quadratic_.conic_.IEllipse

	{
		private nilnul.num.real_.PositiveI _r;

		public nilnul.num.real_.PositiveI r
		{
			get { return _r; }
			set { _r = value; }
		}

		private nilnul.geometry.planar.PointI1 _center;

		public nilnul.geometry.planar.PointI1 center
		{
			get { return _center; }
			set { _center = value; }
		}

		public Circle1(
			nilnul.geometry.planar.PointI1 center
			,
			num.real_.PositiveI r

		)
		{

			_center = center;
			_r = r;

		}

	}
}
