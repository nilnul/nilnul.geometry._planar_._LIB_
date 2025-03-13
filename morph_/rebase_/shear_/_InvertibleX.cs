using System.Runtime.CompilerServices;

namespace nilnul.geometry.planar.morph_.rebase_.shear_
{
	static public class _InvertibleX
	{
		/// <summary>
		/// 
		/// </summary>
		/// <param name="a">rotation of x</param>
		/// <param name="b">newY by the azimuth from +x</param>
		/// <returns>
		/// cos(a), sin(a)
		/// cos(b), sin(b)
		/// , the determinant of which is cos(a)sin(b) -sin(a)cos(b) = sin(b-a), which is in (-1,1) but is not 0, as b a is not algined (<see cref="rotation.re_.IAlign"/>). 
		/// </returns>
		/// the result can be inverted to decompose a vector.
		///
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		static public double[,] _Matrix_assumeUnalign(double a, double b) {
			return planar.morph_._rebase._MatrixX.OfRows(
				nilnul.num.complex_.polar_._UnialX.Of(a)
 ,
				nilnul.num.complex_.polar_._UnialX.Of(b)

			);

		}
	}
}
