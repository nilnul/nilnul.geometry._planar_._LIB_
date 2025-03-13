using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.geometry.planar.morph_._rebase
{
	static public class _MatrixX
    {
		/// <summary>
		/// 
		/// </summary>
		/// <param name="a"></param>
		/// <param name="b"></param>
		/// <returns></returns>
		///
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		static public double[,] OfRows(C a, C b) {
			return new[,] {
				{ a.Real,a.Imaginary}
				,
				{ b.Real,b.Imaginary}
			}; 
		}
    }
}
