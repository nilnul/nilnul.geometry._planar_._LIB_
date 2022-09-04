using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.geometry.planar.cycle_.gon_.tetra_.convex_.trape_
{

	public class Perpend
	{
		static public planar.Point4dblI ExtendTrigon(planar.cycle_.Triangle4dblI trigon) {
			// protrude prependicularly from the last point, stop at the parrallel (with respect to the point1-point2) line from the first point
			///find the last point
			///
			var newBasisPrimary = nilnul.geometry.planar.grad_.skid._DirectionX._Direction_assumeDif(trigon.points.ee.b, trigon.points.ee.c);



			var rejection = planar.vect.to_.co_.decompose._RejectionX.Rejection(
				
					 planar.grad_._StepX.Vect(
						trigon.points.ee.b
						,
						trigon.points.ee.a
					)
					 ,
					 newBasisPrimary

				
			);

			var lastPoint = trigon.points.ee.c + rejection;

			return lastPoint;









		}

		public static planar.Point4dblI ExtendTrigon_assumeTrigon(Point4dblI point1, Point4dblI point, Point4dbl tip)
		{
			return ExtendTrigon(
				new planar.cycle_.TriangleDbl(point1,point,tip)
			);
			//throw new NotImplementedException();
		}

		static public planar.Point4dblI ExtendTrigon(planar.cycle_.trigon_.Positive4dbl trigon) {
			// protrude prependicularly from the last point, stop at the parrallel (with respect to the point1-point2) line from the first point
			///find the last point
			///
			var shine = nilnul.geometry.planar.grad_.skid._DirectionX._Direction_assumeDif(trigon.ee.ee.b, trigon.ee.ee.c);



			var rejection = planar.vect.to_.co_.decompose._RejectionX.Rejection(
				
					 planar.grad_._StepX.Vect(
						trigon.ee.ee.b
						,
						trigon.ee.ee.a
					)
					 ,
					 shine

				
			);

			var lastPoint = trigon.ee.ee.c + rejection;

			return lastPoint;









		}



	}
}
