using nilnul.obj;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.geometry.planar.point.co.band_
{
	public class Add:point.ICombine
	{

		static public Add Singleton
		{
			get
			{
				return nilnul.obj_.Singleton<Add>.Instance;
			}
		}


		public Point1 combine(PointI1 par, PointI1 par1)
		{
			return new Point1(
				nilnul.num.real.op_.binary_.Add.Singleton.op(
					par.x
					,
					par1.x
				)
				,
				nilnul.num.real.op_.binary_.Add.Singleton.op(
					par.x
					,
					par1.x
				)

			);
		}

		public Point1 combine(Point1 par, Point1 par1)
		{
			return new Point1(
				nilnul.num.real.op_.binary_.Add.Singleton.op(
					par.x
					,
					par1.x
				)
				,
				nilnul.num.real.op_.binary_.Add.Singleton.op(
					par.x
					,
					par1.x
				)

			);
		}

		static public PointF combine(PointF a, PointF b)
		{
			return new PointF(a.X + b.X, a.Y + b.Y);
		}
		static public Point4dbl combine(Point4dbl a, Point4dbl b)
		{
			return new Point4dbl(a.x + b.x, a.y + b.y);
		}

		PointI1 CombineI1<PointI1, PointI1, PointI1>.combine(PointI1 arg, PointI1 arg1)
		{
			return combine(arg,arg1);
		}
	}
}
