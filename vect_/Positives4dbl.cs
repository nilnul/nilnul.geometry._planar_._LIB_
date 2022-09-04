using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using nilnul.geometry.planar.vect.be_.positives.vow;
using nilnul.num;
using nilnul.num.real_;

namespace nilnul.geometry.planar.vect_
{
	public class Positives4dbl : vect.be_.positives.vow.Ee4dbl
		,
		Positives4dblI
		,
		Vect4dblI
	{
		public Positives4dbl(Vect4dblI val) : base(val)
		{
		}

		public Positives4dbl(Vect4dbl vector):base((Vect4dblI)vector)
		{

		}

		public Positives4dbl(Point4dbl point1):this(new Vect4dbl(point1))
		{
		}

		public Positives4dbl(double v1, double v2):this(new Vect4dbl(v1,v2))
		{
		}

		public Positives4dbl(PositiveDblI width, PositiveDblI height)
			:base(
				 new Vect4dbl(
					 width.dblen,height.dblen
				)
			)
		{
		}

		public Positives4dbl(double v, PositiveDblI fromPointToTapeTip)
			:this(v, new NonnegOfDouble(fromPointToTapeTip.dblen) )
		{
		}

		public Point4dblI point =>base.ee.point ;

		public Ee4dbl vectee => this;
	}
}
