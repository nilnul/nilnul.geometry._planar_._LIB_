using nilnul.geometry.linear.grad.point.categorize_;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.geometry.linear.vect_.basis.vector.categorize_
{
	[Obsolete(nameof(linear.vect_.nonnil.vsPoint._LayoutX))]
	static public class _InsideX
	{

		static public _inside.Category _Inside(Vector _basis, Vector p)
		{



			var pMinusRight = p - _basis;


			


			var pSinceLeft_position = nilnul.geometry.linear.vect.co.sig_.Perpend.Singleton.sign( _basis,p);

			var pSinceRight_position = nilnul.geometry.linear.vect.co.sig_.Perpend.Singleton.sign(  _basis, pMinusRight);

			if (pSinceLeft_position == false)
			{
				return _inside.Category.Left;
			}
			if (pSinceLeft_position == null)	//p must be zero
			{
				
				return _inside.Category.AtLeftEnd;
			
			}

			/// p sinceLeft is true; so it's away from the origin point to the same direction as basis
			/// 
			if (pSinceRight_position == false)
			{
				return _inside.Category.InBetween;
			}
			if (pSinceRight_position == null)	//the two vector is the same
			{
				return _inside.Category.AtRightEnd;
			}
			return _inside.Category.Right;

		}

	}
}
