using nilnul.geometry.planar.point;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.geometry.planar.curve_.algebraic_.bezier_.cubic.derivative_
{
	/// <summary>
	/// displace over time.
	/// Speed is big on the flank, small in the center forefront.
	/// </summary>
	static public class _SpeedX
	{

		/// <summary>
		/// dx/dt, dy/dt
		/// </summary>
		/// <param name="boxed"></param>
		/// <param name="t"></param>
		/// <param name="complement"></param>
		/// <returns></returns>
		static public Point4dbl _Derivative_assumeProbPair(Quo4dbl boxed, double t, double complement)
		{
			var tSq = nilnul.num.real.op_.unary_.Square.Singleton.op(t);

			return 3 * (-3 + 6 * t - 3 * tSq) //SumOfProd and derive
				* boxed.a.ToOrthogonal()
			+
				3 * (1 - 4 * t + 3 * tSq) * boxed.b.ToOrthogonal()
			+
				3 * (2 * t - 3 * tSq) * boxed.c.ToOrthogonal()
			+
				3 * tSq * boxed.d.ToOrthogonal()
			;
		}



	}

	
}
