using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.geometry.planar.tend
{
	public class Eq4dbl
		: IEqualityComparer<
			(Complex start, Complex stop)

		>
	{
		public bool Equals((Complex start, Complex stop) x, (Complex start, Complex stop) y)
		{
			return re_.Eq4dbl.Unison.re(x, y); 

		}

		public int GetHashCode((Complex start, Complex stop) obj)
		{
			return 0;
		}
	}
}
