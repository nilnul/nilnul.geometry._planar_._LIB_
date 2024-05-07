using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;

namespace nilnul.geometry.planar.grad
{
	public class Eq4dbl
		:
		IEqualityComparer<Grad4dbl_byPointsI>
		,
		IEqualityComparer<(Complex start,Complex stop)>

	{
		public bool Equals(Grad4dbl_byPointsI x, Grad4dbl_byPointsI y)
		{
			return point.co.EqD.Singleton.Equals((x.basis,x.finish),(y.basis,y.finish));
		}


		public int GetHashCode(Grad4dbl_byPointsI obj)
		{
			return point.co.EqD.Singleton.GetHashCode((obj.basis,obj.finish));
		}

		public bool Equals((Complex start, Complex stop) x, (Complex start, Complex stop) y)
		{
			return x.start == y.start && x.stop == y.stop;
		}

		public int GetHashCode((Complex start, Complex stop) obj)
		{
			return obj.start.GetHashCode() ^ obj.stop.GetHashCode();

		}

		static public Eq4dbl Singleton
		{
			get
			{
				return nilnul._obj.typ_.nilable_.unprimable_.Singleton<Eq4dbl>.Instance;
			}
		}
	}
}