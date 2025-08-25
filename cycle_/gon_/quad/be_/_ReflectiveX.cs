using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.geometry.planar.cycle_.gon_.quad.be_
{
	/// <summary>
	/// if it's convex, then it's a kite; if it's concave, then it's a dart.
	/// </summary>
	/// <remarks>
	/// keep in mind the input is a cycle
	/// </remarks>
	/// _Kite0dartX
    static public class _ReflectionalX
    {

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		static public bool _Be_12pair(nilnul.num.real.re_.approx_.Ratio8dbl ratio, double a, double b, double c, double d) {

			return ratio.re(a, b) && ratio.re(c, d);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		static public bool _Be_12pair( double a, double b, double c, double d) {

			return _Be_12pair( num.real.re_.approx_.Ratio8dbl.Singleton,a,b,c,d );
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		static public bool _Be( double a, double b, double c, double d) {

			return _Be_12pair(a,b,c,d ) || _Be_12pair(b,c,d,a );
		}

		static public bool Be(C a, C b, C c, C d) {
			return _Be(
				(b-a).Magnitude
				,
				(c-b).Magnitude
				,
				(d-c).Magnitude
				,
				(a-d).Magnitude
			);
		}


    }
}
