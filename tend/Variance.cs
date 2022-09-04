using nilnul.geometry.planar.point;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;

namespace nilnul.geometry.planar.tend
{
	static public class _VarianceX
	{






	

		static public double Variance(Point4dbl point, Point4dblI point1)
		{

			return geometry.planar.point._VarianceX.Variance(point1 - point);
		}
		


		static public double Variance(Point4dblI point, Point4dblI point1)
		{

			return Variance(point.ToOrthogonal(),point1);
		}

	
		public static double Variance(this TwinD points)
		{
			return Variance(points.component,points.component1);
		}

		static public double Variance(this planar.Tend4dblI span) {
			return Variance(span.points);
		}

		static public double Variance(this planar.Tend4dbl span) {
			return Variance((Tend4dblI)span);
		}

		public static double Variance(this point.CoD points)
		{
			return Variance(points.component,points.component1);
		}

	}
}
