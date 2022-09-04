using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.geometry.dimed.vect.op_.binary_
{
	/// <summary>
	/// termwise multiply. Note this is a binary op, so the result is also a vect.
	/// 
	/// </summary>
	static public class _MultiX
	{
		static public IEnumerable<double> Dbls_assumeSameDim(IEnumerable<double> x, IEnumerable<double> y)
		{
			return 
				 x.Zip(y, (a, b) => a*b )
			;
		}

		static public IEnumerable<double> Dbls(IEnumerable<double> x)
		{
			return x.Select(
				a => nilnul.num.real.op_.unary_.Square.Singleton.op(a)
			);
		}




	}
}
