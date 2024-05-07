using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using P = nilnul.geometry.planar.Point4dbl;

namespace nilnul.geometry.planar.cloze_.gon_.orthy.of_.steps_
{
	static public class _DeriveLastX
	{
		/// <summary>
		/// the last two steps: into last, and from last to initial point, are not provided, but derived here.
		/// </summary>
		/// <remarks>
		/// 
		/// use your right hand, curl your nonthumb 4 fingers following x, and then y, remember now the direction of the thumb pointing to.
		/// at anywhere, orient your fingers the same way such that the thumb points to the same direction like to the pole star. Then the nothumb rotation is positive, and its opposite is negative.
		/// </remarks>
		/// <param name="stepsWithoutLastTwo">
		/// if empty, returns a single point, the origin.
		/// if one edge, return origin, the end of the edge, the origin as the last vertex. (the orgin as the resettle point one is not returned)
		/// if two edges, return origin, the end of the 1st edge, the end of the second edge, the last vertex.
		/// </param>
		/// <returns></returns>
		static public IEnumerable<Complex> _Vertices_0stepsWithoutLastTwo(
			IEnumerable<double> stepsWithoutLastTwo
		)
		{
			var lastP = new Complex();

			yield return lastP;

			var directionAsComplex = new Complex(1, 0);
			var quarter = new Complex(0, 1);
			var negQuarter = new Complex(0, -1);


			foreach (var item in stepsWithoutLastTwo)
			{
				if (item == 0)
				{
					yield return lastP;
				}
				else
				{
					lastP += item * directionAsComplex;
					yield return lastP;

					if (item < 0)
					{
						directionAsComplex *= negQuarter;
						//directionAsComplex = -directionAsComplex;
					}
					else
					{
						directionAsComplex *= quarter;

					}


				}
			}
			// last p

			yield return  lastP+ nilnul.geometry.planar.vect.co.scala_._DotProductX.Dbl(
				-lastP
				,
				directionAsComplex
			) * directionAsComplex;


		}



	}
}
