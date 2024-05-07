using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using N = nilnul._num.bigint.be.Natural.Asserted;
using Q1 = nilnul.num.Quotient1;
using Qr = nilnul.num.real_.Quotient;
using RI = nilnul.num.RealI;
using Rx = nilnul.num.RealIX;

using nilnul.num;
using nilnul.geometry.planar.point_;
using nilnul.geometry.planar.vect_;
using nilnul.geometry.linear;

namespace nilnul.geometry.planar.vect.co.scala_
{
	/*// the angle between the two vectors is less than 90 degrees. 
Vector2.Dot(vector1.Normalize(), vector2.Normalize()) > 0 

// the angle between the two vectors is more than 90 degrees. 
Vector2.Dot(vector1.Normalize(), vector2.Normalize()) < 0 

// the angle between the two vectors is 90 degrees; that is, the vectors are orthogonal. 
Vector2.Dot(vector1.Normalize(), vector2.Normalize()) == 0 

// the angle between the two vectors is 0 degrees; that is, the vectors point in the same direction and are parallel. 
Vector2.Dot(vector1.Normalize(), vector2.Normalize()) == 1 

// the angle between the two vectors is 180 degrees; that is, the vectors point in opposite directions and are parallel. 
Vector2.Dot(vector1.Normalize(), vector2.Normalize()) == -1 */

	/// <summary>
	/// 
	/// </summary>
	/// <remarks>
	/// alias:
	///		inner product
	///		dot product
	///		scalar product.
	///	vs :
	///		InnerProduct,
	///			inner product results  a vector 
	/// </remarks>
	///he real dot product is extended to a complex dot product using the complex conjugate: ∑( a[i] conjugate(b[i]) )
	/// 
	/// a measure of parallelism. <see cref="_CrossProductX"/>, a measure of pendicularity

	static public class _DotProductX
	{

		static public RI RealI(Vector1 point, Vector1 point1) {
			return 
				(point.r *point1.r + point.r1*point1.r1)
				;

		}

		static public RI RealI(IVector point, IVector point1) {
			return 
				(point.point.x.ToReal() *point1.point.y.ToReal() + point.point.y.ToReal()*point1.point.y.ToReal())
				;

		}

		static public RI RealI_Square(IVector point) {
			return
				nilnul.num.real.op_.unary_._SquareX.Op(point.point.x).ToReal() + nilnul.num.real.op_.unary_._SquareX.Op(point.point.y);
				
				;

		}

		static public RI RealI_Square(planar.PointI1 point) {
			return
				RealI_Square(new planar.Vector1(point))
				
				;

		}
		static public RI RealI(Co src)
		{
			return RealI(src.component,src.component1);
			//throw new NotImplementedException();
		}

		static public RI RealI(PointI1 vector, PointI1 begin)
		{
			return RealI(
				new Vector1(vector)
				,
				new Vector1(begin)
			);
			//throw new NotImplementedException();
		}

		static public RI RealI(Point1 vector, Point1 begin)
		{
			return RealI(
				new Vector1(vector)
				,
				new Vector1(begin)
			);
			//throw new NotImplementedException();
		}

		static public RI RealI(vect_.Nonnil vector, Vector1 begin)
		{
			return RealI(vector, (IVector)(begin));
		}

		static public RI RealI(vect_.Nonnil vector, Point1 begin)
		{
			return RealI(vector, new Vector1(begin));
		}

		static public double Dbl(Point4dbl point, Point4dbl point1)
		{
			return
				(point.x * point1.x + point.y * point1.y)
				;
		}
		static public double Dbl(System.Numerics.Complex point, System.Numerics.Complex point1)
		{
			return
				(point.Real * point1.Real + point.Imaginary * point1.Imaginary)
				;
		}
		static public double Dbl(Complex4dbl point, Complex4dbl point1)
		{
			return
				(point.x * point1.x + point.y * point1.y)
				;
		}



		static public double Dbl(Point4dblI point, Point4dblI point1)
		{
			return
				(point.x * point1.x + point.y * point1.y)
				;
		}

		static public double Dbl(Vector4dblI point, Vector4dblI point1)
		{
			return
				Dbl(point.point, point1.point)
				;
		}

		static public double Dbl(VectorDbl point, VectorDbl point1)
		{
			return
				Dbl(point.boxed, point1.boxed)
				;
		}
		static public double Dbl(Vect4dblI point, Vect4dblI point1)
		{
			return
				Dbl(point.point, point1.point)
				;
		}


		public static double Dbl(NonnilDblI vector, VectorDbl vectorDbl)
		{
			return Dbl((Vector4dblI)vector, vectorDbl);
		}


		static public double Square(Vector4dblI point)
		{
			return nilnul.num.real.convert_._SquareX.Square(point.point.x) + nilnul.num.real.convert_._SquareX.Square(point.point.y);
			;
		}
		static public double Square(Vect4dblI point)
		{
			return nilnul.num.real.convert_._SquareX.Square(point.point.x) + nilnul.num.real.convert_._SquareX.Square(point.point.y);
			;
		}

		static public double Square(Vect4dbl point)
		{
			return nilnul.num.real.convert_._SquareX.Square(point.point.x) + nilnul.num.real.convert_._SquareX.Square(point.point.y);
			;
		}

		public static double Square(Point4dblI pointDbl1)
		{
			return nilnul.num.real.op_.unary_.Square.Singleton.op(pointDbl1.x)
				+
				nilnul.num.real.op_.unary_.Square.Singleton.op(pointDbl1.y);
			;


		}
		public static double Square(Point4dbl pointDbl1)
		{
			return Square(pointDbl1 as Point4dblI);

			
		}

		public static double Square(VectorDbl pointDbl1)
		{
			return Square(
				(Vector4dblI)(pointDbl1)
			);
			//throw new NotImplementedException();
		}


		public static double Dbl(Vect4dblI tgtBasis, Point4dblI point2proj)
		{
			return Dbl(tgtBasis.point,point2proj);
		}

		

	
	}
}
