using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.geometry.planar.morph_
{

	public class _MatrixX
	{
		static public (double, double) Trans((double,double) coord, double[,] matrixTwoByTwo) {
			var t= nilnul.num.real.matrix.duo_.sociable.Multi.Multiply(
				new[] { coord.Item1, coord.Item2 }, matrixTwoByTwo
				);
			return (t[0], t[ 1]);

			
		}

		static public (double, double) Trans( double[,] matrixTwoByTwo,(double,double) coord) {
			var t= nilnul.num.real.matrix.duo_.sociable.Multi._Multiply(
				matrixTwoByTwo
				,
				new[] { coord.Item1, coord.Item2 }

				);
			return (t[0], t[ 1]);

			
		}


	}
}
