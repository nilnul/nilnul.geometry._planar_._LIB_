using nilnul.num.real_;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.geometry.planar.curve.fractal_
{
	public class LogisticMap
		:nilnul.obj.Box1< nilnul.num.real_.PositiveDblI>
	{
		public LogisticMap(PositiveDblI val) : base(val)
		{
			new nilnul.bit.vow_.True1<ArgumentOutOfRangeException>(
				new ArgumentOutOfRangeException($"{val} shall not be gt 4")
			).vow(
				val.dblen.ee<=4
			);
		}

		/// <summary>
		/// With r between 0 and 1, the population will eventually die, independent of the initial population.
		/// With r between 1 and 2, the population will quickly approach the value r − 1/r, independent of the initial population.
		/// With r between 2 and 3, the population will also eventually approach the same value r − 1/r, but first will fluctuate around that value for some time.
		/// With r between 3 and 1 + √6 ≈ 3.44949 the population will approach permanent oscillations between two values.
		/// With r between 3.44949 and 3.54409 (approximately), from almost all initial conditions the population will approach permanent oscillations among four values. 
		/// 
		/// </summary>
		/// <param name="x"></param>
		/// <returns></returns>
		public double recur(double x) {
			return boxed.dblen.ee * x * (1 - x);
		}
	}
}
