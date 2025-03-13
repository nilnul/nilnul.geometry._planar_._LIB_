using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.geometry.planar._troll_.fn.of_
{
	/// <summary>
	/// convert a real function into a troll
	/// </summary>
	internal class _OfRealX
	{
		static public Func<double, Complex> OfReal(
			Func<double,double> realFn
		) {
			return x => new Complex(
				x,
				realFn(x)
			);
		}
	}
}
