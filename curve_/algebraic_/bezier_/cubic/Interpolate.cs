using nilnul.geometry.planar.point;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.geometry.planar.curve_.algebraic_.bezier_.cubic
{
	/// <summary>
	/// note the mid points is not on the path; it is a control/clamping point.
	/// </summary>
	/// <remarks>
	///For some choices of P1 and P2 the curve may intersect itself, or contain a cusp.
	/// </remarks>
	static public class _InterpolateX
	{
		/// <summary>
		/// another way to do <see cref="nameof(_interpolate_assumeProb)"/>
		/// </summary>
		/// <param name="t"></param>
		/// <param name="complement"></param>
		/// <returns></returns>
		/// <remarks>
		/// When the curve’s radius of curvature is small, the points tend to bunch up.
		/// </remarks>
		static public  Point4dbl _Interpolate_assumeProbPair(Quo4dbl boxed, double t, double complement)
		{
			return nilnul.num.real.op_.unary_.Cube.Singleton.op(complement) * boxed.a.ToOrthogonal()
				+
				3 * nilnul.num.real.op_.unary_.Square.Singleton.op( complement) * t * boxed.b.ToOrthogonal()
				+
				3 *complement *  nilnul.num.real.op_.unary_.Square.Singleton.op(t) * boxed.c.ToOrthogonal()
				+
				nilnul.num.real.op_.unary_.Cube.Singleton.op(t) * boxed.d.ToOrthogonal()
			;


		}


		static public  Point4dbl _Interpolate_assumeProb(Quo4dbl boxed, double t)
		{
			return _Interpolate_assumeProbPair(boxed,t,1-t);


		}

	

	}
}