using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.geometry.planar.curve_.quotient_
{
	/// <summary>
	/// Witch of Agnesi
	/// </summary>
	/// <remarks>
	/// <seealso cref="nameof(curve_.func.interpolate_.polys.theorem_.weierstrass._RungeX)"/>
	/// </remarks>
	///
	public interface IAgnesi
		: curve_.func_.IPolynomial
	{ }
	public class Agnesi

	{
		
			static public Expression<Func<double, double>> Func(double x)
			{
				Expression<Func<double, double>> l =
					y =>
					1
					/
					(
						1 +  nilnul.num.real.op_.unary_.Square.Singleton.op(y)
					)
				;
				return l;


		
		}
	}
}
