using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using N = nilnul._num.bigint.be.Natural.Asserted;
using Q1 = nilnul.num.Quotient1;
using Qr = nilnul.num.real_.Quotient;
using R = nilnul.num.RealI;
using Rx = nilnul.num.RealIX;

using nilnul.num;
using nilnul.geometry.planar.point_;

namespace nilnul.geometry.planar.vector.co.sig_
{

	static public class _CrossProdX
	{

		/// <summary>
		/// can be understand as the difference of tangent:
		/// y/x -y1/x1  ----> yx1-yx1
		/// </summary>
		/// <param name="x"></param>
		/// <param name="y"></param>
		/// <returns></returns>
		static public bool? Sign(VectorI x, VectorI y)
		{


			return nilnul.num.real.Sign.Singleton.sign(
			   vector.co.to_.real_.CrossProduct.Singleton.to(x,y)
		   );

		}
	}

	/// <summary>
	/// Finds the cross product of the 2 vectors
	/// The vectors make a "left turn" if the sign of the cross product is positive.
	/// The vectors make a "right turn" if the sign of the cross product is negative.
	/// The vectors are colinear (on the same line) if the cross product is zero.
	/// </summary>

	public class CrossProd:SigI
	{
		public bool? sign(Co src)
		{
			return sign(src.Item1,src.Item2);
			//throw new NotImplementedException();
		}

		public bool? sign(VectorI point, VectorI point1) {
			return

				_CrossProdX.Sign(
					
					point,point1
					
					)
				;

		}



		public bool? sign(PointI vector, PointI begin)
		{
			return sign(
				new Vector1(vector) as VectorI
				,
				new Vector1(begin) as VectorI
			);
			//throw new NotImplementedException();
		}

		public bool? sign(Point vector, Point begin)
		{
			return sign(
				new Vector1(vector) as VectorI
				,
				new Vector1(begin) as VectorI
			);
			//throw new NotImplementedException();
		}


		static public CrossProd Singleton
		{
			get
			{
				return nilnul._obj.Singleton<CrossProd>.Instance;
			}
		}

	}
}
