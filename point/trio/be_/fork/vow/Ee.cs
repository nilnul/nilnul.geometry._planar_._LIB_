using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.geometry.planar.point.trio.be_.fork.vow
{
	public class Ee : planar.point.trio.vow.ee_.VowDefault<fork.Vow>
	{
		public Ee(Trio val) : base(val)
		{
		}

		public Ee(Point1 component1, Point1 component, Point1 point):this(new Trio(component1,component,point))
		{
		}


		public grad_.Arrow start
		{
			get
			{
				return new grad_.Arrow(
					 this.boxed.a, this.boxed.b
				);

			}
		}
		public grad_.Arrow stop
		{
			get{
				return new grad_.Arrow(
					this.boxed.a, this.boxed.c
				);

			}
		}

		public nilnul.geometry.planar.rotation_.Direction rotation()
		{
			var t=nilnul.geometry.planar.grad_.skid._DirectionX.Direction(stop)
				-
				nilnul.geometry.planar.grad_.skid._DirectionX.Direction(start)
			;
			if (t.quantity<0)
			{
				return new planar.rotation_.Direction( nilnul.num.real_.Tau.Singleton + t.quantity);
			}
			return new rotation_.Direction( t);
				
		}
	}
}
