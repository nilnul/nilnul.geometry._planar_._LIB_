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

using nilnul.num;
using nilnul.geometry.planar.point_;

namespace nilnul.geometry.planar.vect.co
{

	[Obsolete(
		nameof(nilnul.geometry.planar.vect.co.to_.real_._CrossProductX)
	)]
	static public class _CrossProductX
	{
		/// <summary>
		/// signed area
		/// </summary>
		/// <param name="x"></param>
		/// <param name="y"></param>
		/// <returns></returns>
		static public R AreaOfParallelogram(VectorI x, VectorI y)
		{
			return to_._AsMatrixX.GetDeterminant(x, y);
		}
		/// <summary>
		/// signed area
		/// </summary>
		/// <param name="x"></param>
		/// <param name="y"></param>
		/// <returns></returns>

		static public R AreaOfParallelogram(Vector1 x, Vector1 y)
		{
			return to_._AsMatrixX.GetDeterminant(x, y);
		}

		/// <summary>
		/// signed area
		/// </summary>
		/// <param name="x"></param>
		/// <param name="y"></param>
		/// <returns></returns>
		static public R AreaOfParallelogram(IVector x, IVector y)
		{
			return to_._AsMatrixX.GetDeterminant(x, y);
		}

	

	/// <summary>
	/// Finds the cross product of the 2 vectors
	/// The vectors make a "left turn" if the sign of the cross product is positive.
	/// The vectors make a "right turn" if the sign of the cross product is negative.
	/// The vectors are colinear (on the same line) if the cross product is zero.
	/// </summary>

	

		
		static public R AreaOfParallelogram(Co src)
		{
			return AreaOfParallelogram(src.component,src.component1);
			//throw new NotImplementedException();
		}




		/// <summary>
		/// signed area
		/// </summary>
		/// <param name="x"></param>
		/// <param name="y"></param>
		/// <returns></returns>

		static public R AreaOfParallelogram(PointI1 vector, PointI1 begin)
		{
			return AreaOfParallelogram(
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

		static public R AreaOfParallelogram(Point1 vector, Point1 begin)
		{
			return AreaOfParallelogram(
				new Vector1(vector) 
				,
				new Vector1(begin)
			);
			//throw new NotImplementedException();
		}


		

	}
}
