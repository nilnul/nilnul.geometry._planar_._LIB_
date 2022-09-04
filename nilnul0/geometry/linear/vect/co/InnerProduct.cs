using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using nilnul.num;

namespace nilnul.geometry.linear.vect.co
{
	static public class _InnerProductX
	{
		static public nilnul.num.RealI InnerProduct(nilnul.num.RealI x, nilnul.num.RealI y) {

			return InnerProduct(x.ToReal(),y.ToReal());
		}
		static public nilnul.num.RealI InnerProduct(Point x, Point y) {

			return InnerProduct(x.x,y.x);
		}

		static public nilnul.num.Real InnerProduct(nilnul.num.Real x, nilnul.num.Real y) {

			return x * y;
		}

		public static RealI InnerProduct(VectI x, VectI y)
		{
			return x.end.x.ToReal() * y.end.x.ToReal();
		}
		public static double InnerProduct(Vect4dblI vector, Vect4dblI vector2BeIncluded)
		{
			return vector.end.coord * vector2BeIncluded.end.coord;
		}
		public static RealI Sqaure(VectI x)
		{
			return nilnul.num.real.op_.unary_._SquareX.Op(x.end.x);
		}
		public static double Sqaure(Vect4dblI x)
		{
			return nilnul.num.real.convert_._SquareX.Square(x.end.coord);
		}

	}
	public class InnerProduct : co.to_.RealI
	{
		public nilnul.num.RealI op(Duo arg)
		{
			return _InnerProductX.InnerProduct(arg.Item1,arg.Item2);
			throw new NotImplementedException();
		}


		public nilnul.num.RealI op(Point a, Point b) {
			return _InnerProductX.InnerProduct(a,b);
		}
		public nilnul.num.RealI op(nilnul.num.RealI x, nilnul.num.RealI y) {
			return _InnerProductX.InnerProduct(x,y);
		}


		static public InnerProduct Singleton
		{
			get
			{
				return nilnul._obj.Singleton<InnerProduct>.Instance;
			}
		}

	}
}
