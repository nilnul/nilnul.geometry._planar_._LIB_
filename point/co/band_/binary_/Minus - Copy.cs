using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using N = nilnul._num.bigint.be.Natural.Asserted;
using Q1 = nilnul.num.Quotient1;
using Qr = nilnul.num.real_.Quotient;
using R = nilnul.num.Real;
using Rx = nilnul.num.RealIX;
using RI = nilnul.num.RealI;



namespace nilnul.geometry.planar.point.co.op_
{
	public class Minus
	{

		static public Point___1 Eval(Point___1 a, Point___1 b) {
			return new Point___1(
				new R(
				nilnul.num.real.op_.binary_.Minus.Singleton.op(a.x,b.x)
				)
				
				,
				new R(
				nilnul.num.real.op_.binary_.Minus.Singleton.op(a.y,b.y)	)
			);
		}

		static public Point Eval(Point a, Point b) {
			return new Point(
				nilnul.num.real.op_.binary_.Minus.Singleton.op(a.x,b.x)
				
				,
				nilnul.num.real.op_.binary_.Minus.Singleton.op(a.y,b.y)	
			);
		}

		public static Point Eval(PointI a, PointI b)
		{

			return new Point(
				nilnul.num.real.op_.binary_.Minus.Singleton.op(a.x,b.x)
				
				,
				nilnul.num.real.op_.binary_.Minus.Singleton.op(a.y,b.y)	
			);

		}

		public static Point Eval(PointI1 a, PointI1 b)
		{

			return new Point(
				nilnul.num.real.op_.binary_.Minus.Singleton.op(a.x,b.x)
				
				,
				nilnul.num.real.op_.binary_.Minus.Singleton.op(a.y,b.y)	
			);

		}

	}
}
