using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.geometry.dimed.vect.op_.binary_
{
	/// <summary>
	/// component-wise subtraction
	/// </summary>
	static public class _MinusX
	{
		static public IEnumerable<double> Dbls_assumeSameDim(IEnumerable<double> x, IEnumerable<double> y)
		{
			return 
				 x.Zip(y, (a, b) => a-b )
			;
		}

		


	}
}
