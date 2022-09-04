using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.geometry.planar.ray_
{
	public  class OnArrowDbl
		:point.co.be_.dif.vow.EeDbl
		,
		IRayDbl
	{

		public OnArrowDbl(point.CoD pair)
			:base(pair)
		{

		}
		public OnArrowDbl(Point4dbl a,Point4dbl b)
			:this(new point.CoD(a,b))
		{
		}

		public OnArrowDbl(int v1, int v2, int v3, int v4):this(
			new Point4dbl(v1,v2)
			,
			new Point4dbl(v3,v4)
		)
		{
		}

		public double rotation {
			get {
				return nilnul.geometry.planar.vect_.nonnil._DirectionX._Ge0LtTau_ofAssumeNonnil(
					grad_._StepX.Vect(
					 this.ee.component
					 , this.ee.component1
					 )


				);

			}
		}

		public Point4dblI src => ee.component;
	}
}
