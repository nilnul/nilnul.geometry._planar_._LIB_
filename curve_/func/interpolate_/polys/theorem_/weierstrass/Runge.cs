using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.geometry.planar.curve_.func.interpolate_.polys.theorem_.weierstrass
{
	/**************
	 Runge's phenomenon


	 */
	static public class _RungeX
	{

		static public Expression<Func<double, double>> Func(double x) {
			Expression<Func<double,double>> l=
				y=>
				1
				/
				(
					1+25 * nilnul.num.real.op_.unary_.Square.Singleton.op(y)
				)
			;
			return l;


		}
	}
}
