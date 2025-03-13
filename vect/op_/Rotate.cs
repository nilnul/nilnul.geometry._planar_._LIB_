using nilnul.geometry.planar;
using nilnul.num;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using N = nilnul._num.bigint.be.Natural.Asserted;
using Q1 = nilnul.num.Quotient1;
using Qr = nilnul.num.real_.Quotient;
using R = nilnul.num.RealI;
using Rx = nilnul.num.RealIX;


namespace nilnul.geometry.planar.vect.op_.unary_
{
	static public class _RotateX
	{
		/// <summary>
		/// x+y i    *   cos(1/4 Tau) + i sin(1/4 Tau)
		/// </summary>
		/// <param name="v"></param>
		/// <returns></returns>
		static public Vector1 RotateQuarterRound(planar.Vector1 v) {

			return new Vector1(-v.component1.ToReal(), v.component);
		}

		static public Vector1 RotateQuarterRoundBack(Vector1 v) {

			return new Vector1(v.component1, -v.component.ToReal());
		}

		static public Vect4dbl RotateQuarterRoundBack(Vect4dblI v) {

			return new Vect4dbl(v.point.y, -v.point.x);
		}


		static public Vector1 RotateHalfRound (Vector1 v) {

			return new Vector1(-v.component.ToReal(), -v.component1.ToReal());
		}

	}
}
