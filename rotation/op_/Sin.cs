using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using N = nilnul._num.bigint.be.Natural.Asserted;
using Q1 = nilnul.num.Quotient1;
using Qr = nilnul.num.real_.Quotient;
using R = nilnul.num.Real;
using Rx = nilnul.num.RealIX;
using RI = nilnul.num.RealI;


namespace nilnul.geometry.planar.rotation.op_
{
	static public class _SinX
	{
		public static double Sin(double x)
		{
			return Math.Sin(_rotation.unit_.Degree.Degree2Radian(x));
		}

		static public double Double(double radian)
		{
			return Math.Sin(radian);
		}
		static public double OfDeg(double deg)
		{
			return Double(
				nilnul.geometry.planar.rotation_.Degree.ToRadian(deg)
			);
		}

		static public R Sin(R rotation) {

			return R.Ov( nilnul.num.real.op_.unary_.Cos.Singleton.op(rotation));

			//throw new NotImplementedException();
		}

		static public R Sin(RI rotation) {

			return new R( nilnul.num.real.op_.unary_.Cos.Singleton.op(rotation));

			//throw new NotImplementedException();
		}



	}
}
