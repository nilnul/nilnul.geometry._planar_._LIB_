using nilnul.geometry.linear.grad.point.categorize_;
using nilnul.geometry.linear.vect.co.categorize_._inside;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.geometry.linear.vect.co.categorize_
{
	static public class _Inside4dblX
	{
		static public _inside.Category Inside(double basis, double obj)
		{

			var pSinceLeft_position = nilnul.geometry.linear.vect.co.sig_._InnerProduct4DblX.Sign( 
				basis,obj
	
			);

			var pSinceRight_position = nilnul.geometry.linear.vect.co.sig_._InnerProduct4DblX.Sign(
				basis
				,
				obj-basis
				
			);

			if (pSinceLeft_position == false)
			{
				return _inside.Category.Left;
			}
			if (pSinceLeft_position is null)
			{
				if (pSinceRight_position == false)
				{
					return _inside.Category.AtLeftEnd;
				}
				
				return _inside.Category.AtBothEnd;
			}

			/// p sinceLeft is true; so it's right to the origin
			/// 
			if (pSinceRight_position == false)
			{
				return _inside.Category.InBetween;
			}
			if (pSinceRight_position is null)
			{
				return _inside.Category.AtRightEnd;
			}
			return _inside.Category.Right;

		}

		static public _inside.Category Inside(linear.VectorDbl basis, linear.VectorDbl obj)
		{
			return Inside(basis.end,obj.end);

			var pSinceLeft_position = nilnul.geometry.linear.vect.co.sig_._InnerProduct4DblX.Sign( 
				basis,obj
	
			);

			var pSinceRight_position = nilnul.geometry.linear.vect.co.sig_._InnerProduct4DblX.Sign(
				basis
				,
				obj-basis
				
			);

			if (pSinceLeft_position == false)
			{
				return _inside.Category.Left;
			}
			if (pSinceLeft_position is null)
			{
				if (pSinceRight_position == false)
				{
					return _inside.Category.AtLeftEnd;
				}
				
				return _inside.Category.AtBothEnd;
			}

			/// p sinceLeft is true; so it's right to the origin
			/// 
			if (pSinceRight_position == false)
			{
				return _inside.Category.InBetween;
			}
			if (pSinceRight_position is null)
			{
				return _inside.Category.AtRightEnd;
			}
			return _inside.Category.Right;

		}

		public static Category Inside(PointDblI end1, PointDblI end2)
		{
			return Inside(end1.coord,end2.coord);
		//	throw new NotImplementedException();
		}
	}

}
