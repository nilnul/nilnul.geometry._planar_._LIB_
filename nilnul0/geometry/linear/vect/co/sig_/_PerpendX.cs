using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.geometry.linear.vect.co.sig_
{


	static public class _PerpendX
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
		static public bool? Re( nilnul.num.Real x, nilnul.num.Real y  ) {
			return nilnul.num.real.Sign.Singleton.sign(
				co.to_.real_._InnerProductX.InnerProduct(x, y)
			);
		}

		public static bool? Re(Point x, Point y)
		{
			return nilnul.num.real.Sign.Singleton.sign( 
				nilnul.geometry.linear.vect.co.to_.real_.InnerProduct.Singleton.op(x,y)
				
			);
			//throw new NotImplementedException();
		}

		public static bool? Re(PointI x, PointI y)
		{
			return nilnul.num.real.Sign.Singleton.sign( 
				nilnul.geometry.linear.vect.co.to_.real_.InnerProduct.Singleton.op(x,y)
				
			);
			//throw new NotImplementedException();
		}

		public static bool? Re(VectI item1, VectI item2)
		{
			return Re(item1.end,item2.end);
			//throw new NotImplementedException();
		}
	}
}
