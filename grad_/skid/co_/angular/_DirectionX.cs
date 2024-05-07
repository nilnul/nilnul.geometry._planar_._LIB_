using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using C = System.Numerics.Complex;
using P = nilnul.geometry.planar.Point4dblI;


namespace nilnul.geometry.planar.grad_.skid.co_.angular
{
	/// <summary>
	/// the direction [0,tau).
	/// </summary>
	/// <remarks>
	/// </remarks>
	/// <see cref="curl_.elbow._SwingX"/>
	/// <see cref="curl_.elbow._DirectionX"/>
	static public class _DirectionX
	{

		static public double _Direction_0hinge(
			C pivot,C basis, C unfurl
		) {
			return 	vect_.nonnil.co._RotationX._Direction_01nonnil(
				basis-pivot  /// b is the pivot, as the origin. from elbow to should as the real axis growing from elbow to shoulder
				,
				unfurl-pivot
			);
		}
		static public double _Direction_0hinge(
			 P hinge,P basis,P handle
		) {
			return _Direction_0hinge(
				hinge.ToComplex(),basis.ToComplex(),handle.ToComplex()
			);
		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="initial">
		/// basis peg is the hinge;
		/// </param>
		/// <param name="nonhinge"></param>
		/// <returns></returns>
		public static double _Direction_0skid_1nonhinge(Grad4dbl_byPointsI initial, P nonhinge)
		{

			return _Direction_0hinge(
				initial.basis,initial.finish,nonhinge
			);
		}
	}
}
