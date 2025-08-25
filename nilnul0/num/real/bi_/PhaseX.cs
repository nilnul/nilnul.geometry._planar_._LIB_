using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.real.bi_
{
	/// <summary>
	/// take the two input as complex number, of which we get the phase as result, in (-pi, pi]
	/// </summary>
	static public  class _PhaseX
	{
		/// <summary>
		/// Note that the order of the arguments are reversed from that of <see cref="Math.Atan2(double, double)"/>
		/// </summary>
		/// <param name="x"></param>
		/// <param name="y"></param>
		/// <returns>
		/// 0 if x=y=0.
		///(-pi, pi]
		/// </returns>
		/// <see cref="geometry.planar.rotation_.ISwing"/>
		///
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		static public double Phrase(double x, double y ) {
			return Math.Atan2(y, x);
		}
	}
}
