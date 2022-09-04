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



namespace nilnul.geometry.planar
{
	[Obsolete()]
	public class Vector : nilnul.Duo<R>
	{
		public Vector(R a, R b) : base(a, b)
		{
		}

		static public Vector CreateFroPoint(Point p) {
			return new Vector(
				new R(
					p.x
				)
				
				,
				new R(
					p.y
				)
			);
		}

		static public Vector CreateFroPointDuo(point.Duo1 duo) {
			return CreateFroPoint(
				duo.end - duo.begin
			);
		}
	}
}
