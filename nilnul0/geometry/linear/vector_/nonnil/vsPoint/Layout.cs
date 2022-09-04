using nilnul.geometry.linear.grad.point.categorize_;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.geometry.linear.vect_.nonnil.vsPoint
{
	static public class _LayoutX
	{

		/// <summary>
		/// note: the vector may point to negative infinity
		/// </summary>
		/// <param name="_basis"></param>
		/// <param name="p"></param>
		/// <returns></returns>
		static public positive.vsPoint._layout.Category Layout(linear.vect_.Nonnil _basis, linear.Point p)
		{



			var pMinusRight = p -  _basis.end;


			


			var pSinceLeft_position = nilnul.geometry.linear.vect.co.prod.sig_.Perpend.Singleton.sign( _basis,new linear.Vector( p));

			var pSinceRight_position = nilnul.geometry.linear.vect.co.prod.sig_.Perpend.Singleton.sign(
				_basis, new linear.Vector( pMinusRight) );



			if (pSinceLeft_position == false)
			{
				return positive.vsPoint._layout.Category.Behind;
			}
			if (pSinceLeft_position == null)	//p must be zero
			{
				
				return positive.vsPoint._layout.Category.Start;
			
			}

			/// p sinceLeft is true; so it's away from the origin point to the same direction as basis
			/// 
			if (pSinceRight_position == false)
			{
				return positive.vsPoint._layout.Category.Between;
			}
			if (pSinceRight_position == null)	//the two vector is the same
			{
				return positive.vsPoint._layout.Category.Stop;
			}
			return positive.vsPoint._layout.Category.Forward;

		}

		public static positive.vsPoint._layout.Category Layout(Point point1, Point point2)
		{
			return Layout( new Nonnil(point1), point2);
		}
	}
}
