using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using R = nilnul.num.RealI;
using r = nilnul.num.real;

namespace nilnul.geometry.planar.point
{
	/// <summary>
	/// distance from origion;
	///		delta
	///		norm
	///		mod
	///		radis
	///		departure
	/// </summary>
	static public class _DeviationX
	{

		static public nilnul.num.real_.NonnegI Deviation(this PointI1 p)
		{
			return nilnul.num.real_.nonneg.op_.unary_.Sqrt.Singleton.op(

					r.op_.binary_.Add.Singleton.op(

						nilnul.num.real.op_.unary_._SquareX.Op(p.x)
						,

						nilnul.num.real.op_.unary_.Square.Singleton.op(p.y)
					)


			);

		}
		static public nilnul.num.real_.NonnegI Deviation(this Point1 p)
		{



			return Deviation((PointI1)p);

		}
		static public double Deviation(double x, double y)
		{



			return Math.Sqrt(
				nilnul.num.ieee.op_._SquareX.Square(x)
				+
				nilnul.num.ieee.op_._SquareX.Square(y)


			);
		}





		static public double Deviation(this Point4dbl p)
		{

			return Deviation(p.x, p.y);

		}

		static public double Deviation(this Point4dblI p)
		{

			return Deviation(p.x, p.y);

		}


	}
}
