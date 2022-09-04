using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.geometry.planar.point_
{
	static public  class PolarDX
	{

		//static public PointF ToPointF(double radius, double angle)
		//{
		//	return new PointD(
		//		radius * Math.Cos(angle)
		//		,
		//		radius * Math.Sin(angle)
		//	).toPointF();
		//}

		static public PointF ToPointF(double radius, double degree)
		{
			return ToPointDbl(radius, degree).toPointF();
		}
		static public Point4dbl ToPointDbl(double radius, double degree)
		{
			return new Point4dbl(
				radius * Math.Cos(degree)
				,
				radius * Math.Sin(degree)
			);
		}
	}
}
