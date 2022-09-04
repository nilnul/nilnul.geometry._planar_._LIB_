using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.geometry.planar.point.trio.be_.steps.vow
{
	public class Ee4dbl : planar.point.trio.vow.ee_.VowDefaultD<steps.Vow4dbl>
	{
		public Ee4dbl(TrioD val) : base(val)
		{
		}

		public Ee4dbl(Point4dbl component0, Point4dbl component1, Point4dbl point):this(new TrioD(component0,component1,point))
		{
		}

		public grad_.skid_.ByPoints4Dbl inward
		{
			get
			{
				return new grad_.skid_.ByPoints4Dbl(
					this.ee.a, this.ee.b
				);

			}
		}
		public grad_.skid_.ByPoints4Dbl outward
		{
			get
			{

				return new grad_.skid_.ByPoints4Dbl(
					this.ee.b, this.ee.c
				);

			}
		}

		/// <summary>
		/// to act as the initial of an angule, this is to be subtracted;hence we use the negation of the vector.
		/// </summary>
		public grad_.skid_.ByPoints4Dbl inwardReverse
		{
			get
			{
				return new grad_.skid_.ByPoints4Dbl(
					this.boxed.b, this.boxed.a
				);

			}
		}
		//public grad_.skid_.ByPoints4Dbl stop
		//{
		//	get{
		//		return new grad_.skid_.ByPoints4Dbl(
		//			this.boxed.b, this.boxed.c
		//		);

		//	}
		//}

		public double rotation()
		{
			var t = nilnul.geometry.planar.grad_.skid._DirectionX.Direction(outward)
				- //or we can PLUS the rotation, but that's wrong, as negation of vector only adds 180deg.
				nilnul.geometry.planar.grad_.skid._DirectionX.Direction(inwardReverse)
			;
			if (t < 0)
			{
				return (nilnul.num.real_.TauX.IntoDouble + t);
			}
			return (t);

		}

	}
}
