using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using nilnul.num.real.double_.op;
using PointD = nilnul.geometry.planar.Point4dbl;


namespace nilnul.geometry.planar.point
{
	static public  class _ScaleX
	{
		static public Point4dbl Eval(double x,double y, double scale) {
			


			return new Point4dbl(scale*x, scale* y);
		}
		static public PointF Scale(PointF p, float s)
		{

			return new PointF(p.X * s, p.Y * s);

		}


		static public Point4dbl Scale(this Point4dbl point, double scale) {

			return _ScaleX.Eval(point.x,point.y,scale);
		}

		

	}
}
