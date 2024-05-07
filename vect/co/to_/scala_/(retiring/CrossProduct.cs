using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using R = nilnul.num.RealI;

namespace nilnul.geometry.planar.vector.co
{
	[Obsolete(nameof(to_.real_.CrossProduct))]
	public class CrossProduct
	{

		static public R Eval_AreaOfParallelogram(Point x, Point y) {
			return Matrix.GetDeterminant(x, y);

		}
	}
}
