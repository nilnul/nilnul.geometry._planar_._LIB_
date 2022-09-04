using nilnul.geometry.linear.vect.co.categorize_._inside;
using System;

namespace nilnul.geometry.linear.vect.co.categorize_
{
	static public class _InsideX
	{
		static public _inside.Category Inside(Vector basis, Vector obj)
		{

			var pSinceLeft_position = nilnul.geometry.linear.vect.co.sig_.Perpend.Singleton.sign( 
				basis,obj
				
				
				
			);

			var pSinceRight_position = nilnul.geometry.linear.vect.co.sig_.Perpend.Singleton.sign(

				basis
				,
				obj-basis
				
			);

			if (pSinceLeft_position == false)
			{
				return _inside.Category.Left;
			}
			if (pSinceLeft_position == null)
			{
				if (pSinceRight_position == false)
				{
					return _inside.Category.AtLeftEnd;
				}
				
				return _inside.Category.AtBothEnd;
			}

			/// p sinceLeft is true
			/// 
			if (pSinceRight_position == false)
			{
				return _inside.Category.InBetween;
			}
			if (pSinceRight_position == null)
			{
				return _inside.Category.AtRightEnd;
			}
			return _inside.Category.Right;

		}

		public static Category Inside(Duo obj)
		{
			return Inside(obj.Item1,obj.Item2);
			throw new NotImplementedException();
		}
	}
}
