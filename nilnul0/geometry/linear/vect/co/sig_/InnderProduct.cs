using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.geometry.linear.vect.co.sig_
{


	static public class _InnerProduct4DblX
	{
		/// <summary>
		/// perpendicular(inner Product is zero) or not
		/// </summary>
		/// <param name="x"></param>
		/// <param name="y"></param>
		/// <returns>
		/// true: sameDirection; 
		/// false opposite; 
		/// null: perpendiculare(including one of the vector is zero vector)
		/// </returns>
		static public bool? Sign( double x, double y  ) {
			return nilnul.num.real._SignDblX.BitNul(
				co.to_.real_._InnerProductX.InnerProduct(x, y)
			);
		}

		public static bool? Sign(linear.PointDblI x, linear.PointDblI y)
		{
			return Sign(x.coord,y.coord);
			//throw new NotImplementedException();
		}

		public static bool? Sign(VectorDbl basis, VectorDbl obj)
		{
			return Sign(basis.end, obj.end);
		}
	}
}
