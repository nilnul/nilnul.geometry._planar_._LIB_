using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.geometry.planar.cycle_.triangle.cevian.theorem_.stewart_
{

	internal class Apollonius
	{

		static public bool Eq(double left, double right, double basis, double median) {

			return left * left + right * right == 2 * (
				nilnul.num.real.op_.Square.Singleton.op(basis/2)
				+
				median *median
			);
		}
	}
}
