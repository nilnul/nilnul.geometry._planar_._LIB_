using nilnul.geometry.linear.vect_;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.geometry.linear.vect.co.prod.sig_
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

		internal static bool? Re(VectI item1, VectI item2)
		{
			return nilnul.num.real.Sign.Singleton.sign(
				co._InnerProductX.InnerProduct(item1, item2)
			);

		}
	}
	public class Perpend : SigI
	{
		public bool? sign(Duo obj)
		{
			return _PerpendX.Re(obj.Item1,obj.Item2);
			//throw new NotImplementedException();
		}

		public bool? sign(Point x, Point y) {
			return _PerpendX.Re(x,y);
		}

		public bool? sign(Co obj)
		{
			return _PerpendX.Re(obj.Item1,obj.Item2);
		}

		public  bool? sign(VectI basis, VectI vector)
		{
			return _PerpendX.Re(basis , vector);
		}
		public  bool? sign(VectI basis, Vector vector)
		{
			return _PerpendX.Re(basis , vector);
		}



		static public Perpend Singleton
		{
			get
			{
				return nilnul._obj.Singleton<Perpend>.Instance;
			}
		}

	}
}
