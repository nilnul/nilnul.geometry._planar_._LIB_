using System;
using System.Collections.Generic;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.real.matrix_.sq_
{
	static public class _TertiaryX
	{
		static public float[,] ToArray2dimension(Matrix matrix) {

			var linear = matrix.Elements;

			return new[,]{
				{ linear[0], linear[1], 0 }
				,
				{ linear[2], linear[3], 0 }
				,
				{ linear[4], linear[5], 1 }
			};
		}
		static public double[,] Element2double(Matrix matrix) {

			return nilnul.num.real.matrix.of_._Element2doubleX.ElAsDouble(
				nilnul.num.real.matrix_.sq_._TertiaryX.ToArray2dimension(
					matrix
				)
			);
		}

	}
}
