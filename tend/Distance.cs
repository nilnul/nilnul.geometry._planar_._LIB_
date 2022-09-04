using nilnul.geometry.planar.point;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;

namespace nilnul.geometry.planar.tend
{
	static public class _DistanceX
	{

		static public nilnul.num.real_.NonnegI Distance(Point1 a, Point1 b)
		{
			return
				(a - b).Deviation();
		}

		static public nilnul.num.real_.NonnegI Distance(PointI1 a, PointI1 b)
		{
			return
				Distance(new Point1(a), new Point1(b));
		}

		static public nilnul.num.real_.NonnegI Distance(this planar.point.Co  a)
		{
			return
				Distance(a.component,a.component1);
		}

		static public nilnul.num.real_.NonnegI Distance(this planar.TendI  a)
		{
			return
				Distance(a.points.begin,a.points.end);
		}




		static public double Distance(Point4dbl point, Point4dbl point1)
		{

			return geometry.planar.point._DeviationX.Deviation(point1 - point);
		}

		static public double Distance(PointF point, PointF point1)
		{

			return geometry.planar.vect._MagnitudeX.Magnitude( geometry.planar.grad._DisplaceX.VectAsPoint(point, point1)
			);
		}


		static public double Distance(Point4dblI point, Point4dblI point1)
		{

			return geometry.planar.point._DeviationX.Deviation(point1.ToOrthogonal() - point);
		}

	

		static public double Distance(this planar.Tend4dblI span) {
			return Distance(span.points);
		}

		static public double Distance(this planar.Tend4dbl span) {
			return Distance((Tend4dblI)span);
		}

		public static double Distance(this TwinD points)
		{
			return Distance(points.component,points.component1);
		}
		public static double Distance(this point.CoD points)
		{
			return Distance(points.component,points.component1);
		}

	}
}
