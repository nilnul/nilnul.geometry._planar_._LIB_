using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.geometry.planar.vect.drag.co
{
	/// <summary>
	/// 
	/// </summary>
	/// alias:
	///		vs
	static public class _DeltaX
	{
		/// <summary>
		///  a^2 + b^2
		/// </summary>
		/// <param name="v1">
		///
		/// </param>
		/// <param name="v2"></param>
		/// <returns></returns>
		static public double Minus(Vect4dblI v1, Vect4dblI v2) {
			return v1.Drag() - v2.Drag();
		}

		/// <summary>
		/// this is a dif, the <see cref="nilnul.obj.op_.binary.Converse{T}"/> of minus.
		/// like <see cref="nilnul.num.real.op_.binary_.Minus"/> and <see cref="nilnul.num.real.op_.binary_.Dif"/>
		/// </summary>
		/// <param name="v1"></param>
		/// <param name="v2"></param>
		/// <returns></returns>
		static public double Gain(Vect4dblI v1, Vect4dblI v2) {
			return Minus(v2,v1);
		}

	}
}
