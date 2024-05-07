using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.real.expr_.algebraic._frac.indic_.geometry_.linear_.unitan.metric.op_.binary_
{
	static public class _MultiX
	{
		static public unitan.Ampled Multi(
			unitan.Ampled a
			,
			unitan.Ampled b
		) {
			var bConverted = b.toAmpled(a.indic1.unit);
			return new Ampled(
				a.coef.ToReal() * bConverted.coef
				,
				a.indic1.unit
			);
		}

		static public unitan.Ampled Multi(
			geometry.linear_._measured.UnitI unit
			,
			unitan.Ampled a
			,
			unitan.Ampled b
		) {
			var aConverted = a.toAmpled(unit);
			var bConverted = b.toAmpled(unit);
			return new Ampled(
				aConverted.coef.ToReal() * bConverted.coef
				,
				unit
			);
		}


	}
}