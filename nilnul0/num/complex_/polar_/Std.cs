//using nilnul.num.complex_.polar_.unital_;
using nilnul.obj.op_;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using R = nilnul.num.RealI;

namespace nilnul.num.complex_.polar_
{

	public class Std :
		nilnul.obj.op_.unary.Ed<complex_.Polar>
		,
		nilnul.num.ComplexI
	{
		public Std(Polar input) : base(input, polar.op_.unary_.Std.Singleton)
		{
		}

		public R x => this.result.x;

		public R y => this.result.y;
	}
}
