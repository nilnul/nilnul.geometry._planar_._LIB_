using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using nilnul.num;

namespace nilnul.geometry.linear.vect_.nonneg_.notnil.as_.basis.of_.vector.categorize_._inside
{
	public enum Category
	{
		Left,
		AtLeftEnd
			,
		InBetween
			,
		AtRightEnd
			, Right

	}

	static public class CategoryX{

		static public Category Negate(Category c) {
			switch (c)
			{
				case Category.Left:
					return Category.Right;
					break;
				case Category.AtLeftEnd:
					return Category.AtRightEnd;
					break;
				case Category.InBetween:
					return Category.InBetween;
					break;
				
				case Category.AtRightEnd:
					return Category.AtLeftEnd;
					break;
				case Category.Right:
					return Category.Left;
					break;
				default:
					throw new UnexpectedReachException();
					break;
			}
		}
	}



}
