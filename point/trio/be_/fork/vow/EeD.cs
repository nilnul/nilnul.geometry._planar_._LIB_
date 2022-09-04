using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.geometry.planar.point.trio.be_.fork.vow
{
	public class Ee4dbl : planar.point.trio.vow.ee_.VowDefaultD<fork.Vow4dbl>
	{
		public Ee4dbl(TrioD val) : base(val)
		{
		}

		public Ee4dbl(Point4dbl component1, Point4dbl component, Point4dbl point):this(new TrioD(component1,component,point))
		{
		}

	

		public grad_.skid_.ByPoints4Dbl start
		{
			get
			{
				return new grad_.skid_.ByPoints4Dbl(
					 this.boxed.a, this.boxed.b
				);

			}
		}
		public grad_.skid_.ByPoints4Dbl stop
		{
			get{
				return new grad_.skid_.ByPoints4Dbl(
					this.boxed.a, this.boxed.c
				);

			}
		}

		public double rotation()
		{
			var t=nilnul.geometry.planar.grad_.skid._DirectionX.Direction(stop)
				-
				nilnul.geometry.planar.grad_.skid._DirectionX.Direction(start)
			;
			if (t<0)
			{
				return ( nilnul.num.real_.TauX.IntoDouble+ t);
			}
			return ( t);
				
		}
	}
}
