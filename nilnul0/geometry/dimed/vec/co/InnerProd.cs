using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.geometry.dimed.vect.co
{
	static public class _InnerProdX
	{
		static public double Dbl_assumeSameDim(IEnumerable<double> x, IEnumerable<double> y)
		{
			return  op_.binary_._MultiX.Dbls_assumeSameDim(x,y).Sum();
		}

		/// <summary>
		/// square sum
		/// </summary>
		/// <param name="x"></param>
		/// <returns></returns>
		static public double Dbl(IEnumerable<double> x)
		{
			return op_.binary_._MultiX.Dbls(x).Sum();
		}


	}
}
