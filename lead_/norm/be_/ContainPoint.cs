using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using N = nilnul._num.bigint.be.Natural.Asserted;
using Q1 = nilnul.num._quotient.fraction.op.Simplify.Ed1;
using Qr = nilnul.num.real_.Quotient;
using RI = nilnul.num.RealI;
using R = nilnul.num.Real;


namespace nilnul.geometry.planar.lead_.norm.be_
{
	/// <summary>
	/// </summary>
	static public class _ContainsPointX
		
	{

		static public bool Contain(this lead_.Norm norm,  Point1 point)
		{

			return planar.vect.co.to_.real_._DotProductX.RealI(
				norm.Foot(),

				point
			)
			==

			(
				nilnul.num.real.op_.unary_._SquareX.Op( norm.radius)
			 )


			;


			//throw new NotImplementedException();
		}


	}
}
