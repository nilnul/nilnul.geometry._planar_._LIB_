using nilnul.num;
using System;

namespace nilnul.geometry.linear.vect.co.to_.real_
{
	static public class _InnerProductX
	{
		static public nilnul.num.Real InnerProduct(nilnul.num.Real x, nilnul.num.Real y) {

			return x * y;
		}
		static public nilnul.num.RealI InnerProduct(nilnul.num.RealI x, nilnul.num.RealI y) {

			return InnerProduct(x.ToReal(),y.ToReal());
		}
		static public nilnul.num.RealI InnerProduct(Point x, Point y) {

			return InnerProduct(x.x,y.x);
		}


		public static double InnerProduct(double x, double y)
		{
			return x * y;

			//throw new NotImplementedException();
		}

		public static num.RealI InnerProduct(PointI x, PointI y)
		{
			return InnerProduct(x.x,y.x);

		}
	}
}
