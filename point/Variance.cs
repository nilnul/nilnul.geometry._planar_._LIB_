using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using R = nilnul.num.RealI;
using r = nilnul.num.real;
using System.Numerics;

namespace nilnul.geometry.planar.point
{
	/// <summary>
	/// x^2 + y ^2 
	/// </summary>
	static public class _VarianceX
	{

	
		static public double Variance(double x, double y)
		{



			return (
				nilnul.num.ieee.op_._SquareX.Square(x)
				+
				nilnul.num.ieee.op_._SquareX.Square(y)


			);
		}





		static public double Variance(this Point4dbl p)
		{

			return Variance(p.x, p.y);

		}

		static public double Variance(this Point4dblI p)
		{

			return Variance(p.x, p.y);

		}

		 static public  double Variance(this Complex base1d)
		{
			return Variance(base1d.Real, base1d.Imaginary);
		}
	}
}
