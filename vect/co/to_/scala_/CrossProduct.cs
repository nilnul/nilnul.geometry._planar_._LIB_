using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using N = nilnul._num.bigint.be.Natural.Asserted;
using Q1 = nilnul.num.Quotient1;
using Qr = nilnul.num.real_.Quotient;
using R = nilnul.num.RealI;
using Rx = nilnul.num.RealIX;

//using nilnul.num;
using nilnul.geometry.planar.point_;
using System.Numerics;

namespace nilnul.geometry.planar.vect.co.to_.real_
{

	/// <summary>
	/// in 3d, the cross product is a vector. in 2d, the result is a scalar value.
	/// </summary>
	/// for example: torque
	///		when you drive a screw, the direction of the screw is perpendicular to your force and the wrench.
	///	a measure of perpendicularity. <see cref="_DotProductX"/>, a measure of parallelism.
	static public class _CrossProductX
	{
		/// <summary>
		/// signed area
		/// </summary>
		/// <param name="x"></param>
		/// <param name="y"></param>
		/// <returns></returns>
		static public R SurroundedOfParallelogram(VectorI x, VectorI y)
		{
			return to_._AsMatrixX.GetDeterminant(x, y);
		}

		static public double SurroundedOfParallelogram(geometry.planar.Point4dblI x, Point4dblI y)
		{
			return to_._AsMatrixX.GetDeterminant(x, y);
		}
		static public double SurroundedOfParallelogram(geometry.planar.Point4dbl x, Point4dbl y)
		{
			return SurroundedOfParallelogram(
				(geometry.planar.Point4dblI) x
				,
				(geometry.planar.Point4dblI)y
			);
		}

		static public double SurroundedOfParallelogram(geometry.planar.Vect4dblI x, Vect4dblI y)
		{
			/// <see cref="vect_.polar.co.to_.scalar_._CrossProductX"/>
			/// we can transform the vect to polar vect: r*e^ia, s*e^ib.
			/// the cross product is rs * sin(b-a)
			/// = rs (sin(b) cos(a) - cos(b)sin(a) )
			/// = r cos(a) * s*sin(b) - r*sin(a) * s*cos(b)
			/// = x1 * y2 - y1 * x2

			return to_._AsMatrixX.GetDeterminant(x, y);
		}
		static public double SurroundedOfParallelogram(geometry.planar.Vect4dbl x, Vect4dbl y)
		{

			return SurroundedOfParallelogram((Vect4dblI) x, (Vect4dblI) y);
		}


		static public double SurroundedOfParallelogram(geometry.planar.Vector4dblI x, Vector4dblI y)
		{
			/// <see cref="vect_.polar.co.to_.scalar_._CrossProductX"/>
			/// we can transform the vect to polar vect: r*e^ia, s*e^ib.
			/// the cross product is rs * sin(b-a)
			/// = rs (sin(b) cos(a) - cos(b)sin(a) )
			/// = r cos(a) * s*sin(b) - r*sin(a) * s*cos(b)
			/// = x1 * y2 - y1 * x2

			return to_._AsMatrixX.GetDeterminant(x, y);
		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="a">vect1.x</param>
		/// <param name="b">vect1.y</param>
		/// <param name="c"></param>
		/// <param name="d"></param>
		/// <returns></returns>
		static public double SurroundedOfParallelogram(double a, double b, double c, double d)
		{
			return num.real.matrix_.sq_._SecondaryX.Determinant(a, b, c, d);
			return a * d - c * b;

			//return nilnul.num.real.matrix_.square_._SecondaryX.Determinant(a,b,c,d);
		}

		static public double SurroundedOfParallelogram(Complex a, Complex b)
		{

			return SurroundedOfParallelogram(a.Real,a.Imaginary,b.Real,b.Imaginary );
		}

		static public double SurroundedOfParallelogram((double x, double y) a, (double x, double y) b)
		{

			return SurroundedOfParallelogram(a.x,a.y,b.x,b.y);
		}
		


		/// <summary>
		/// signed area
		/// </summary>
		/// <param name="x"></param>
		/// <param name="y"></param>
		/// <returns></returns>

		static public R SurroundedOfParallelogram(Vector1 x, Vector1 y)
		{
			return to_._AsMatrixX.GetDeterminant(x, y);
		}

		/// <summary>
		/// signed area
		/// </summary>
		/// <param name="x"></param>
		/// <param name="y"></param>
		/// <returns></returns>
		static public R SurroundedOfParallelogram(IVector x, IVector y)
		{
			return to_._AsMatrixX.GetDeterminant(x, y);
		}

	

	/// <summary>
	/// Finds the cross product of the 2 vectors
	/// The vectors make a "left turn" if the sign of the cross product is positive.
	/// The vectors make a "right turn" if the sign of the cross product is negative.
	/// The vectors are colinear (on the same line) if the cross product is zero.
	/// </summary>

	

		
		static public R SurroundedOfParallelogram(Co src)
		{
			return SurroundedOfParallelogram(src.component,src.component1);
			//throw new NotImplementedException();
		}




		/// <summary>
		/// signed area
		/// </summary>
		/// <param name="x"></param>
		/// <param name="y"></param>
		/// <returns></returns>

		static public R SurroundedOfParallelogram(PointI1 vector, PointI1 begin)
		{
			return SurroundedOfParallelogram(
				new Vector1(vector) as IVector
				,
				new Vector1(begin) as IVector
			);
			//throw new NotImplementedException();
		}
		/// <summary>
		/// signed area
		/// </summary>
		/// <param name="x"></param>
		/// <param name="y"></param>
		/// <returns></returns>

		static public R SurroundedOfParallelogram(Point1 vector, Point1 begin)
		{
			return SurroundedOfParallelogram(
				new Vector1(vector) 
				,
				new Vector1(begin)
			);
			//throw new NotImplementedException();
		}


		

	}
}

/*cross product exists only in 3d and 7d*/
