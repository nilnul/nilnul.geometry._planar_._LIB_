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
	public class Nonnil4dbl :
		vect.be_.nonnil.vow.Ee4dbl
		,
		Nonnil4dblI

	{
		public Nonnil4dbl(Vect4dblI val) : base(val)
		{
		}

		public Nonnil4dbl(Vect4dbl fromPointToTapeTip) : base(
				fromPointToTapeTip
			)
		{
		}
		public Nonnil4dbl(Point4dbl point1) : this(new Vect4dbl(point1))
		{
		}






		public Nonnil4dbl(Point4dblI fromPointToTapeTip) : this(
			new Vect4dbl(fromPointToTapeTip)
		)
		{
		}


		public Nonnil4dbl(double v1, double v2) : this(new Vect4dbl(v1, v2))
		{
		}

		public Point4dblI point => base.ee.point;

		public Ee4dbl vectNonnil => this;


		static public Nonnil4dbl operator +(Nonnil4dbl nonnil, nilnul.num.real_.NonnegOfDouble extension)
		{
			return new Nonnil4dbl((new nonnil_.Polar4dbl(nonnil) + extension));
		}

	}
}
