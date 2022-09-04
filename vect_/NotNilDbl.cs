using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using nilnul.geometry.planar.vect.be_.nonnil.vow;
using nilnul.geometry.planar.vect.be_.nonnil;
using nilnul.num;

namespace nilnul.geometry.planar.vect_
{
	[Obsolete()]
	public class NonnilDbl :
		vect.be_.nonnil.vow.EeDouble
		,
		NonnilDblI
		,
		Vector4dblI
	{
		public NonnilDbl(Vector4dblI val) : base(val)
		{
		}

		public NonnilDbl(VectorDbl vector):base((Vector4dblI)vector)
		{

		}

		public NonnilDbl(vect_.nonnil_.Polar4dbl point1):this((Vect4dblI)(point1))
		{
		}

		public NonnilDbl(Point4dbl point1):this(new VectorDbl(point1))
		{
		}
		public NonnilDbl(Point4dblI point1)
			:
			this(
				new Point4dbl(point1.x,point1.y))
		{
		}
		

		public NonnilDbl(Vect4dblI fromPointToTapeTip):this(
			(fromPointToTapeTip.point)
		)
		{
		}

		public NonnilDbl(Vect4dbl fromPointToTapeTip):this(
			(Vect4dblI)(fromPointToTapeTip)
		)
		{
		}



		public NonnilDbl(double v1, double v2):this(new VectorDbl(v1,v2))
		{
		}

		public Point4dbl point =>base.ee.point ;

		public EeDouble vectoree => this;

		//Point4dblI Vect4dblI.point =>point;

		static public NonnilDbl operator +(NonnilDbl nonnil, nilnul.num.real_.NonnegOfDouble extension)
		{
			return new NonnilDbl( (new nonnil_.Polar4dbl(nonnil ) + extension) );
		}

	}
}
