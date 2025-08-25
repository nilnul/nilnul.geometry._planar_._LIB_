using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.geometry.planar._sub.locus.op_
{
	/// <summary>
	/// fourier transoform continuously.
	/// </summary>
	class IFourierTransformContinuously
	{
		static public void Transform(
			)
		{
			/// r(f) =
			/// integrate of: -inf, +inf
			///  a(t) * E(- tau*f*t) dt
			///, where	E is <see cref="nilnul.num.complex_.rotar"/>
			///		,a(x) is a locus from time to amplitude (the coef of real component and imaginary component)
			///		, r(f) is frequency to amplitude/radial. 
			///		, tau*f is the rotor speed.
			///; note here in r(f), for each f we have an amplitude which means the radial of a rotor; r, f is enough to define a rotation of an arm, or in real number realm, the sinusoid wave.

		}
	}
}
