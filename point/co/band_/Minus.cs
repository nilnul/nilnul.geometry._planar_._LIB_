using nilnul.obj;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using N = nilnul.NumI;//._num.bigint.be.Natural.Asserted;
using Q1 = nilnul.num.QuotientI;//._quotient.fraction.op.Simplify.Ed1;
using Qr = nilnul.num.real_.Quotient;
using R = nilnul.num.Real;
using RI = nilnul.num.RealI;



namespace nilnul.geometry.planar.point.co.band_
{
	public class Minus:point.ICombine, point._combine_.IOfD
	{

		public Point4dbl combine(Point4dbl a, Point4dbl b)
		{
			return new Point4dbl(a.x - b.x, a.y - b.y);
		}

		 public PointF combine(PointF a, PointF b)
		{
			return new PointF(a.X - b.X, a.Y - b.Y);
		}

		public Point1 combine(PointI1 par, PointI1 par1)
		{
			return Add.Singleton.combine(

				par
				,
				convert_.Neg.Singleton.convert(par1)
			);

		}


		public Point1 combine(Point1 par, Point1 par1)
		{
			return Add.Singleton.combine(

				par
				,
				convert_.Neg.Singleton.convert(par1)
			);

		}


		public Point combine(Point a, Point b)
		{
			return new Point(
				a.X-b.X

				,
				a.Y-b.Y
			);
		}

		PointI1 CombineI1<PointI1, PointI1, PointI1>.combine(PointI1 arg, PointI1 arg1)
		{
			return combine(arg,arg1);
		}

		static public Minus Singleton
		{
			get
			{
				return nilnul.obj_.Singleton<Minus>.Instance;
			}
		}

	}
}
