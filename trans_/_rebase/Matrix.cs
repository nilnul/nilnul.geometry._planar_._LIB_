using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.geometry.planar.trans_._rebase
{
	/// <summary>
	/// most linear transformations are matrixed ones
	/// </summary>
	static public class _Matrixed
	{


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
