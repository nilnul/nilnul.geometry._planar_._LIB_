using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.geometry.planar.rotation_
{
	/// <summary>
	/// observe the height/vertical of y.
	/// 
	///  the arcTg (x). from (-Tau/4, Tau/4).
	/// </summary>
	/// <remarks>
	///  if the height can be inf, then the range is closed [-Tau/4, Tau/4]
	/// </remarks>
	static public class _GradX
	{
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		static public double Rotation_gtQuarterLtQuarter(double height) {
			return Math.Atan(height);
		}
	}
}
