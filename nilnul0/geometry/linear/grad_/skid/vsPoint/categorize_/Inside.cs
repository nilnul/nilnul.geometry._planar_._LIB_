using nilnul.geometry.linear.grad.point.categorize_;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using C = nilnul.geometry.linear.vect_.basis.vector.categorize_._inside.Category;

namespace nilnul.geometry.linear.grad_.arrow.point.categorize_
{
	static public class _InsideX
	{

		static public C _Inside(Grad _arrow, Point p)
		{

			return nilnul.geometry.linear.vect_.basis.vector.categorize_._InsideX._Inside(
				_arrow.Item2 - _arrow.Item1
				,
				p - _arrow.Item1
			);
			
		}

	}
}
