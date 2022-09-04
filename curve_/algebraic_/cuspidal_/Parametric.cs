using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.geometry.planar.curve_.algebraic_.cuspidal_
{

	public class Parametric
		: nilnul.obj.Box1<double>
		,
		ICuspidal
	{

		public Parametric(double val) : base(val)
		{
		}

		public Point4dbl point(double t) {
			return new Point4dbl(
				nilnul.num.real.op_.unary_.Square.Singleton.op(t)
				,

				boxed* nilnul.num.real.op_.unary_.Cube.Singleton.op(t)
			);
		}
	}
}
