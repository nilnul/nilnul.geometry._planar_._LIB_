using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RI = nilnul.num.RealI;
using R = nilnul.num.Real;

using N = nilnul._num.bigint.be.Natural.Asserted;
using Q1 = nilnul.num.Quotient1;
using Qr = nilnul.num.real_.Quotient;
 using Rx = nilnul.num.RealIX;




namespace nilnul.geometry.planar
{
	[Obsolete(nameof(Point))]

	public class Point___1
	{
		private R _x;

		public R x
		{
			get { return _x; }
			set { _x = value; }
		}

		private R _y;

		public R y
		{
			get { return _y; }
			set { _y = value; }
		}


		public Point___1(
			R x,R y
			
			)
		{

		}

		static public Point___1 operator -(Point___1 a, Point___1 b) {
			return nilnul.geometry.planar.point.co.op_.Minus.Eval(a, b);
		}

		static public implicit operator Point___1(Point x) {
			return new Point___1( new R( x.x),new R(x.y));
		}




	}
}
