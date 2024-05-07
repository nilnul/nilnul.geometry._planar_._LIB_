using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.geometry.linear_.measured.span.distance.op_.unary_
{
	public class _ExchangeUnitX
	{
		static public DistanceI ChangeUnit(
			DistanceI distance
			,
			_measured.UnitI unit
		) {
			var quantitied=
				new num.real.expr_.var_.geometry_.linear_.unitan.Quantitied(
					distance.amount
					,
					distance.unit
				)
			;

			var asRational = quantitied.toRational();

			var ampledIndic= asRational.toAmpled(unit);

			return new Distance(
				ampledIndic.coef
				,
				ampledIndic.indic1.unit
			);

			
		}


	}
}
