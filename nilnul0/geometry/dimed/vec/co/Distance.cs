using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.geometry.dimed.vect.co
{
	static public  class _DistanceX
	{
		static public double Dbl_assumeSameDim(IEnumerable<double> x, IEnumerable<double> y)
		{
			return DistanceFroOrigin(
				vect.op_.binary_._MinusX.Dbls_assumeSameDim(x,y)
			);
		}


		/// <summary>
		/// distance from zero
		/// </summary>
		/// <param name="x"></param>
		/// <returns></returns>
		static public double DistanceFroOrigin(IEnumerable<double> x )
		{
			return Math.Sqrt(
				_InnerProdX.Dbl( x) 
			);
		}


		static public double DistanceFroOrigin(params double[] x )
		{
			return DistanceFroOrigin((IEnumerable<double>)x);
		}



		


	}
}
