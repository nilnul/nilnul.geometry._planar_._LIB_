using nilnul.num;
using nilnul.num.real_;
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



namespace nilnul.geometry.planar.lead_.norm
{
	/// <summary>
	/// </summary>
	static public class _FootX
	{

		static public Point1 Foot(this lead_.Norm norm)
		{

			return new Point1(
				norm.radius * geometry.planar.rotation.op_._CosX.Cos(norm.rotation).ToReal()
				,

				norm.radius * geometry.planar.rotation.op_._SinX.Sin(norm.rotation)

			);

		}
	}

}
