using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.geometry.planar.curve_.algebraic_.bezier.interpolate_
{
	/// <summary>
	/// the "de Casteljau" algorithm to find the point of the trail given the parameter
	/// </summary>
	static public class _DeCasteljauX
	{
		static public Point4dbl _Point_pointsAssumeStarted_timeAssumeProbPair(IEnumerable<Point4dbl> points, double t, double complement)
		{
			if (points.Count() ==1)
			{
				return points.First();
			}
			

			return _Point_pointsAssumeStarted_timeAssumeProbPair(
				new nilnul.obj.co.str.of_._PeekAhead_ovStr<Point4dbl>(points).Select(
					p1=>
					complement*p1.Item1 + t*p1.Item2

				),t,complement
			);

		}
		static public Point4dbl _Point_pointsAssumeStarted_timeAssumeProbPair(IEnumerable<Point4dblI> points, double t, double complement)
		{
			

			return _Point_pointsAssumeStarted_timeAssumeProbPair(
				points.Select(p=>p.ToOrthogonal()),t,complement
			);

		}
  
		static public Point4dbl Point_timeAssumeProbPair(planar.point.str_.Started4dbl points, double t, double complement)
		{
			return _Point_pointsAssumeStarted_timeAssumeProbPair(
				points.Select(p=>p.ToOrthogonal()),t,complement
			);
		}

		static public Point4dbl Point_timeAssumeProbPair(planar.curve_.algebraic_.Bezier4dbl points, double t, double complement)
		{
			return _Point_pointsAssumeStarted_timeAssumeProbPair(
				points.points,t,complement
			);
		}

   
	}
}
