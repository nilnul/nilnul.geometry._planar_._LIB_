using nilnul.geometry.planar.point;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.geometry.planar.curve_.algebraic_.bezier_
{
	/// <summary>
	/// note the mid point is not on the path; it is a control/clamping point.
	/// </summary>
	public class Quadratic
		:
		nilnul.obj.Box1<

		planar.point.TrioD
			>
	{
		public Quadratic(TrioD val) : base(val)
		{
		}

		public Quadratic(IEnumerable<Point4dblI> enumerable):this(new TrioD(enumerable) )
		{

		}

		public Point4dbl __interpolate_assumeProbPair(double t,double complement) {
			return nilnul.num.real.op_.unary_.Square.Singleton.op(complement) * this.boxed.a
				+
				2 * complement * t * this.boxed.b
				+
				nilnul.num.real.op_.unary_.Square.Singleton.op(t) * boxed.c
			;

		}

		public Point4dbl _interpolate_assumeProb(double t) {
			return __interpolate_assumeProbPair(t, 1 - t);

		}

	}
}
