using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.geometry.linear.vect.re_
{
	
		/// <summary>
		/// vector as point.Set including the other
		/// </summary>
	static public class _IncludeX
	{
		/// <param name="v"></param>
		/// <returns></returns>
		static public bool Be(VectI vector, VectI vector2BeIncluded)
		{
			return linear.vect_.nonneg.vsVector.be_._IncludeX.Be(

					linear.vect.co._InnerProductX.Sqaure(vector)
					,
					new Vector(
						linear.vect.co._InnerProductX.InnerProduct(vector, vector2BeIncluded)
					)
			);

			
			
		}

		/// <summary>
		/// by projection
		/// </summary>
		/// <param name="vector"></param>
		/// <param name="vector2BeIncluded"></param>
		/// <returns></returns>
		static public bool Be(Vect4dblI vector, Vect4dblI vector2BeIncluded)
		{
			return linear.vect_.nonneg.vsVector.be_._IncludeX.Be(

					linear.vect.co._InnerProductX.Sqaure(vector)
					,
					new VectorDbl(
						linear.vect.co._InnerProductX.InnerProduct(vector, vector2BeIncluded)
					)
			);

			
			
		}


	}
}
