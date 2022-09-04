using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.geometry.planar.curve_.func_.poly
{
	/// <summary>
	/// 
	/// </summary>
	static public class Interpolate
	{
		/// <summary>
		/// en.wikipedia.org/wiki/Polynomial_interpolation
		/// we may write down the polynomial immediately in terms of Lagrange polynomials:
		/// </summary>
		/// <param name="points"></param>
		/// <returns></returns>
		static public Expression<Func<double, double>> Lambda_assumeHorizonsDistinct(params Point4dblI[] points) {

			var range = Enumerable.Range(0, points.Length);

			Expression<Func<double, double>> l = x =>
				Enumerable.Range(0, points.Length).Select(
					i=> points[i].y
					*
					nilnul.num.real.op_.binary_.multi.Cumulator4dbl.Singleton.accumulate
					(
						range.Except(new[] { i}).Select(
							j=>
						(x- points[j].x) / (points[i].x - points[j].x)
						)
					)
				).Sum()
			;
			return l;
		}
	}
}
