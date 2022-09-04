using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using nilnul.geometry.planar.vect.be_.nonneg.vow;
using nilnul.num;
using nilnul.num.real_;

namespace nilnul.geometry.planar.vect_
{
	public interface NonnegDblI
		:Vector4dblI
		

	{
		vect.be_.nonneg.vow.EeDouble vectoree { get; }
	}
	public class NonnegDbl : vect.be_.nonneg.vow.EeDouble
		,
		NonnegDblI
		,
		Vector4dblI
	{
		public NonnegDbl(Vector4dblI val) : base(val)
		{
		}

		public NonnegDbl(VectorDbl vector):base((Vector4dblI)vector)
		{

		}

		public NonnegDbl(Point4dbl point1):this(new VectorDbl(point1))
		{
		}

		public NonnegDbl(double v1, double v2):this(new VectorDbl(v1,v2))
		{
		}

		public NonnegDbl(NonnegOfDoubleI width, NonnegOfDoubleI height)
			:base(
				 new VectorDbl(
					 width.realee,height.realee
				)
			)
		{
		}

		public NonnegDbl(double v, PositiveDblI fromPointToTapeTip)
			:this(v, new NonnegOfDouble(fromPointToTapeTip.dblen) )
		{
		}

		public Point4dbl point =>base.ee.point ;

		public EeDouble vectoree => this;
	}
}
