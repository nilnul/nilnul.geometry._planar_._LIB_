using nilnul.geometry.linear.grad.point.categorize_;
using nilnul.num;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using C = nilnul.geometry.linear.vect_.positive.vsPoint._layout.Category;

namespace nilnul.geometry.linear.grad_.arrow.vsPoint
{
	static public class _LayoutX
	{

		static public C _Layout(Grad _arrow, Point p)
		{

			return nilnul.geometry.linear.vect_.nonnil.vsPoint._LayoutX.Layout(
				_arrow.Item2 - _arrow.Item1
				,
				p - _arrow.Item1
			);
			
		}

		static public C _Layout(grad_.Arrow _arrow, Point p)
		{

			return nilnul.geometry.linear.vect_.nonnil.vsPoint._LayoutX.Layout(
				new vect_.Nonnil(

				_arrow.Item2.x-  _arrow.Item1.x.ToReal()
				)
				,
				p - _arrow.Item1
			);
			
		}


	}
}
