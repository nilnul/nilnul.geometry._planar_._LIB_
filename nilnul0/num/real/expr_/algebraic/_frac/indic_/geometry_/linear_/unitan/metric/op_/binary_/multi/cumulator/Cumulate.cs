using nilnul.obj.op_;
using nilnul.obj.op_.binary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.real.expr_.algebraic._frac.indic_.geometry_.linear_.unitan.metric.op_.binary_.multi.cumulator
{
	public class Cumulate
		:
		nilnul.obj.op_.binary.cumulator.Cumulate<
			unitan.Ampled
		>
	{
		public Cumulate(geometry.linear_._measured.UnitI initial) : base(
			
			new Cumulator(initial)
		)
		{
		}

	}
}
