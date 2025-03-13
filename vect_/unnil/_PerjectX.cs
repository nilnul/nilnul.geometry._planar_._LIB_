using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.geometry.planar.vect_.unnil
{
	/// <summary>
	/// given unnil b,
	/// for vect x,
	/// the inner product is  x.b; and the introject is: x.b / |b|
	/// ; if we use that as scale, then x.b/|b| * b is the vector introjection; and x *|b| - introjection = resolute.
	/// </summary>
	/// alias: scalar resolute
	/// vs:
	///		inner product
	///			,introproject to mean x.b ?
	///	vs:
	///		<see cref="unnil."/>
	///		shadow/shed
	///		
    class _PerjectX
		/// <see cref="vect.dich_.orthic_.IPerject"/>
    {
		/// <summary>
		/// </summary>
		/// <param name="unnil"></param>
		/// <param name="x"></param>
		/// <returns>
		/// sum back would be x* |b|
		/// </returns>
		/// as the new coordinates on the unnil.
		static public C Introject_0unnil(C unnil, C x)
		{
			return planar.vect.co.scala_._DotProductX.Dbl(unnil, x) / unnil.Magnitude * unnil;
		}

	}
}
