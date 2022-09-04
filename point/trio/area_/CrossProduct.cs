using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using R = nilnul.num.RealI;


namespace nilnul.geometry.planar.point.trio.area_
{
	public class CrossProduct
	{
		/// <summary>
		/// must align the direction of points with the CroosProduct right hand rule. The sign may be plus or minus.
		/// </summary>
		/// <param name="a"></param>
		/// <param name="b"></param>
		/// <param name="c"></param>
		/// <returns></returns>
		static public R Eval(Point1 a, Point1 b, Point1 c) {
			return nilnul.geometry.planar.vector.co.CrossProduct.Eval_AreaOfParallelogram(
				b.Minus(a)
				,
				c.Minus(b)	
			).Half();

		}
	}
}
