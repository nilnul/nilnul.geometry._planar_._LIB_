using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.geometry.planar.morph_.matrixed_.shear_.slant_
{
	public interface IRotateVerticalAxis:ISlant { }

	/// <summary>
	/// shear only one axis
	/// alias:
	///		skew/slant
	/// </summary>
	public class ShearAlongX
	{

		/// <summary>
		/// matrix is at the left in multiplication.
		/// </summary>
		/// <param name="k"></param>
		/// <returns></returns>
		static public double[,] CreateMatrix(double k) {
			return new double[,] {
				{ 1,k}
				,
				{0,1 }

			};
		}


		/// <summary>
		/// matrix is at the left in multiplication.
		/// </summary>
		/// <param name="angle"> </param>
		
		static public double[,] CreateMatrixFroRotation(double angle) {
			return CreateMatrix(
				Math.Tan(angle)	
			);
		}
	}
}
