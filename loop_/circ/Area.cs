using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using N = nilnul._num.bigint.be.Natural.Asserted;
using Q1 = nilnul.num.Quotient1;
using Qr = nilnul.num.real_.Quotient;
using R = nilnul.num.RealI;
using Rx = nilnul.num.Real;
using nilnul.num.real;



namespace nilnul.geometry.planar.crux_.disk
{
	static public class _AreaX
	{
		static public nilnul.num.real_.Nonneg Area(nilnul.num.real_.Nonneg radius) {
			return new nilnul.num.real_.Nonneg( 
				new nilnul.num.real_.Nonneg( new Rx( new nilnul.num.real_.Tau()) 
				* 
				new Rx(
					nilnul.num.real.op_.unary_.Square.Singleton.op(radius)
				)
			));
		}

		static public nilnul.num.real_.Nonneg Area(double d) {
			return Area(
				new nilnul.num.real_.Nonneg(
					nilnul.num.real_.quotient_._DoublX.Construct_precisionDenom(d,100)
				)
			);
		}
	}
}
