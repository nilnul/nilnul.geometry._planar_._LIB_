using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using N = nilnul._num.bigint.be.Natural.Asserted;
using Q1 = nilnul.num.Quotient1;
using Qr = nilnul.num.real_.Quotient;
using R = nilnul.num.Real;
using RI = nilnul.num.RealI;

using Rx = nilnul.num.RealIX;



namespace nilnul.geometry.planar.rotation.op_
{
	static public class _CosX
	{
		public static double Cos_ofDegree(double x)
		{


			return Math.Cos(_rotation.unit_.Degree.Degree2Radian(x));
		}

		static public double Double(double radian)
		{
			return Math.Cos(radian);
		}

		static public double OfDeg(double deg)
		{
			return Double(
				nilnul.geometry.planar.rotation_.Degree.ToRadian(deg)
			);
		}
		static public R Cos(R rotation) {

			return new R(Cos(rotation.boxed));

		}

		static public RI Cos(RI rotation) {

			return nilnul.num.real.op_.unary_.Cos.Singleton.op(rotation);

		}


	}
}
