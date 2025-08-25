using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.geometry.planar.troll_.eg_
{
	/// <summary>
	/// Cayley's sextic (sextic of Cayley, Cayley's sextet) is a plane curve, a member of the sinusoidal spiral family, first discussed by Colin Maclaurin in 1718. Arthur Cayley was the first to study the curve in detail and Raymond Clare Archibald named the curve after him
	/// </summary>
	/// <remarks>
	///  this is an example that trigonometrical expr can be converted to polynomial.
	///  but note: sin(x) can not be algebraic as it intersects with xAxis for infinite times, not finite times as polynomial;
	/// </remarks>
	///
	static  class _CarleySexticX
	{
		public class Cartesian
		{
			double a;

			double aQuarter;
			double aQuarterSq;

			public Cartesian( double a)
			{
				this.a = a;
				this.aQuarter = a / 4;
				this.aQuarterSq = aQuarter * aQuarter;
			}

			public bool Pred(double x, double y)
			{
				double sqSum = x * x + y * y;
				return 4 * Math.Pow(sqSum - aQuarter * x, 3) == 27 * aQuarterSq * sqSum * sqSum;
			}

		}

		public class Polar
		{
			double a;

			double aQuadru;

			public Polar( double a)
			{
				this.a = a;
				this.aQuadru = a * 4;
			}

			public double radius(double x)
			{
				
				return aQuadru * Math.Pow( Math.Cos( x/ 3 ),3) ;
			}

		}
		/// <summary>
		/// when a is defaulted
		/// </summary>
		/// <param name="time"></param>
		/// <returns></returns>
		static public C Locus(double time)
		{
			var trice = 3 * time;
			double v = Math.Pow(Math.Cos(time), 3);
			return new C(
				v * Math.Cos(trice),
				v * Math.Sin(trice)

			);
		}



	}


	internal class ICarleySextic
	{
	}
}
