using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using nilnul.num;

using R = nilnul.num.RealI;
using nilnul.num.real;



namespace nilnul.geometry.planar.zone_.gon_.trigon
{
	/// <summary>
	/// area but with sign:
	///		counterClock if sign is positve
	///		clock if sign is neg
	///		colinar if sign is zero
	/// </summary>
	static public class _SweepX

	{

		static public R SignedArea(Point1 a, Point1 b, Point1 c)
		{
			return  nilnul.geometry.planar.vect.co._CrossProductX.AreaOfParallelogram(
				b-a
				,
				c-b
			).Half() ;

		}
		static public R SignedArea(PointI1 a, PointI1 b, PointI1 c) {

			return SignedArea(new Point1(a)
				,new Point1(b)
				,new Point1(c)
			);
		}
		static public nilnul.num.RealI SignedArea(point.Trio src)
		{
			return SignedArea(src.a, src.b, src.c);

		}


		

	}
}
