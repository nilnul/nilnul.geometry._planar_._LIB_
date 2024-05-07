using nilnul.geometry.planar.point.as_;
using nilnul.geometry.planar.vect_;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.geometry.planar.vect.to_.co_.decompose_.cross_
{
	/// <summary>
	/// decompose into two normal vector
	/// </summary>
	static public class _NormalX
	{
		static public double[] _Coords_assumeBasisCross(
			planar.Vect4dblI vect
			,
			double basis1stAngle
			,
			double secondaryBasisAngle
		) {

			var basisMatrix = new nilnul.num.complex_.polar_.Unital4dbl(
				basis1stAngle
			);

			var seondoarComplex = new nilnul.num.complex_.polar_.Unital4dbl (
				secondaryBasisAngle
			);

			var matrix1 = new nilnul.num.real.matrix_.square_.Secondary4dbl(
				basisMatrix.x,
				basisMatrix.y
				,
				seondoarComplex.x
				,
				seondoarComplex.y
			);
			/// solve Ax=Vect, where A is the basis.
			/// so x=Vect/A or Vect*A^-1
			///
			var sln = nilnul.num.real.matrix_.square_.invertible.op_.unary_.Invert._Matrix_assumeSquare1invertible(
				matrix1
			);

			return nilnul.num.real.matrix.co_.multible._MultiX._Multiply_assumeSociable(
				sln
				,
				vect.point.AsArray()
			);

			
		}

		static public Polar4dbl_radius1st[] _Vects_assumeBasisCross(
			planar.Vect4dblI vect
			,
			double basis1stAngle
			,
			double secondaryBasisAngle
		) {
			var coords=_Coords_assumeBasisCross(
				vect,basis1stAngle,secondaryBasisAngle
			);

			return new vect_.Polar4dbl_radius1st[]{
				new vect_.Polar4dbl_radius1st(
					coords[0]
					,
					basis1stAngle
				)
				,
				new vect_.Polar4dbl_radius1st(
					coords[1]
					,
					secondaryBasisAngle
				)

			};
			
		}

	}
}
