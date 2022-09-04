using nilnul.geometry.linear.grad.point.categorize_;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.geometry.linear.vect.vsPoint
{
	static public class _LayoutX
	{

		/// <summary>
		/// note: the vector may point to negative infinity
		/// </summary>
		/// <param name="_basis"></param>
		/// <param name="p"></param>
		/// <returns></returns>
		static public vect_.positive.vsPoint._layout.Category Layout(linear.VectI _basis, linear.Point p)
		{
			var baseSquare = linear.vect.co._InnerProductX.Sqaure(_basis);

			var pointProduct = linear.vect.co._InnerProductX.InnerProduct(new linear.Vector( p), _basis);

			return vect_.nonneg.vsPoint._LayoutX.Layout(baseSquare, pointProduct);

		}

		//public static vector_.positive.vsPoint._layout.Category Layout(Point point1, Point point2)
		//{
		//	return Layout( new linear.Vector(point1), point2);
		//}
	}
}
