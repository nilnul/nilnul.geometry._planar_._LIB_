using nilnul.num;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.geometry.linear.vect_.nonneg.vsVector.be_
{
	
	static public class _IncludeX
	{
		/// <summary>
		/// </summary>
		/// <param name="v"></param>
		/// <returns></returns>
		static public bool _Be(Vector _nonneg, VectI p)
		{


			return linear.vect_.nonneg.vsPoint.be_._HasX._Be(
				_nonneg,p.end
			);
			
		}


		static public bool _Be(Vector _nonneg, Vector p)
		{
			return _Be(_nonneg, (VectI)p);

			
			
		}


		static public bool Be(vect_.Nonneg nonneg, Vector p) {

			return _Be(nonneg,p);
		}

		static public bool Be(vect_.Nonneg nonneg, VectI p) {

			return _Be(nonneg,p);
		}

		public static bool Be(RealI realI, VectI vector2BeIncluded)
		{
			return Be(
				new linear.vect_.Nonneg(realI),vector2BeIncluded
			);
		}


		public static bool Be(vect_.NonnegDbl v, VectorDbl vectorDbl)
		{
			return vect_.nonneg.vsPoint.be_._HasX.Be(v, vectorDbl);
		}
		public static bool Be(double v, VectorDbl vectorDbl)
		{
			return Be(new vect_.NonnegDbl(v) , vectorDbl );
		}
	}
}
