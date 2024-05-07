using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.real.expr_.algebraic._frac.indic_.geometry_.linear_.unitan.metric.op_.binary_.multi
{
	public class Cumulator
		:
		nilnul.obj.op_.binary.Cumulator<
			unitan.Ampled
			//,
			//Multi
		>
	{
		public Cumulator(geometry.linear_._measured.UnitI initial)
			:
			base(
				new Ampled(
					OfUnit.IndicNil(initial)
				)
				,
				new Multi(initial)
			)
		{
		}
	}
}
