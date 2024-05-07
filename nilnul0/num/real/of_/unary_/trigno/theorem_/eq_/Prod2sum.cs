using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using static System.Math;

namespace nilnul.num.real.of_.unary_.trigno.theorem_.eq_
{
	static public class _Prod2sumX
	{
		static public Expression<Func<double,double, bool>> Expr(double x,double y) {
			return (x, y) => Sin(x) * Sin(y)
			==
			(Cos(x - y) - Cos(x + y) )/2;
		}
	}
}
