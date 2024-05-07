using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.geometry.planar.morph_.matrixed_.shear_.slant_
{
	public interface IRotateHorizonAxis
	:ISlant{

	}

	/// <summary>
	/// shear only one axis
	/// alias:
	///		skew/slant
	/// </summary>
	public class ShearAlongY
	{
		static public double[,] CreateMatrix(double k) {
			return new double[,] {
				{ 1,0}
				,
				{k,1 }

			};
		}

		static public double[,] CreateMatrixFroRotation(double angle)
		{
			return CreateMatrix(
				Math.Tan(angle)
			);
		}

	}
}
