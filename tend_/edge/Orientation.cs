using nilnul.geometry.planar.point;
using nilnul.geometry.planar.point.twin_;
using nilnul.geometry.planar.rotation_;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.geometry.planar.tend_.edge
{
	static public class _OrientationX
	{
		public static Orientation _assumeDif(Point1 begin, Point1 end)
		{
		
			var direction = planar.grad_.skid._DirectionX._Direction_assumeDif(begin,end);
			if (direction < nilnul.num.real_.TauX.Half)
			{
				return new rotation_.Orientation( direction );
			}
			return new rotation_.Orientation( direction - nilnul.num.real_.TauX.Half);
		}

		static public nilnul.geometry.planar.rotation_.Orientation Orientation(planar.tend_.Edge edge) {
			return _assumeDif(edge.en.component,edge.en.component1);
		}

		public static double _assumeDif(Point4dbl begin, Point4dbl end)
		{
			var direction = planar.grad_.skid._DirectionX._Direction_assumeDif(begin , end );

			if (direction < nilnul.num.real_.TauX.HalfD)
			{
				return ( direction );
			}
			return ( direction - nilnul.num.real_.TauX.HalfD);
		
		}

		public  static double Orientation(CoD ee)
		{

			return _assumeDif(ee.component.ToOrthogonal(), ee.component1.ToOrthogonal());
		}

		public static Orientation Orientation(planar.point.twin_.Dif points)
		{
			return _assumeDif( points.en.begin, points.en.end);
		}

	}
}
