using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using static System.Math;

namespace nilnul.bit.expr_.tauto_.real_
{
	public class _TrignoX
	{
		/// <summary>
		/// </summary>
		/// <param name="a"></param>
		/// <param name="b"></param>
		/// <returns></returns>
		
		static public System.Linq.Expressions.Expression SinSq_CosSq(double a) {
			return (
				(Expression<Func<double,bool >>) (
					(double a)
					=>

					nilnul.num.real.accumulate_.SqSum.Singleton.accumulate(
					
						Cos(a)
					
					,
					
						Sin(a)
					)==1

				)
			).Body;
		}

	

	}
}
