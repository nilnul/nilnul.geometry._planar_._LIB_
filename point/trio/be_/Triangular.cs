using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace nilnul.geometry.planar.point.trio.be_
{
	/// <summary>
	/// nonLinear
	/// </summary>
	public class Triangular
		: BeI
		,trio.BeDblI
	{
		/// <summary>
		/// 
		/// </summary>
		/// <param name="obj"></param>
		/// <returns></returns>
		/// <remarks>
		///		don't use heronFormula for it involves irrationals if the three points are all quotients.
		///		If the three points are quotient, kee this within quotient.
		/// </remarks>
		public bool be(Trio obj)
		{
			//var x = obj.a.x;
			//var y = obj.a.y;
			//var a = obj.b.x;
			//var b = obj.b.y;
			//var a1 = obj.c.x;
			//var b1 = obj.c.y;

			return nilnul.num.real.be_.nil.Anto.Singleton.be(
				
				grad.co._CrossProductX.CrossProduct(
					obj.a ,(obj.b)
					,
					obj.c,(obj.b)
				)
			);
			///establish origin at (a,b), get the vectors : (x,y)-(a,b), and (a1,b1)-(a,b). 
			/// let's see if the two vectors are colinar
			/// 
			/// get their cross product; see if the distance it's zero.
			/// Note: in getting the cross product, the coefficeint of i & j are both zero.
			/// 
			/// if we stack two vectors to get a matrix and compute the determinant of the matrix, the determinant is zero if the two vectors are colinar.



			//			throw new NotImplementedException();
		}

		public bool be(TrioD obj) {
			return   grad.co._CrossProductX.CrossProduct(
					obj.a, (obj.b)
					,
					obj.c, (obj.b)
				) != 0;
		}


		static public Triangular Singleton
		{
			get
			{
				return nilnul._obj.typ_.nilable_.unprimable_.Singleton<Triangular>.Instance;
			}
		}


	}
}
