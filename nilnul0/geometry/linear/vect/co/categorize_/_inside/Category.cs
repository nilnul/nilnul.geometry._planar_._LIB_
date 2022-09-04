using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using nilnul.num;

namespace nilnul.geometry.linear.vect.co.categorize_._inside
{
	public enum Category
	{
		Left,
		AtLeftEnd
			,
		InBetween
			,
		AtBothEnd
			,
		AtRightEnd
			, Right

	}

	/// <summary>
	/// 
	/// </summary>
	static public class CategoryX{

		/// <summary>
		/// if the negate the base(the Item1 of the Duo)
		/// </summary>
		/// <param name="c"></param>
		/// <returns></returns>
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
				case Category.AtBothEnd:
					return Category.AtBothEnd;
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
