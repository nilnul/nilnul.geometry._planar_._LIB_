using nilnul.geometry.planar.vect;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.geometry.planar.vect_.nonnil.co.rotation
{
	/// <summary>
	/// two nonnil vector:u,v
	/// u.v = |u| cos(t) *|v|
	/// so :
	/// cos(t) = u.v / |u||v|
	/// </summary>
	static public class _CosX
	{
		static public double Cos(planar.Vect4dblI a, planar.Vect4dblI b) {
			return a.InnerProduct(b) / ( a.Distance() * b.Distance());
		}

		/// <summary>
		/// if the two vect are of the same length, then sqrt can be avoided.
		/// </summary>
		/// <param name="a"></param>
		/// <param name="b"></param>
		/// <returns></returns>
		///
		[Obsolete(nameof(Cos) + " is preferred as this involves sqrt.")]
		static public double Cos_byTrigon(planar.Vect4dblI a, planar.Vect4dblI b) {
			var c = b.Minus(a);
			return ( a.Variance() + b.Variance() - c.Variance() )
				/
				( 2 * a.Distance() * b.Distance());
		}

	}
}
