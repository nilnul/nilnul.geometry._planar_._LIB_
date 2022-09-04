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



namespace nilnul.geometry.planar.vector.co.to_
{

	[Obsolete("",true)]
	public static class _InnerProduct
	{

		static public R InnerProduct(Point___1 point, Point___1 point1) {
			return 
				point.x *point1.x + point.y*point1.y
				;

		}
	}
}
