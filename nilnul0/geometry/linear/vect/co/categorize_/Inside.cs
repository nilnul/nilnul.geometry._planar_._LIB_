using nilnul.geometry.linear.grad.point.categorize_;
using nilnul.geometry.linear.vect.co.categorize_._inside;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.geometry.linear.vect.co.categorize_
{

	public class Inside : CategorizeI<_inside.Category>
	{
		public Category categorize(Duo obj)
		{
			return _InsideX.Inside(obj);
			//throw new NotImplementedException();
		}

		public Category categorize(Point point1, Point point2)
		{
			return categorize( new Duo(point1,point2));
			throw new NotImplementedException();
		}

		static public Inside Singleton
		{
			get
			{
				return nilnul._obj.Singleton<Inside>.Instance;
			}
		}

	}
}
