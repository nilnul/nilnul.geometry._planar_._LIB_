using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.geometry.planar.tend_.originated.vsPoint_.coline.be_
{
	static public class _HasX
	{
		static public bool _Has(
			 PointI1 end, PointI1 _point_colinear
	   )
		{
			return nilnul.geometry.linear.span.vsPoint.be_._HasX.Has(
				new linear.tend_.Originated(
					planar.vect.co.to_.real_._DotProductX.RealI_Square(end)
				)
				,
				new linear.Point(
					planar.vect.co.to_.real_._DotProductX.RealI(_point_colinear, end)
				)
			);
		}

		public  static bool _Has(Point4dbl span, Point4dbl pointDbl2)
		{
			return nilnul.geometry.linear.span.vsPoint.be_._HasX.Has(
				new linear.tend_.OriginatedDbl(
					planar.vect.co.to_.real_._DotProductX.Square(span)
				)
				,
				new linear.PointDbl(
					planar.vect.co.to_.real_._DotProductX.Dbl(pointDbl2, span)
				)
			);

		}
	}
}
