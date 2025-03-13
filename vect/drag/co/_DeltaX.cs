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
	///		delta
	///		diff
	///		gain
	static public class _DeltaX
	{
		/// <summary>
		/// 
		/// </summary>
		/// <param name="x"></param>
		/// <param name="y"></param>
		/// <param name="x2"></param>
		/// <param name="y2"></param>
		/// <returns></returns>
		/// alias:
		///		decline
		public static double Minus(double x, double y, double x2, double y2)
		{
			return nilnul.geometry.planar.vect._DragX.Surround(x, y)
				-
nilnul.geometry.planar.vect._DragX.Surround(x, y)			;


			//throw new NotImplementedException();
		}

		/// <summary>
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
		/// alias:
		///		diff
		///		delta
		///		
		static public double Gain(Vect4dblI v1, Vect4dblI v2) {
			return Minus(v2,v1);
		}

	}
}
