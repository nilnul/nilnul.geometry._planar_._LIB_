using nilnul.geometry.planar.point.as_;
using nilnul.geometry.planar.vect_;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.geometry.planar.vect.to_.co_.decompose_
{
	/// <summary>
	/// 
	/// </summary>
	static public class _CrossX
	{
		/// <summary>
		///  xA  = b,
		/// where A is the new basis, b is the vect, x is the resulted new coord|vect.
		/// in other words, x=  b/A
		/// </summary>
		/// <remarks>
		/// <see cref="planar.morph_.rebase_.shear_.IInvertible"/>
		/// </remarks>
		/// <param name="vect"></param>
		/// <param name="basis1stAngle"></param>
		/// <param name="secondaryBasisAngle"></param>
		/// <returns></returns>
		static public double[] _Coords_assumeBasisCross(
			planar.Vect4dblI vect
			,
			planar.Vect4dblI basis1stAngle
			,
			planar.Vect4dblI secondaryBasisAngle
		) {

			var matrix1 = new nilnul.num.real.matrix_.square_.Secondary4dbl(
				basis1stAngle.point.x
				,
				basis1stAngle.point.y
				,
				secondaryBasisAngle.point.x
				,
				secondaryBasisAngle.point.y
			);

			var sln = nilnul.num.real.matrix_.square_.invertible.op_.unary_.Invert._Matrix_assumeSquare1invertible(
				matrix1
			);

			return nilnul.num.real.matrix.co_.multible._MultiX._Multiply_assumeSociable(
				sln
				,
				vect.point.AsArray()
			);

			
		}

	}
}
