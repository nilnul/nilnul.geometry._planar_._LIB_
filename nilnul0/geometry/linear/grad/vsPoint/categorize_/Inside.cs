using nilnul.geometry.linear.grad.point.categorize_;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using C = nilnul.geometry.linear.vect.co.categorize_._inside.Category;


namespace nilnul.geometry.linear.grad.point.categorize_
{
	static public class _InsideX
	{

		static public C Inside(Grad grad, Point p)
		{
			return nilnul.geometry.linear.vect.co.categorize_.Inside.Singleton.categorize(
				grad.Item2 - grad.Item1
				,
				p - grad.Item1
			);


		}



	}


}
