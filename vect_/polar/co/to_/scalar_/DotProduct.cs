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

namespace nilnul.geometry.planar.vect_.polar.co
{
	

	/// <summary>
	/// 
	/// </summary>
	/// <remarks>
	/// alias:
	///		dot product
	///		scalar product.
	///	vs :
	///		InnerProduct,
	///			inner product results  a vector 
	/// </remarks>

	static public class _DotProductX
	{

		

		/// <summary>
		/// rEx (.) sEy = r*cos(x) * s * cos(y) + r*sin(x) * s*sin(y) = rs * cos(x-y)
		/// </summary>
		/// <remarks>
		/// interpretation:
		///		rsCos(x-y)
		///		=r * Cos(x-y)   * s
		///			where the first part is the decomposed projection. <see cref="planar.vect.to_.co_.decompose._ProjectionX"/>
		///				the second part is the new measure scale of the new axis.
		/// </remarks>
		/// <param name="point"></param>
		/// <param name="point1"></param>
		/// <returns></returns>
		static public double _Dbl_assumeNonnils(planar.point_.Polar4dbl point, planar.point_.Polar4dbl point1)
		{
			return vect.to_.co_.decompose._ProjectionX.ScalarProject(point, point1.azimuth) * point1.radius;

			return point.radius * point1.radius * Math.Cos(
				planar.vect_.nonnil.co._RotationX._Rotation_assumeNonnils(point,point1)
			);

				
				
		}

		static public double _Dbl_assumeNonnils(planar.vect_.Polar4dbl point, planar.vect_.Polar4dbl point1)
		{
			return
				_Dbl_assumeNonnils(point.polarPoint, point1.polarPoint)
				;
		}

	
	}
}
