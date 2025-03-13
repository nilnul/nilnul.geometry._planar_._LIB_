using System;
using System.Runtime.CompilerServices;

namespace nilnul.geometry.planar.morph_.rebase_.shear_.invertible
{
	/// <summary>
	/// 
	/// </summary>
	/// <seealso cref="planar.vect._DecomposeX"/>
	static public class _InvertX
	{
		/// <summary>
		/// 
		/// </summary>
		/// <param name="a">rotation of x</param>
		/// <param name="b">newY by the azimuth from +x</param>
		/// <returns>
		/// the inverted matrix
		/// </returns>
		///  x A =x'
		///  ,where A is the resulted matrix, x is the old coordinates;
		///  , x' would be new force.for the two new directions.
		///  
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		static public double[,] _InvertedMatrix_assumeUnalign(double a, double b)
		{

			//var coef = 1 / Math.Sin(b-a);
			var d = Math.Sin(b-a);


			return new[,] {
				{ Math.Sin(b) / d, -Math.Sin(a)/d }
				,
				{ -Math.Cos(b) / d, Math.Cos(a)/d }
			};

			return nilnul.num.real.matrix_.square_.invertible.op_.unary_.Invert._Matrix_assumeSquare1invertible(
				shear_._InvertibleX._Matrix_assumeUnalign(a, b)             /// cos(a), sin(a)
																			/// cos(b), sin(b)
																			/// ,the determinant of which is cos(a)sin(b) -sin(a)cos(b) = sin(b-a)
																			/// 
			);  /// <see cref="nilnul.num.real.matrix_.square.op_.unary_.CofactorMatrix"/>
				///		sin(b) ,  -cos(b)
				///		-sin(a),	cos(a)
				/// transpose:
				///		sin(b) ,  -sin(a)
				///		-cos(b),	cos(a)
				///
				/// per determinant
				///  1/sin(b-a) *:
				///		sin(b) ,  -sin(a)
				///		-cos(b),	cos(a)
				///		

		}
	}
}
