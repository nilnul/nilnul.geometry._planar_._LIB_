using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.geometry.planar.morph_._rebase
{

	public interface IMatrix
		:
		nilnul.num.real.matrix_.square_.ISecondary
		//,
		//nilnul.num.real.matrix_.sq_.
		{ }
	/// <summary>
	/// most linear transformations are matrixed ones
	/// </summary>
	/// <remarks>
	/// the defaulted is rowMajor: the 1st row is the newI, the 2nd row is the newJ.
	/// when the input is put to the right, the input is newCoord, the output is the oldCord;
	/// when the input is put to the left, this is 
	/// </remarks>
	static public class _Matrixed
	{


		/// <summary>
		/// multi by putting the matrix at the left.
		/// </summary>
		/// <param name="_matrix2x2"></param>
		/// <param name="point"></param>
		/// <returns></returns>
		///
		[Obsolete()]
		static public Point4dbl _Eval(double[,] _matrix2x2, Point4dbl point) {
			var t= nilnul.num.real.matrix.duo_.sociable.Multi._Multiply(
				_matrix2x2
				,
				new[] { point.x,point.y}
			);
			return new Point4dbl(t[0],t[1]);
		}
	}
}
