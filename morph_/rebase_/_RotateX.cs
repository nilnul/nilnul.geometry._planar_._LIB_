using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.geometry.planar.morph_.rebase_
{
	static public class _RotateX
	{
		/// <summary>
		/// Mx=y, where x is a vect.
		/// 
		/// </summary>
		/// <param name="rotation"></param>
		/// <returns></returns>
		static public double[,] GenCols_0rotation(double rotation) {
			double sin = Math.Sin(rotation);
			double cos = Math.Cos(rotation);
			return new[,] {
				{cos,-sin }
				,
				{ sin,cos}
			};      /// in Complex: cos(t) + i sin(t), which multiplies a+bi to get (a cos(t) - b sin(t)) + i (a sin(t) + b cos(t)), where the components map to the matrix.
		}

		/// <summary>
		/// xM=y, where x is a vect.
		/// 
		/// </summary>
		/// <remarks>
		/// row major is preferred to colwise.
		/// </remarks>
		static public double[,] GenRows_0rotation(double rotation) {
			double sin = Math.Sin(rotation);
			double cos = Math.Cos(rotation);
			return new[,] {
				{cos,sin }
				,
				{- sin,cos}
			}; 
		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="rotation">
		/// a unial:<see cref="nilnul.num.complex_.IRotar"/>:
		///  a+bi,in (a+bi) (c+di) = ac -bd + (ad+bc)i = (c,d).(a,-b) + i (c,d).(b,a) = (a+bi)*c + (-b +ai)d  , correspondign to matrix multiplier:
		///  [a,b], [-b,a]
		///		
		/// </param>
		/// <returns>
		/// a row major matrix that rotates a vector by the given angle:arccos(<paramref name="rotation"/>.real), or arcsin(<paramref name="rotation"/>.imaginary)
		/// </returns>
		///
		[MethodImpl(MethodImplOptions.AggressiveInlining)]

		static public double[,] _GenRows_0rotar(C rotation) {
			return new[,] {
				{rotation.Real, rotation.Imaginary}
				,
				{-rotation.Imaginary,rotation.Real}
			}; 
		}


		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		static public double[,] _GenCols_0rotar(C rotation) {
			return nilnul.num.real.matrix.op_.unary_.Transpose.Op(
				_GenRows_0rotar(rotation)
			);
				; 
		}




	}
}
