using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.geometry.planar.tend.re_
{
	public class Eq4dbl
		: _re_.OfComplexI
	{
		public bool re((Complex start, Complex stop) x, (Complex start, Complex stop) y)
		{
			return grad.Eq4dbl.Singleton.Equals(x,y)
				//x.start == y.start && x.stop == y.stop
				|| grad.re_.Opposite4dbl.Singleton.re(x,y); 

		}

		static public Eq4dbl Unison
		{
			get
			{
				return nilnul._obj.typ_._UnisonX<Eq4dbl>.Unison;
			}
		}

	}
}
