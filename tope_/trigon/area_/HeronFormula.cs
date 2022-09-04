using nilnul.geometry.planar.cycle_.trigon.edges;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace nilnul.geometry.planar.tope_.trigon.area_
{
	/// <summary>
	///
	/// this can be proved by:
	///		cosine theorem:
	///			cos(C) =( a**2 + b**2 -c**2 ) / (2ab)
	///		and
	///		sine formula for area:
	///			1/2 * a * b * sin(C)
	///			=1/2 * a * b * Sqrt( 1- Cos(C) **2     )
	/// </summary>
	static public  class _ByHeronFormulaX
	{
		


		static public double _Eval_ofThreeEdgeLengths(double a, double b, double c)
		{

			var perimeter = a + b + c;
			var halfPer = perimeter / 2;

			return Math.Sqrt(halfPer
				* (halfPer - a)
					* (halfPer - b)
							* (halfPer - c)

				);



		}
		static public double _Eval_ofThreeEdgeLengths(IEnumerable<double> edgeLength_s)
		{

			return _Eval_ofThreeEdgeLengths(edgeLength_s.ElementAt(0), edgeLength_s.ElementAt(1), edgeLength_s.ElementAt(2)); 

		}

		static public double Area(LengthsDouble triangle)
		{

			double semiPerimeter = triangle.semiPerimetr();

			return Math.Sqrt(semiPerimeter
				* (semiPerimeter - triangle.a.val)
					* (semiPerimeter - triangle.b.val)
							* (semiPerimeter - triangle.c.val)
			);
		}

		static public double Area_ofCycle(double a, double b, double c)
		{
			return Area(new cycle_.trigon. edges.LengthsDouble(a, b, c));

		}

		static public double Eval(
			Point4dbl x,
			Point4dbl y
			,
			Point4dbl z
		)
		{
			return Area_ofCycle(
				nilnul.geometry.planar.tend._DistanceX.Distance(x, y)
				,
				nilnul.geometry.planar.tend._DistanceX.Distance(y, z)
				,
				nilnul.geometry.planar.tend._DistanceX.Distance(z, x)

			);

		}

	static public double Eval(
			point.TrioD x
		)
		{
			return _Eval_ofThreeEdgeLengths(
				x.edgeLength_s()

			);

		}
		//static public double Eval(
		//	point.trio.b.Distinct.Asserted x
		//)
		//{
		//	return _Eval_ofThreeEdgeLengths(
		//		x.val.edgeLength_s()

		//	);

		//}
	}
}


