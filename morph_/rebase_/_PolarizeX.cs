using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.geometry.planar.morph_.rebase_
{
	static public class _PolarizeX
	{

		/// <summary>
		/// rotation and scale
		/// </summary>
		/// <remarks>
		/// but not shear
		/// </remarks>
		/// <param name="rotation">
		///  a+bi,in (a+bi) (c+di) = ac -bd + (ad+bc)i = (c,d).(a,-b) + i (c,d).(b,a) = (a+bi)*c + (-b +ai)d  , corresponding to matrix multiplier:
		///  [a,b], [-b,a]
		///		
		/// </param>
		/// <returns>
		/// a row major matrix that rotates a vector by the given angle:arccos(<paramref name="rotation"/>.real), or arcsin(<paramref name="rotation"/>.imaginary)
		/// </returns>
		///
		[MethodImpl( MethodImplOptions.AggressiveInlining)]
		static public double[,] GenRows(C rotation) {
			return new[,] {
				{rotation.Real, rotation.Imaginary}
				,
				{-rotation.Imaginary,rotation.Real}
			};		/// we can say the matrix is <see cref="nilnul.num.real.matrix_.sq.be_._NegSymmetricX"/>; for those not negSymmetrix, it cannot be represented by complex number;
		}



	}
}
